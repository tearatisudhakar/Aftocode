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
    public partial class ReportsMenu : Form
    {
        public ReportsMenu()
        {
            InitializeComponent();
            BindDrawer();
            BindIssuedItemsReport(); 
        }
        ToolDAL DAL = new ToolDAL();
        ToolBAL objcontroler = new ToolBAL();
        int DrawerId = 0;
        private void tabitem_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabReports.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabReports.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                //g.FillRectangle(Brushes.DarkGray, e.Bounds);
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
        public void BindIssuedItemsReport()
        {
            GvOperatorBy.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            GvOperatorBy.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            GvOperatorBy.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);

            try
            {
                DataTable dt = new DataTable();
                if (Login.IsAdmin)
                {
                    dt = DAL.BindIssuedItemsReport("", "",1,Login.UserId);    
                }
                else
                {
                    dt = DAL.BindIssuedItemsReport("", "",0,Login.UserId);
                }
                

                if (dt.Rows.Count > 0)
                {
                    GvOperatorBy.DataSource = dt;
                    GvOperatorBy.AutoResizeColumns();
                }
                else
                {
                    GvOperatorBy.DataSource = null;
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
                DataTable dt = new DataTable();
                string strFromDate = string.Empty;
                string strTo = string.Empty;
                strFromDate = dtpFrom.Value.ToString("dd-MM-yyyy");
                strTo = dtpTo.Value.ToString("dd-MM-yyyy");
                if (Login.IsAdmin)
                {
                    dt = DAL.BindIssuedItemsReport(strFromDate, strTo,1,Login.UserId);    
                }
                else
                {
                    dt = DAL.BindIssuedItemsReport(strFromDate, strTo, 0, Login.UserId);    
                }
                if (dt.Rows.Count > 0)
                {
                    GvOperatorBy.DataSource = dt;
                    GvOperatorBy.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("No Issued items", "Issued Items");
                    GvOperatorBy.DataSource = null;
                    return;
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
            if (GvOperatorBy!=null)
            {
                if (GvOperatorBy.Rows.Count>0)
                {
                    ExportToExcel(GvOperatorBy);
                }
            }
        }
        private void BindCurrentSock()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = DAL.BindCurrentStock("");
                if (ds != null && ds.Tables.Count > 1)
                {
                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        gvCurrentStock.DataSource = ds.Tables[0];
                        gvCurrentStock.AutoResizeColumns();
                        crtCurrentstock.Series[0].Points.Clear();
                        crtCurrentstock.DataSource = ds.Tables[0];
                        crtCurrentstock.Series["Currentstock"].XValueMember = "Item code";
                        crtCurrentstock.Series["Currentstock"].YValueMembers = "Available";
                    }
                    if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
                    {

                        crtCurrentTotal.Series[0].Points.Clear();
                        crtCurrentTotal.DataSource = ds.Tables[1];
                        crtCurrentTotal.Series["Totalstock"].XValueMember = "Task";
                        crtCurrentTotal.Series["Totalstock"].YValueMembers = "Total";
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BindShortageReport()
        { 
            try
            {
                DataTable dt = new DataTable();
                dt = DAL.BindShortageReport("");

                if (dt.Rows.Count > 0)
                {
                    gvShortageItems.DataSource = dt;
                    gvShortageItems.AutoResizeColumns();
                    crtStockShortage.Series[0].Points.Clear();
                    crtStockShortage.Series[1].Points.Clear();
                    crtStockShortage.DataSource = dt;
                    crtStockShortage.Series["Moq"].XValueMember = "Item code";
                    crtStockShortage.Series["Moq"].YValueMembers = "MOQ";
                    crtStockShortage.Series["Available"].YValueMembers = "Available";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtShortageInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtShortageInput.Text))
                {
                    DataTable dt = new DataTable();
                    dt = DAL.BindShortageReport(txtShortageInput.Text);

                    if (dt.Rows.Count > 0)
                    {
                        gvShortageItems.DataSource = dt;
                        gvShortageItems.AutoResizeColumns();

                        crtStockShortage.Series[0].Points.Clear();
                        crtStockShortage.Series[1].Points.Clear();
                        crtStockShortage.DataSource = dt;
                        crtStockShortage.Series["Moq"].XValueMember = "Item code";
                        crtStockShortage.Series["Moq"].YValueMembers = "MOQ";
                        crtStockShortage.Series["Available"].YValueMembers = "Available";
                    }
                    else
                    {
                        gvShortageItems.DataSource = null;
                        crtStockShortage.Series[0].Points.Clear();
                        crtStockShortage.Series[1].Points.Clear();
                    }
                }
                else
                {
                    BindShortageReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnShortageSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtShortageInput.Text))
                {
                    DataTable dt = new DataTable();
                    dt = DAL.BindShortageReport(txtShortageInput.Text);

                    if (dt.Rows.Count > 0)
                    {
                        gvShortageItems.DataSource = dt;
                        gvShortageItems.AutoResizeColumns();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter item code.", this.Text);
                    return;
                }
            }
            catch (Exception ex)
            {                
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnShortageExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvShortageItems != null)
                {
                    if (gvShortageItems.Rows.Count > 0)
                    {
                        ExportToExcel(gvShortageItems);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCurrentStockInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCurrentStockInput.Text))
                {
                    DataSet ds = new DataSet();
                    ds = DAL.BindCurrentStock(txtCurrentStockInput.Text);
                    if (ds != null && ds.Tables.Count > 1)
                    {
                        if (ds.Tables[1]!=null&&ds.Tables[1].Rows.Count>0)
                        {
                         
                            //crtSummary.Series["Currentstock"].XValueMember = "Item code";
                            //crtCurrentstock.Series["Currentstock"].YValueMembers = "Available";
                        }
                        if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                        {
                            gvCurrentStock.DataSource = ds.Tables[0];
                            gvCurrentStock.AutoResizeColumns();
                            crtCurrentstock.Series[0].Points.Clear();
                            crtCurrentstock.DataSource = ds.Tables[0];
                            crtCurrentstock.Series["Issue"].XValueMember = "Item code";
                            crtCurrentstock.Series["Currentstock"].YValueMembers = "Available";
                        }
                        else
                        {
                            gvCurrentStock.DataSource = null;
                            crtCurrentstock.Series[0].Points.Clear();
                        }
                    }
                }
                else
                {
                    BindCurrentSock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnCurrentStockSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCurrentStockInput.Text))
                {
                    DataSet ds = new DataSet();
                    ds = DAL.BindCurrentStock(txtCurrentStockInput.Text);

                    if (ds.Tables[0]!=null&&ds.Tables[0].Rows.Count > 0)
                    {
                        gvCurrentStock.DataSource = ds.Tables[0];
                        gvCurrentStock.AutoResizeColumns();
                    }
                    else
                    {
                        gvCurrentStock = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter item code.", this.Text);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnCurrentstockExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvCurrentStock != null)
                {
                    if (gvCurrentStock.Rows.Count > 0)
                    {
                        ExportToExcel(gvCurrentStock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ExportToExcel(DataGridView gv)
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
                for (int i = 0; i < gv.Rows.Count; i++)
                {
                    for (int j = 0; j < gv.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gv.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = gv.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(gv.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = gv.Rows[i].Cells[j].Value.ToString();
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
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

        private void BindDrawer()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindDrawer();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Drawer--" };
                dt.Rows.InsertAt(dr, 0);
                cmbDrawer.ValueMember = "DrawerId";
                cmbDrawer.DisplayMember = "DrawerCode";
                cmbDrawer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void cmbDrawer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbDrawer.SelectedIndex != 0)
                {
                    DrawerId = Convert.ToInt32(cmbDrawer.SelectedValue);
                    BindLocatioin(DrawerId);
                    BindSockReportbyBin("", DrawerId);
                }
                else
                {
                    BindSockReportbyBin("", 0);
                    cmbLocation.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        private void BindLocatioin(int DrawerId)
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindLocation(DrawerId);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Bin--" };
                dt.Rows.InsertAt(dr, 0);
                cmbLocation.ValueMember = "Code";
                cmbLocation.DisplayMember = "BinCode";
                cmbLocation.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BindSockReportbyBin( string BinCode,int DrawerId)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DAL.BindSockReportbyBin(BinCode,DrawerId);

                if (dt.Rows.Count > 0)
                {
                    gvStockbyBin.DataSource = dt;
                    gvStockbyBin.AutoResizeColumns();
                    crtStockbyBin.Series[0].Points.Clear();
                    if (dt.Columns.Count>1)
                    {
                        crtStockbyBin.DataSource = dt;
                        crtStockbyBin.Series["BinStock"].XValueMember = "Bin";
                        crtStockbyBin.Series["BinStock"].YValueMembers = "Quantity";
                    }                    
                    
                }
                else
                {
                    gvStockbyBin.DataSource = null;
                    crtStockbyBin.Series[0].Points.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLocation.SelectedIndex != 0)
                {
                    string BinCode = string.Empty;
                    BinCode = cmbLocation.SelectedValue.ToString();
                    if (!string.IsNullOrEmpty(BinCode))
                    {
                        BindSockReportbyBin(BinCode, DrawerId);
                    }
                }
                else
                {
                    BindSockReportbyBin("", DrawerId);
                }

            }
            catch (ArgumentException arg)
            {
                MessageBox.Show(arg.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnStockbyBinExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvStockbyBin != null)
                {
                    if (gvStockbyBin.Rows.Count > 0)
                    {
                        ExportToExcel(gvStockbyBin);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabReports_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.TabPage.Name == tbReportbydate.Name)
                {                    
                    BindCurrentSock();
                }
                else if (e.TabPage.Name == tbItemReports.Name)
                {
                    BindIssuedItemsReport();
                }
                else if (e.TabPage.Name ==tbShortageReport.Name)
                {
                    BindShortageReport();
                }
                else if (e.TabPage.Name == tbStockbyBin.Name)
                {                   
                    cmbDrawer.SelectedIndex = 0;
                    BindSockReportbyBin("",0);
                }
                else if (e.TabPage.Name == tbShortageReport.Name)
                {
                    BindShortageReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
