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
    public partial class IssuedDetals : Form
    {
        public IssuedDetals()
        {
            InitializeComponent();
            FillIssuedDetails();
        }

        ToolDAL DAL = new ToolDAL();
        int itemId = 0;
        int issued = 0;
        string strItemcode = string.Empty;
        string strUserName = string.Empty;

        public void FillIssuedDetails()
        {
            GvIssuedItemDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            GvIssuedItemDetails.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            GvIssuedItemDetails.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            //this.GvIssuedItemDetails.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            //this.GvIssuedItemDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                DataSet ds = new DataSet();
                if (Login.IsAdmin)
                {
                    ds = DAL.IssuedDetails(Login.UserId, 1);
                }
                else
                {
                    ds = DAL.IssuedDetails(Login.UserId, 0);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GvIssuedItemDetails.DataSource = ds.Tables[0];
                    strItemcode = ds.Tables[0].Rows[0]["Item code"].ToString();
                    itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["ItemId"].ToString());
                    issued = Convert.ToInt32(ds.Tables[0].Rows[0]["Issued count"].ToString());
                    GvIssuedItemDetails.Columns["ItemId"].Visible = false;
                    GvIssuedItemDetails.Columns["IssuId"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Issued items", "ISSUED ITEMS");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void GvIssuedItemDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    strItemcode = GvIssuedItemDetails.Rows[e.RowIndex].Cells["Item code"].Value.ToString();
                    itemId = Convert.ToInt32(GvIssuedItemDetails.Rows[e.RowIndex].Cells["ItemId"].Value);
                    issued = Convert.ToInt32(GvIssuedItemDetails.Rows[e.RowIndex].Cells["Issued count"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (issued > 0)
                {
                    ReturnItem returnfrm = new ReturnItem(strItemcode, issued);
                    returnfrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Non of this item has been issued", "No Issues");
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
                    string IssueID = txtInput.Text;
                    DataSet ds = new DataSet();
                    if (Login.IsAdmin)
                    {
                        // ds = DAL.IssuedDetails(Login.UserId, 1);
                        ds = DAL.ItemInfobyIssueID(Login.UserId, 1, IssueID);
                    }
                    else
                    {
                        ds = DAL.IssuedDetails(Login.UserId, 0);
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        GvIssuedItemDetails.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string IssueID = txtInput.Text;
                    DataSet ds = new DataSet();
                    if (Login.IsAdmin)
                    {
                        ds = DAL.ItemInfobyIssueID(Login.UserId, 1, IssueID);
                    }
                    else
                    {
                        ds = DAL.ItemInfobyIssueID(Login.UserId, 0, IssueID);
                    }

                    GvIssuedItemDetails.DataSource = ds.Tables[0];

                }
                else
                {
                    FillIssuedDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            FillIssuedDetails();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (GvIssuedItemDetails != null)
            {
                if (GvIssuedItemDetails.Rows.Count > 0)
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
                for (int i = 0; i < GvIssuedItemDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < GvIssuedItemDetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GvIssuedItemDetails.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = GvIssuedItemDetails.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(GvIssuedItemDetails.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = GvIssuedItemDetails.Rows[i].Cells[j].Value.ToString();
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
