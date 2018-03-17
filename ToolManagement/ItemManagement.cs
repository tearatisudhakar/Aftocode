using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolManagement.Controls;
using ToolBusinessLogiclayer;
using System.Drawing.Drawing2D;

namespace ToolManagement
{
    public partial class ItemManagement : Form
    {
        ToolBAL BAL = new ToolBAL();
        AddaNewItem frmAddnewItem = new AddaNewItem();
        public ItemManagement()
        {
            InitializeComponent();
            fillItemList();
        }

        public void fillItemList()
        {

            try
            {
                Home frmHome = new Home();
                frmHome.Dock = DockStyle.Fill;
                // frmHome.Size = new System.Drawing.Size(1100, 700);
                frmHome.TopLevel = false;
                frmHome.FormBorderStyle = FormBorderStyle.None;
                pnlItemList.Controls.Clear();
                pnlItemList.Controls.Add(frmHome);
                frmHome.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FillIssueList()
        {
            try
            {
                IssuedDetals frmItem = new IssuedDetals();
                frmItem.Dock = DockStyle.Fill;
                //frmItem.Size = new System.Drawing.Size(1100, 700);
                frmItem.TopLevel = false;
                frmItem.FormBorderStyle = FormBorderStyle.None;
                pnlIssueList.Controls.Clear();
                pnlIssueList.Controls.Add(frmItem);
                frmItem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FillReturnItemHistory()
        {
            try
            {
                ReturnItemHistroy ReturnItemlisthistry = new ReturnItemHistroy();
                ReturnItemlisthistry.Dock = DockStyle.Fill;
                // ReturnItemlist.Size = new System.Drawing.Size(1100, 700);
                ReturnItemlisthistry.TopLevel = false;
                ReturnItemlisthistry.FormBorderStyle = FormBorderStyle.None;
                pnlReturnHistory.Controls.Clear();
                pnlReturnHistory.Controls.Add(ReturnItemlisthistry);
                ReturnItemlisthistry.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FillReturnList()
        {
            try
            {
                ReturnItemList ReturnItemlist = new ReturnItemList();
                ReturnItemlist.Dock = DockStyle.Fill;
                // ReturnItemlist.Size = new System.Drawing.Size(1100, 700);
                ReturnItemlist.TopLevel = false;
                ReturnItemlist.FormBorderStyle = FormBorderStyle.None;
                ReturnItemsPanel.Controls.Clear();
                ReturnItemsPanel.Controls.Add(ReturnItemlist);
                ReturnItemlist.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void FillRemoveItem()
        {
            try
            {
                DeletedItemdetails frmdeleteditemdtls = new DeletedItemdetails();
                frmdeleteditemdtls.Dock = DockStyle.Fill;
                //frmdeleteditemdtls.Size = new System.Drawing.Size(1100, 700);

                frmdeleteditemdtls.TopLevel = false;
                frmdeleteditemdtls.FormBorderStyle = FormBorderStyle.None;
                pnlRemoveItem.Controls.Clear();
                pnlRemoveItem.Controls.Add(frmdeleteditemdtls);
                frmdeleteditemdtls.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FillAddItem()
        {
            try
            {
                //AddaNewItem frmAddnewItem = new AddaNewItem();
                if (frmAddnewItem != null)
                {
                    frmAddnewItem.Dock = DockStyle.Fill;
                    //frmAddnewItem.Size = new System.Drawing.Size(1055, 655);
                    frmAddnewItem.TopLevel = false;
                    frmAddnewItem.FormBorderStyle = FormBorderStyle.None;
                    pnlAddItem.Controls.Clear();
                    pnlAddItem.Controls.Add(frmAddnewItem);
                    frmAddnewItem.Visible = true;

                }
                else
                {
                    frmAddnewItem = new AddaNewItem();
                    frmAddnewItem.Dock = DockStyle.Fill;
                    //frmAddnewItem.Size = new System.Drawing.Size(1055,655);
                    frmAddnewItem.TopLevel = false;
                    frmAddnewItem.FormBorderStyle = FormBorderStyle.None;
                    pnlAddItem.Controls.Clear();
                    pnlAddItem.Controls.Add(frmAddnewItem);
                    frmAddnewItem.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void tabItem_Selected(object sender, TabControlEventArgs e)
        {
            try
            {

                if (e.TabPage.Name == tbItemList.Name)
                {
                    fillItemList();
                }

                else if (e.TabPage.Name == tbIssueList.Name)
                {
                    FillIssueList();
                }

                else if (e.TabPage.Name == tbAddItem.Name)
                {
                    FillAddItem();
                }

                else if (e.TabPage.Name == tbReturnItem.Name)
                {
                    FillReturnList();
                }

                else if (e.TabPage.Name == tbRemoveItem.Name)
                {
                    FillRemoveItem();
                }
                else if (e.TabPage.Name == tbExcelItemInfo.Name)
                {
                    FillExcelList();
                }
                else if (e.TabPage.Name ==tabReturnItemHistory.Name)
                {
                    FillReturnItemHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void FillExcelList()
        {
            try
            {
                ImportDataFromExcel frmAddItemFromExcel = new ImportDataFromExcel();
                // AddaNewItem frmAddnewItem = new AddaNewItem();
                frmAddItemFromExcel.Dock = DockStyle.Fill;
                frmAddItemFromExcel.TopLevel = false;
                frmAddItemFromExcel.FormBorderStyle = FormBorderStyle.None;
                pnlAddItemFromExcel.Controls.Add(frmAddItemFromExcel);
                frmAddItemFromExcel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabItem_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabItem.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabItem.GetTabRect(e.Index);
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
