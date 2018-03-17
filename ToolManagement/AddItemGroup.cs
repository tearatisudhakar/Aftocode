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

public delegate void BindGroupDeligate(int ItemCategoryId, string ItemNewGroup);
namespace ToolTracker
{
    public partial class AddItemGroup : Form
    {
        public AddItemGroup()
        {
            InitializeComponent();
            BindCategory();
        }
        public BindGroupDeligate CallBackGroupDeligate;
        int  ItemCategoryId =0;
        string ItemNewGroup = string.Empty;
        ToolBAL objcontroler = new ToolBAL();
        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
               ItemCategoryId =Convert.ToInt32(cmbCategory.SelectedValue);
                ItemNewGroup = txtItemGroup.Text.Trim();
                bool Checkresult = false;
                if (ItemCategoryId != 0)
                {
                    if (!string.IsNullOrEmpty(ItemNewGroup))
                    {
                        Checkresult = objcontroler.CheckDataHavingOrNot("ItemGroup", ItemNewGroup);
                        if (!Checkresult)
                        {
                            CallBackGroupDeligate(ItemCategoryId, ItemNewGroup);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Already have this Group");
                            txtItemGroup.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Group.");
                        txtItemGroup.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Category.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindCategory()
        {
            try
            {
                    DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindCategory();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Category--" };
                dt.Rows.InsertAt(dr, 0);
                cmbCategory.ValueMember = "ItemCategoryId";
                cmbCategory.DisplayMember = "ItemCategory";
                cmbCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

    }
}
