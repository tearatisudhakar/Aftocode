using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolDataAccessLayer;

namespace ToolManagement
{
    public partial class DeletedItemdetails : Form
    {
        public DeletedItemdetails()
        {
            InitializeComponent();
            FillDeletedDetails();
            if (Login.IsAdmin)
            {
                btnRestore.Visible = true;
            }
            else
            {
                btnRestore.Visible = false;
            }
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        ToolDAL DAL = new ToolDAL();
        int itemId = 0;
        public void FillDeletedDetails()
        {
            this.Gvdeleteditemdtls.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            this.Gvdeleteditemdtls.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                DataSet ds = new DataSet();
                ds = DAL.DletedDetails("");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Gvdeleteditemdtls.DataSource = ds.Tables[0];
                    itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["Item Id"].ToString());
                }
                else
                {
                    Gvdeleteditemdtls.DataSource = null;
                    MessageBox.Show("No deleted items", "DELETE ITEMS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemId > 0)
                {
                    DialogResult dr = MessageBox.Show("Are you sure to restore item " + itemId + " ?", "Restore Item", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        int Result = 0;
                        Result = DAL.ItemRestore(itemId, Login.UserId);
                        if (Result == 1)
                        {
                            MessageBox.Show("Item has been restored successfully.", "Item Restored");
                        }
                        FillDeletedDetails();
                    }
                    else if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Gvdeleteditemdtls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                itemId = Convert.ToInt32(Gvdeleteditemdtls.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            FillDeletedDetails();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string ItemCode = txtInput.Text;
                    DataSet ds = new DataSet();
                    ds = DAL.DletedDetails(ItemCode);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Gvdeleteditemdtls.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            Gvdeleteditemdtls.DataSource = null;
                        }
                    }
                }
                else
                {
                    FillDeletedDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (Gvdeleteditemdtls != null)
            {
                if (Gvdeleteditemdtls.Rows.Count > 0)
                {
                    ExportToExcel();
                }
            }
        }

        /// <summary> 
        /// Exports the datagridview values to Excel. 
        /// </summary> 
        private void ExportToExcel()
        {
            
            try
            {
                // Creating a Excel object. 
                Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                worksheet = workbook.ActiveSheet;

                worksheet.Name =this.Text;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < Gvdeleteditemdtls.Rows.Count; i++)
                {
                    for (int j = 0; j < Gvdeleteditemdtls.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Gvdeleteditemdtls.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = Gvdeleteditemdtls.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(Gvdeleteditemdtls.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = Gvdeleteditemdtls.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        cellColumnIndex++;
                    }
                    if (cellRowIndex == 1)
                    {
                        cellRowIndex = 2;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                worksheet.Cells.WrapText = false;
                excel.Columns.AutoFit();
                excel.Visible = true;

                //Below code commented by Rajkumar due to no need to saving.

                //Getting the location and file name of the excel to save from user. 
                //SaveFileDialog saveDialog = new SaveFileDialog();
                //saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                //saveDialog.FilterIndex = 2;

                //if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    workbook.SaveAs(saveDialog.FileName);
                //    MessageBox.Show("Export Successful");
                //}
                workbook = null;
                excel = null;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
