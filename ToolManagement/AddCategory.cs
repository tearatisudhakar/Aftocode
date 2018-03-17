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

public delegate void BindCategory(string categoryname);
namespace ToolTracker
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        string itemcode = string.Empty;
        string itemtype = string.Empty;
        ToolBAL objBAL = new ToolBAL();
        public BindCategory CallbackCategoryName;


        //////////ghhjjnjnknknnnnjnjnjnjnjnjnjn
        //Shashi machine
        //dfsdfsdfdsaddfsdfsddfsdf
        /// <summary>
        /// 
        /// 
        /// /fsdfsfdsdfdsff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool Checkresult = false;
                string ItemCategory = txtItemCategory.Text.Trim();
                if (ItemCategory != string.Empty)
                {
                    Checkresult = objBAL.CheckDataHavingOrNot("ItemCategory", ItemCategory);
                    if (!Checkresult)
                    {
                        CallbackCategoryName(txtItemCategory.Text);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Already have this Category");
                        txtItemCategory.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Item Category.");
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