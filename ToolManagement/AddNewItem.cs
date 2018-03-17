using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;
using ToolManagement;
public delegate void BindNewItemDeligate(int ItemSelectedGroup, string ItemType);
namespace ToolTracker
{
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
            BindItemGroup();

        }

        ToolBAL objcontroler = new ToolBAL();
        int itemGroupId = 0;
        string itemtype = string.Empty;
        
        public BindNewItemDeligate CallBackItemDeligate;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool Checkresult = false;
                itemGroupId = Convert.ToInt32(cmbItemGroup.SelectedValue);
                itemtype = txtItemType.Text;
                if (!string.IsNullOrEmpty(itemtype ))
                {
                    Checkresult = objcontroler.CheckDataHavingOrNot("ItemType", itemtype);
                    if (!Checkresult)
                    {
                        CallBackItemDeligate(itemGroupId, itemtype);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Already have this item type");
                        txtItemType.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter ItemType.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindItemGroup()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindItemGroup(0);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Group--" };
                dt.Rows.InsertAt(dr, 0);
                cmbItemGroup.ValueMember = "ItemGroupId";
                cmbItemGroup.DisplayMember = "ItemGroup";
                cmbItemGroup.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            BindItemGroup();
        }

    }
}
