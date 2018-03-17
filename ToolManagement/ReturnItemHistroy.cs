

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
    public partial class ReturnItemHistroy : Form
    {
        public ReturnItemHistroy()
        {
            InitializeComponent();
            FillReturnItems("", pageIndex, pageSize);
            cmbNoOfRecords.Items.Insert(0, "Size");
            cmbNoOfRecords.Items.Insert(1, "10");
            cmbNoOfRecords.Items.Insert(2, "20");
            cmbNoOfRecords.Items.Insert(3, "30");
            cmbNoOfRecords.Items.Insert(4, "40");
            cmbNoOfRecords.Items.Insert(5, "50");
            cmbNoOfRecords.SelectedIndex = 0;
            ButtunControlForPaging();
        }
        ToolDAL DAL = new ToolDAL();
        Int32 pageIndex = 1;
        int pageSize = 10;
        int totalRecords = 0;
        int totalPages = 0;

        public void ButtunControlForPaging()
        {

            if (pageIndex == 1)
            {
                btnStartPage.Enabled = false;
                btnPreview.Enabled = false;
                btnNext.Enabled = true;
                btnLastPage.Enabled = true;
            }
            else
            {
                btnStartPage.Enabled = true;
                btnPreview.Enabled = true;
            }
            if (totalRecords == 1 || pageSize > totalRecords)
            {
                btnStartPage.Enabled = false;
                btnPreview.Enabled = false;
                btnNext.Enabled = false;
                btnLastPage.Enabled = false;
            }

        }

        public void FillReturnItems(string itemcode, int nextPageIndex, int nextPageSize)
        {
            try
            {
                pageIndex = nextPageIndex;
                pageSize = nextPageSize;
                gvReturnItemsInfo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
                gvReturnItemsInfo.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                gvReturnItemsInfo.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                DataSet ds = new DataSet();
                if (Login.IsAdmin)
                {
                    ds = DAL.AllReturnItems(itemcode, 1, Login.UserId, pageIndex, nextPageSize);
                }
                else
                {


                    ds = DAL.AllReturnItems(itemcode, 0, Login.UserId, pageIndex, nextPageSize);
                }

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        object value = ds.Tables[0].Rows[0]["NoOfRows"];
                        object firstcellValue = ds.Tables[0].Rows[0]["S no."];
                        object lastcellValue = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["S no."];
                        totalRecords = (int)value;
                        totalPages = (int)Math.Ceiling((float)totalRecords / (float)nextPageSize);
                        lblTotalRecords.Text ="View :"+ firstcellValue + "-" + lastcellValue + " of " + totalRecords.ToString();
                        gvReturnItemsInfo.DataSource = ds.Tables[0];
                        gvReturnItemsInfo.Columns["noofRows"].Visible = false;
                        gvReturnItemsInfo.AutoResizeColumns();
                    }
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

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtInput.Text))
                {
                    string itemcode = txtInput.Text;
                    DataSet ds = new DataSet();
                    if (Login.IsAdmin)
                    {
                        ds = DAL.AllReturnItems(itemcode, 1, Login.UserId, pageIndex, pageSize);
                    }
                    else
                    {
                        ds = DAL.AllReturnItems(itemcode, 0, Login.UserId, pageIndex, pageSize);
                    }
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            gvReturnItemsInfo.DataSource = ds.Tables[0];
                            gvReturnItemsInfo.AutoResizeColumns();
                        }
                        else
                        {
                            gvReturnItemsInfo.DataSource = null;
                        }
                    }

                }
                else
                {
                    FillReturnItems("", pageIndex, pageSize);

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
            FillReturnItems("", 1, 10);

        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (gvReturnItemsInfo != null)
            {
                if (gvReturnItemsInfo.Rows.Count > 0)
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
                for (int i = 0; i < gvReturnItemsInfo.Rows.Count; i++)
                {
                    for (int j = 0; j < gvReturnItemsInfo.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gvReturnItemsInfo.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = gvReturnItemsInfo.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(gvReturnItemsInfo.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = gvReturnItemsInfo.Rows[i].Cells[j].Value.ToString();
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


        private void cmbNoOfRecords_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //  string itemcode = txtInput.Text;
                pageIndex = 1;
                if (cmbNoOfRecords.SelectedIndex > 0)
                {
                    pageSize = Convert.ToInt32(cmbNoOfRecords.SelectedItem);
                }
                FillReturnItems("", pageIndex, pageSize);
                ButtunControlForPaging();

            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int endRow = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
                if (pageIndex < endRow)
                {
                    btnStartPage.Enabled = true;
                    btnPreview.Enabled = true;
                    int nextPage = pageIndex + 1;
                    pageIndex = nextPage;
                    FillReturnItems("", pageIndex, pageSize);
                }
                else
                {
                    btnNext.Enabled = false;
                    btnLastPage.Enabled = false;
                }
                ButtunControlForPaging();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageIndex > 1)
                {
                    int previewPage = pageIndex - 1;
                    pageIndex = previewPage;
                    FillReturnItems("", pageIndex, pageSize);
                    btnNext.Enabled = true;
                    btnLastPage.Enabled = true;
                }
                else
                {
                    btnPreview.Enabled = false;
                    btnStartPage.Enabled = false;
                }
                ButtunControlForPaging();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnStartPage_Click(object sender, EventArgs e)
        {
            try
            {
                int startRow = 1;
                int pageIndex = startRow;
                FillReturnItems("", pageIndex, pageSize);
                ButtunControlForPaging();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            try
            {
                int endRow = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
                int pageIndex = endRow;
                FillReturnItems("", pageIndex, pageSize);
                ButtunControlForPaging();
                btnNext.Enabled = false;
                btnLastPage.Enabled = false;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
