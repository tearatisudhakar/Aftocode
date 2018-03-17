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


namespace ToolManagement
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }
        ToolBAL objBAL = new ToolBAL();
        public BindCategory CallbackDepartment;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool Checkresult = false;
                string depart = txtDepartment.Text.Trim();
                if (depart != string.Empty)
                {
                    Checkresult = objBAL.CheckDepartment(depart);
                    if (!Checkresult)
                    {
                        CallbackDepartment(depart);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Already have this Department Name");
                        txtDepartment.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Department Name.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text);
                    return ;
            }
        }
    }
}
