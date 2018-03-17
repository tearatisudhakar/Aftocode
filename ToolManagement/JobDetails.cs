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
    public partial class JobDetails : Form
    {
        public JobDetails()
        {
            InitializeComponent();
            BindJob();
            FillGrid(Jobid);
        }
        ToolDAL DAL = new ToolDAL();
        int Jobid = 0;
        public void BindJob()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = DAL.BindJob(Login.UserId);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Job--" };
                dt.Rows.InsertAt(dr, 0);
                cmbjob.ValueMember = "JobId";
                cmbjob.DisplayMember = "JobName";
                cmbjob.DataSource = dt;
                //Jobid =Convert.ToInt32(cmbjob.ValueMember);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void FillGrid(int jobid)
        {
            try
            {
                
                DataTable dt = new DataTable();
                dt = DAL.BindJobInfo(Login.UserId,jobid);
                gvJobdetails.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbjob_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jobid = Convert.ToInt32(cmbjob.SelectedValue);
            FillGrid(Jobid);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (gvJobdetails != null)
            {
                if (gvJobdetails.Rows.Count > 0)
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
                for (int i = 0; i < gvJobdetails.Rows.Count ; i++)
                {
                    for (int j = 0; j < gvJobdetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gvJobdetails.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = gvJobdetails.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                             if (!string.IsNullOrEmpty(gvJobdetails.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = gvJobdetails.Rows[i].Cells[j].Value.ToString();
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
