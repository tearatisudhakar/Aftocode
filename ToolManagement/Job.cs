using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolDataAccessLayer;
using ToolBusinessLogiclayer;

namespace ToolManagement
{
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
            BindJob();
            FillGrid(Jobid);
        }

        ToolDAL DAL = new ToolDAL();
        ToolBAL BAL = new ToolBAL();
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
                gvJobdetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11,FontStyle.Regular);
                gvJobdetails.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                gvJobdetails.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                DataTable dt = new DataTable();
                dt = DAL.BindJobInfo(Login.UserId, jobid);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string JobName = string.Empty;
            string JobDesc = string.Empty;
            JobName = txtjobname.Text;
            //if (txtjobname.Text != string.Empty && txtjobname.Text != null)
            if (!string.IsNullOrEmpty(JobName.Trim()))
            {
                JobName = txtjobname.Text;
                JobDesc = txtjobDesc.Text;
                int i = BAL.CreateJob(JobName, JobDesc, Login.UserId);
                if (i == 1)
                {
                    MessageBox.Show("Job creation has been successfully.");
                    txtjobDesc.Text = "";
                    txtjobname.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter Job Name.");
                txtjobname.Focus();
            }
        }

        private void tabJobs_Selected(object sender, TabControlEventArgs e)
        {
            BindJob();
            FillGrid(Jobid);
        }

        private void tabJobs_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabJobs.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabJobs.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                //g.FillRectangle(Brushes.SteelBlue, e.Bounds);
                Color myrgb = new Color();
                myrgb = Color.FromArgb(67, 88, 109);
                SolidBrush sb = new SolidBrush(myrgb);


                g.FillRectangle(sb, _tabBounds);

            }

            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Calibri", (float)14.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

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
                for (int i = 0; i < gvJobdetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < gvJobdetails.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gvJobdetails.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gvJobdetails.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
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
