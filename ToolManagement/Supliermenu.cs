using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ToolManagement.Controls;
using ToolDataAccessLayer;
using TooLManagementEntities;

namespace ToolManagement
{
    public partial class Supliermenu : Form
    {
        public Supliermenu()
        {
            InitializeComponent();
            FillSuplier();
        }
        ToolDAL DAL = new ToolDAL();
        DataSet ds = null;
        int Supplierid = 0;
        string SupplierName = string.Empty;
        int intSelectedRowId = 0;
        public void FillSuplier()
        {
            GvSuplier.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            GvSuplier.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            GvSuplier.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            //this.GvSuplier.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            //this.GvSuplier.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            try
            {
                ds = new DataSet();
                ds = DAL.SuplierInfo();
                
                if (ds.Tables[0].Rows.Count>0)
                {
                    GvSuplier.DataSource = ds.Tables[0];
                    GvSuplier.Columns["SupplierId"].Visible = false;
                    GvSuplier.AutoResizeColumns();
                    if (GvSuplier.Rows.Count >= intSelectedRowId)
                    {
                        GvSuplier.CurrentCell = GvSuplier[2, intSelectedRowId];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void tabSupplier_Selected(object sender, TabControlEventArgs e)
        {
            FillSuplier();
        }


        private void GvSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Supplierid = 0;
                bool IsDelete = false;
                if (e.RowIndex > -1)
                {
                    Supplierid = Convert.ToInt32(GvSuplier.Rows[e.RowIndex].Cells["SupplierId"].Value);
                    SupplierName = GvSuplier.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString();
                    if (e.ColumnIndex == 0)
                    {
                        if (MessageBox.Show("Are you sure to delete supplier " + GvSuplier.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString() + " ?", "Delete supplier", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            if (int.TryParse(GvSuplier.Rows[e.RowIndex].Cells["SupplierId"].Value.ToString(), out Supplierid))
                            {
                                IsDelete = DAL.DeleteSupplier(Supplierid, Login.UserId);
                                if (IsDelete)
                                {
                                    MessageBox.Show(GvSuplier.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString() + " Supplier deleted succussfully.");
                                    FillSuplier();
                                }
                            }
                        }
                        else
                        {
                            return;
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
    
        private void GvSuplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DAL.GetSupplierDetails(Supplierid);
                intSelectedRowId = e.RowIndex;
                if (dt.Rows.Count > 0)
                {
                    Supliers objsuppli = new Supliers(dt, Supplierid);
                    objsuppli.CallbackFunctn = new global::BindSupplierDetailsDeligate(this.FillSuplier);
                    objsuppli.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsDelete = false;
            if (Supplierid>0)
            {
                if (MessageBox.Show("Are you sure to delete supplier " + SupplierName + " ?", "Delete supplier", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IsDelete = DAL.DeleteSupplier(Supplierid, Login.UserId);
                    if (IsDelete)
                    {
                        MessageBox.Show(SupplierName + " Supplier deleted succussfully.");
                        FillSuplier();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select the supplier.");
                return;
            }
        }

        private void tabSupplier_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabSupplier.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabSupplier.GetTabRect(e.Index);
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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string Companycode = txtInput.Text;
                    DataTable dt = new DataTable();
                    dt = DAL.BindSupplierList(Companycode);
                    if (dt.Rows.Count > 0)
                    {
                        GvSuplier.DataSource = dt;
                        GvSuplier.AutoResizeColumns();
                    }
                    else
                    {
                        GvSuplier.DataSource = null;
                    }
                }
                else
                {
                    FillSuplier();
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
            FillSuplier();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (GvSuplier != null)
            {
                if (GvSuplier.Rows.Count > 0)
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
                for (int i = 0; i < GvSuplier.Rows.Count; i++)
                {
                    for (int j = 0; j < GvSuplier.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GvSuplier.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = GvSuplier.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = GvSuplier.Rows[i].Cells[j].Value.ToString();
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

     
    

