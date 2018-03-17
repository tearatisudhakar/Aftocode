using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ToolDataAccessLayer;

public delegate void BindReturnItemsGrid();

namespace ToolManagement
{
    public partial class ReturnItem : Form
    {
        int AvailableQnty = 0;
        public ReturnItem(string Itemcode, int Qnt)
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            txtUserid.Text = Convert.ToString(Login.UserId);
            txtUsername.Text = Login.Username;
            FillItemissue(Itemcode);
            AvailableQnty = Qnt;
            BindJob();
        }
        ToolDAL DAL = new ToolDAL();
        string strCategory = string.Empty;
        string strGroup = string.Empty;
        string strItemtype = string.Empty;
        string strDescription = string.Empty;
        string strItemcode = string.Empty;
        int itemId = 0;
        public BindReturnItemsGrid CallBackItemGrid;

        public void FillItemissue(string Itemcode)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = DAL.ItemInfo(Itemcode);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    strCategory = ds.Tables[0].Rows[0]["Item Category"].ToString();
                    strGroup = ds.Tables[0].Rows[0]["Item Group"].ToString();
                    strItemtype = ds.Tables[0].Rows[0]["Item Type"].ToString();
                    strItemcode = ds.Tables[0].Rows[0]["Item Code"].ToString();
                    strDescription = ds.Tables[0].Rows[0]["Item Description"].ToString();
                    itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["Item id"].ToString());
                    txtIndex.Text = strGroup + " , " + strCategory;
                    txtdesc.Text = strDescription;
                    txtItemcode.Text = strItemcode;
                    txtLocation.Text = ds.Tables[0].Rows[0]["Location"].ToString();
                }
                if (ds != null && ds.Tables.Count > 1)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
                        if (File.Exists(absolutePath))
                        {
                            picBxforIssue.Image = System.Drawing.Image.FromFile(absolutePath);
                        }
                        else
                        {
                            picBxforIssue.Image = null;
                        }
                    }
                }
                else
                {
                    picBxforIssue.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ItemType = string.Empty;
                if (cmbjob.SelectedIndex != 0)
                {
                    int Jobid = Convert.ToInt32(cmbjob.SelectedValue);
                    if (AvailableQnty >= numericUpDown1.Value)
                    {

                        if (numericUpDown1.Value > 0)
                        {
                            if (rdbUsed.Checked || rdbUnused.Checked)
                            {
                                if (rdbUsed.Checked)
                                {
                                    ItemType = "Used";
                                }
                                else
                                {
                                    ItemType = "UnUsed";
                                }
                                int intReturn = 0;
                                if (MessageBox.Show("Are you sure " + strItemcode + " item return as " + ItemType + " item ?", "Confirm return", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    intReturn = Convert.ToInt32(numericUpDown1.Value);
                                    DAL.ItemReturn(intReturn, Login.UserId, itemId, ItemType, Jobid);
                                    MessageBox.Show("Item returned successfully.");
                                    CallBackItemGrid();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select Item Type.");
                                rdbUsed.Focus();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select Quantity.");
                            numericUpDown1.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The quantity specified is more than " + AvailableQnty + ", ", "QUANTITY INVALID");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select Job.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void BindJob()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = DAL.BindJob(Login.UserId);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Job--" };
                dt.Rows.InsertAt(dr, 0);
                cmbjob.ValueMember = "JobId";
                cmbjob.DisplayMember = "JobName";
                cmbjob.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}