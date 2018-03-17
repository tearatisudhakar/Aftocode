using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTracker
{
    public partial class AddItemType : Form
    {
        public AddItemType()
        {
            InitializeComponent();
        }
        string itemcode = string.Empty;
        string itemtype = string.Empty;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemcode = txtItemCode.Text;
            itemtype = txtItemType.Text;
            if (itemtype!=string.Empty)
            {
               //InsertMethod
                
            }
            else
            {
                MessageBox.Show("Please Enter ItemType.");
            }
        }

    }
}
