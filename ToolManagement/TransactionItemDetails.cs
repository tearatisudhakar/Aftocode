using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ToolDataAccessLayer;
using TooLManagementEntities;
using ToolBusinessLogiclayer;

namespace ToolManagement
{
    public partial class TransactionItemDetails : Form
    {
        public TransactionItemDetails(int ItemId)
        {
            try
            {
                InitializeComponent();
                BindTransactionDetails(ItemId);
                FiilSelectedDetails(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        public TransactionItemDetails()
        {
            try
            {

                InitializeComponent();
                //BindTransactionDetails(ItemId);
                FiilSelectedDetails(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        DataSet ds = null;
        AddItemBo objbo = new AddItemBo();
        ToolBAL objbal = new ToolBAL();
        ToolDAL DAL = new ToolDAL();
        //int itemId = 0;
        string strCategory = string.Empty;
        string strGroup = string.Empty;
        string strItemtype = string.Empty;
        string strDescription = string.Empty;
        string strItemcode = string.Empty;
        int itemId1 = 0;

        public void BindTransactionDetails(int ItemId)
        {
            try
            {
                gvTransactionDetails.Columns.Clear();
                ds = new DataSet();

                ds = objbal.TransactionInfo(ItemId);
                if (ds.Tables[0].Rows.Count>0)
                {
                    gvTransactionDetails.DataSource = ds.Tables[0];
                    gvTransactionDetails.Columns["ProcessLogId"].Visible = false;
                    gvTransactionDetails.AutoResizeColumns();
                }
                if (ds != null && ds.Tables.Count > 2)
                {
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        string absolutePath = ds.Tables[2].Rows[0]["imagepath"].ToString();
                        if (File.Exists(absolutePath))
                        {

                            picBxforIssue.Image = System.Drawing.Image.FromFile(absolutePath);
                        }
                        else
                        {
                            picBxforIssue.Image = null;
                        }
                    }
                }
                else
                {
                    picBxforIssue.Image = null;
                }
            }
            catch (Exception)
            {
                throw ;
            }
        }
        
        public void FiilSelectedDetails(DataSet ds)
        {
            gvTransactionDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            gvTransactionDetails.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            gvTransactionDetails.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            //   DataSet ds = new DataSet();
            //this.gvTransactionDetails.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            //this.gvTransactionDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    strCategory = ds.Tables[1].Rows[0]["Item Category"].ToString();
                    strGroup = ds.Tables[1].Rows[0]["Item Group"].ToString();
                    strItemtype = ds.Tables[1].Rows[0]["Item Type"].ToString();
                    strItemcode = ds.Tables[1].Rows[0]["Item Code"].ToString();
                    strDescription = ds.Tables[1].Rows[0]["Item Description"].ToString();
                    itemId1 = Convert.ToInt32(ds.Tables[1].Rows[0]["Item id"].ToString());
                    txtInDex.Text = strCategory + " , " + strGroup + " , " + strItemtype;
                    txtDescription.Text = strDescription;
                    txtItemCode.Text = strItemcode;
                    TxtMadeBy.Text = ds.Tables[1].Rows[0]["User Name"].ToString();
                    txtTransactionDate.Text = ds.Tables[0].Rows[0]["CreatedTimeStamp"].ToString();
                    txtSupplier.Text = ds.Tables[1].Rows[0]["Supplier"].ToString();
                    txtUnitCost.Text = ds.Tables[0].Rows[0]["Task"].ToString();
                    txtPoNo.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gvTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (gvTransactionDetails.Rows[e.RowIndex].Cells[3].Value != null)
                    {
                        int itemId = Convert.ToInt32(gvTransactionDetails.Rows[e.RowIndex].Cells[3].Value);
                    }
                        FiilSelectedDetails(ds);

                    int Logid = Convert.ToInt32(gvTransactionDetails.Rows[e.RowIndex].Cells[0].Value);
                    DataSet ds2 = new DataSet();

                    ds2 = DAL.BindProcesslog(Logid);
                    if (ds2 != null && ds2.Tables.Count > 0)
                    {
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            txtTransactionDate.Text = ds2.Tables[0].Rows[0]["CreatedTimeStamp"].ToString();
                            txtUnitCost.Text = ds2.Tables[0].Rows[0]["Task"].ToString();
                            txtPoNo.Text = ds2.Tables[0].Rows[0]["Quantity"].ToString();
                        }
                    }
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
            if (gvTransactionDetails != null)
            {
                if (gvTransactionDetails.Rows.Count > 0)
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
                worksheet.Name = this.Text;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < gvTransactionDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < gvTransactionDetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gvTransactionDetails.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex+1, cellColumnIndex] = gvTransactionDetails.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(gvTransactionDetails.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = gvTransactionDetails.Rows[i].Cells[j].Value.ToString();
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