using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;

public delegate void BindIssueJob();

namespace ToolManagement
{
    public partial class JobCreation : Form
    {
        public JobCreation()
        {
            InitializeComponent();
        }
        ToolBAL BAL = new ToolBAL();
        public BindIssueJob CallBackJob;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string JobName = string.Empty;
            string JobDesc = string.Empty;
            JobName = txtjobname.Text;
            //if (txtjobname.Text != string.Empty && txtjobname.Text != null)
            if(!string.IsNullOrEmpty(JobName.Trim()))
            {
                JobName = txtjobname.Text;
                JobDesc = txtjobDesc.Text;
               int i= BAL.CreateJob(JobName,JobDesc,Login.UserId);
               if (i == 1)
               {
                   MessageBox.Show("Job creation has been successfully.");
                   CallBackJob();
                   this.Hide();
               }
            }
            else
            {
                MessageBox.Show("Please enter Job Name.");
                txtjobname.Focus();
            }
        }
    }
}
