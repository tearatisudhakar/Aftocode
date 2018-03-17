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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
           // FillGrid("");
        }
        ToolDAL DAL = new ToolDAL();
        private void tsmiTransaction_Click(object sender, EventArgs e)
        {
            //pnlInventory.Controls.Clear();
            //TransactionItemDetails frmTransaction = new TransactionItemDetails();
            //frmTransaction.Dock = DockStyle.Fill;
            //frmTransaction.TopLevel = false;
            //frmTransaction.FormBorderStyle = FormBorderStyle.None;

            //pnlInventory.Controls.Add(frmTransaction);
            //frmTransaction.Visible = true;
        }
        //public void FillGrid(string itemcode)
        //{
        //    try
        //    {

        //        gvCurrentstock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
        //        gvCurrentstock.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
        //        gvCurrentstock.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
        //        DataSet ds = new DataSet();
        //        ds = DAL.AllItemStatus(itemcode);
        //        if (ds.Tables.Count > 0)
        //        {
        //            if (ds.Tables[0].Rows.Count > 0)
        //            {
        //                gvCurrentstock.DataSource = ds.Tables[0];
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        public void FillReturnItems(string itemcode)
        {
            try
            {
                gvReturnItemsInfo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
                gvReturnItemsInfo.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                gvReturnItemsInfo.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                DataSet ds = new DataSet();
                if (Login.IsAdmin)
                {
                  //  ds = DAL.AllReturnItems(itemcode,1,Login.UserId);
                }
                else
                {
                  //  ds = DAL.AllReturnItems(itemcode,0,Login.UserId);
                }
                
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        gvReturnItemsInfo.DataSource = ds.Tables[0];
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string itemcode = txtInput.Text;
        //        if (itemcode != string.Empty)
        //        {
        //            FillGrid(itemcode);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter item code.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //       // txtInput.Text = "";
        //        FillGrid("");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}


        //private void txtInput_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string itemcode = txtInput.Text;
        //        if (itemcode != string.Empty)
        //        {
        //            FillGrid(itemcode);
        //        }
        //        else
        //        {
        //            FillGrid("");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
           
        //}

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                //if (e.TabPage.Name == tbcurrentstock.Name)
                //{
                //    FillGrid("");
                //}
                //else 
                    if (e.TabPage.Name == tbReturnitem.Name)
                {
                    FillReturnItems("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
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
    }
}
