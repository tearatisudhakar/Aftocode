using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolManagement;
using ToolDataAccessLayer;

namespace ToolManagement
{
    public partial class ReturnItemList : Form
    {
        public ReturnItemList()
        {
            InitializeComponent();
            FillReturnedItems();
        }

        ToolDAL DAL = new ToolDAL();
        public void FillReturnedItems()
        {
            GvReturnItemDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            GvReturnItemDetails.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            GvReturnItemDetails.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            try
            {
                DataSet ds = new DataSet();
                if (Login.IsAdmin)
                {
                    ds = DAL.ReturnItemDetails(Login.UserId, 1);
                }
                else
                {
                    ds = DAL.ReturnItemDetails(Login.UserId, 0);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GvReturnItemDetails.DataSource = ds.Tables[0];
                    GvReturnItemDetails.Columns["Item Id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Return items found", "RETURNED ITEMS");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string ReturnItemId = txtInput.Text;
                    DataSet ds = new DataSet();
                    if (Login.IsAdmin)
                    {
                        // ds = DAL.IssuedDetails(Login.UserId, 1);
                        ds = DAL.ReturnIteminfoDetails(Login.UserId, 1, ReturnItemId);
                    }
                    else
                    {
                        ds = DAL.IssuedDetails(Login.UserId, 0);
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        GvReturnItemDetails.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string ReturnItemId = txtInput.Text;
                    DataSet ds = new DataSet();
                    if (Login.IsAdmin)
                    {
                        // ds = DAL.IssuedDetails(Login.UserId, 1);
                        ds = DAL.ReturnIteminfoDetails(Login.UserId, 1, ReturnItemId);
                    }
                    else
                    {
                        ds = DAL.IssuedDetails(Login.UserId, 0);
                    }
                    GvReturnItemDetails.DataSource = ds.Tables[0];
                }
                else
                {
                    FillReturnedItems();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            FillReturnedItems();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            Inventory obj = new Inventory();
            obj.ShowDialog();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (GvReturnItemDetails != null)
            {
                if (GvReturnItemDetails.Rows.Count > 0)
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
                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < GvReturnItemDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < GvReturnItemDetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GvReturnItemDetails.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = GvReturnItemDetails.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {

                            if (!string.IsNullOrEmpty(GvReturnItemDetails.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = GvReturnItemDetails.Rows[i].Cells[j].Value.ToString();
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
