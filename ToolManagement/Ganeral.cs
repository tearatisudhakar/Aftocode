using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolDataAccessLayer;
using TooLManagementEntities;
using ToolBusinessLogiclayer;
using System.IO.Ports;
using System.Net.Mail;
using System.Data.SqlClient;

namespace ToolManagement
{
    public partial class Ganeral : Form
    {
        public Ganeral()
        {
            InitializeComponent();
            DisableControl();
            BindDepartment();
            BindUsers();
            btnSave.Visible = true;
            btnuserUpdate.Visible = false;
            
        }
        ToolBAL objBAL = new ToolBAL();
        ToolDAL DAL = new ToolDAL();
        UserAccountBo objUserAccount = new UserAccountBo();
        DataSet ds = null;
        bool successvalue = true;
        int UserID = 0;
        int intSelectedRowId = 0;
        private void tbUserPrivilage_Click(object sender, EventArgs e)
        {

        }
        private void BindUsers()
        {
            try
            {
                gvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
                gvUsers.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                gvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
                ds = objBAL.BindUsers(0);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    gvUsers.DataSource = ds.Tables[0];
                    gvUsers.Columns["userID"].Visible = false;
                    gvUsers.CurrentCell = gvUsers[2, intSelectedRowId];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void BindDepartment()
        {
            try
            {
                DataRow dr;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
              dt=DAL.BindDepartment();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Department--" };
                dt.Rows.InsertAt(dr, 0);
                cmbDepartment.ValueMember = "DepartmentId";
                cmbDepartment.DisplayMember = "DdepartmentName";
                cmbDepartment.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void DisableControl()
        {
            try
            {
                //chkInputData.Visible = false;
                //chkBackupdata.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

      //  FingerPrintlogin fingerprintobj = new FingerPrintlogin();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
        //        SerialPort objPort1 = new SerialPort();
                successvalue = true;
                Validations();
                if (successvalue)
                {
                    DataSet ds22=new DataSet();
                    ds22 =objBAL.BindUsers(Login.UserId);
                    string unitoperator=string.Empty ;
                    if (ds22 != null && ds22.Tables.Count > 1)
                    {
                        if (ds22.Tables[0].Rows.Count > 0)
                        {
                            unitoperator = ds22.Tables[0].Rows[0]["Is Admin"].ToString();
                        }
                    }

                   DataSet   ds1 = objBAL.CheckUser(objUserAccount.UserName, objUserAccount.Password, 0);
                   if (ds1.Tables.Count > 1)
                   {
                       if (ds1.Tables[0].Rows.Count == 1)
                       {
                           MessageBox.Show("User already exist,please use anothe name to register", this.Text);
                           return;
                       }
                   }                                               
                                                 
                    int i = objBAL.InsertUserAccountDetails(objUserAccount);
                    if (i > 0)
                    {
                        MessageBox.Show("User has been created successfully.");
                    }
                    BindUsers();
                    Clear();  
                  //  int value = fingerprintobj.ReeadIDresponse(out objPort1, i);
                    //if (value == 2)
                    //{
                    //    if (MessageBox.Show("Please remove index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //    {
                    //        int value1 = fingerprintobj.ReeadIDresponse2(objPort1);
                    //        if (value1 == 3)
                    //        {
                    //            if (MessageBox.Show("Please place user index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //            {
                    //                int value2 = fingerprintobj.ReeadIDresponse2(objPort1);
                    //                if (value2 == 4)
                    //                {
                    //                    if (MessageBox.Show("Please place remove index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //                    {
                    //                        int value3 = fingerprintobj.ReeadIDresponse2(objPort1);
                    //                        if (value3 == 5)
                    //                        {
                    //                            MessageBox.Show("Your fingerprint has been configured successfully");                                            
                    //                            return;
                    //                        }
                    //                        if (value3 == 6)
                    //                        {
                    //                            MessageBox.Show("Your fingerprint has been failed to configured , please try again");                                                
                    //                            return;
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }

        private void btnuserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                successvalue = true;
                Validations();
                if (successvalue)
                {
                    int i = objBAL.UpdateUserAccountDetails(objUserAccount, UserID);
                    if (i > 0)
                    {
                        MessageBox.Show("User has been updated successfully.");
                          BindUsers();
                          Clear();  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();     
        
        }

        private void Clear()
        {
            btnSave.Visible = true;
            btnuserUpdate.Visible = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtCompany.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
            txtJobTittle.Text = "";
            cmbDepartment.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtNotes.Text = "";
            txtEmail.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtNotes.Text = "";
            txtEmail.Text = "";
            txtConfirmPassword.Text = "";
            cmbDepartment.SelectedIndex = 0;
            errorProvider1.Clear();

            chkLevel1.Checked = false;
            chkLevel2.Checked = false;
            chkLevel3.Checked = false;

            //chkGeneral.Checked = false;
            //chkManagement.Checked = false;
            //chkJobs.Checked = false;
            //chkReports.Checked = false;
            //chkSupplier.Checked = false;
            //chkConfiguration.Checked = false;
            //chkHelp.Checked = false;
        }
        private void Cboxusertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cboxusertype.SelectedIndex != -1)
            {
                if (Cboxusertype.SelectedIndex == 0)
                {
                    objUserAccount.IsAdmin = true;

                    chkLevel1.Checked = true;
                    chkLevel2.Checked = true;
                    chkLevel3.Checked = true;

                    chkLevel1.Enabled = false;
                    chkLevel2.Enabled = false;
                    chkLevel3.Enabled = false;


                  /*  chkGeneral.Checked = true;
                    chkManagement.Checked = true;
                    chkJobs.Checked = true;
                    chkReports.Checked = true;
                    chkSupplier.Checked = true;
                    chkConfiguration.Checked = true;
                    chkHelp.Checked = true;*/


                    checkBox7.Checked = true;
                    checkBox7.Enabled = false;

                    checkBox7.Enabled = false;
                    checkBox4.Checked = true;

                    checkBox5.Enabled = false;
                    checkBox5.Checked = true;

                    checkBox4.Enabled = false;
                    checkBox4.Checked = true;

                    checkBox6.Enabled = false;
                    checkBox6.Checked = true;

                    checkBox3.Enabled = false;
                    checkBox3.Checked = true;

                    checkBox1.Enabled = false;
                    checkBox1.Checked = true;
                 
                }
                else
                {
                    objUserAccount.IsAdmin = false;
                    chkLevel1.Checked = false;
                    chkLevel2.Checked = false;
                    chkLevel3.Checked = false;

                    chkLevel1.Enabled = true;
                    chkLevel2.Enabled = true;
                    chkLevel3.Enabled = true;

                  /*  chkGeneral.Checked = false;
                    chkManagement.Checked = false;
                    chkJobs.Checked = false;
                    chkReports.Checked = false;
                    chkSupplier.Checked = false;
                    chkConfiguration.Checked = false;
                    chkHelp.Checked = false;*/


                    checkBox7.Checked = false;
                    checkBox7.Enabled = false;

                    checkBox4.Enabled = true;
                    checkBox4.Checked = true;

                    checkBox5.Enabled = true;
                    checkBox5.Checked = true;

                    checkBox6.Enabled = true;
                    checkBox6.Checked = true;

                    checkBox3.Enabled = false;
                    checkBox3.Checked = false;

                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;



                }
            }
        }
        public int CheckRegisterUser(string email)
        {

            int i = objBAL.CheckRegisteredEmail(email);
            return i;
        }
        public void Validations()
        {
            try
            {
                errorProvider1.Clear();
                string strAccesslevel = null;
                if (txtFirstName.Text != string.Empty)
                {
                    objUserAccount.FirstName = txtFirstName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtFirstName, "First Name is required.");
                    successvalue = false;
                }
                if (txtLastName.Text != string.Empty)
                {
                    objUserAccount.LastName = txtLastName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtLastName, "Last Name is required.");
                    successvalue = false;
                }

                if (txtEmail.Text != string.Empty)
                {
                    int validUser = CheckRegisterUser(txtEmail.Text);
                    if (validUser == 0)
                    {

                        objUserAccount.Email = txtEmail.Text;
                    }
                    else
                    {

                        errorProvider1.SetError(this.txtEmail, "Email ID alredy exits.");
                        successvalue = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(this.txtEmail, "Email ID is required.");
                    successvalue = false;
                }

                if (txtPassword.Text != string.Empty)
                {
                    objUserAccount.Password = txtPassword.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtPassword, "Password is required.");
                    successvalue = false;
                }

                if (txtConfirmPassword.Text != string.Empty)
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        errorProvider1.SetError(this.txtConfirmPassword, "Password and Confirm Password did not match.");
                        successvalue = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(this.txtConfirmPassword, "Confirm Password is required.");
                    successvalue = false;
                }

                if (txtUserName.Text != string.Empty)
                {
                    objUserAccount.UserName = txtUserName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtUserName, "User Name is required.");
                    successvalue = false;
                }
             /*   if (chkGeneral.Checked)
                {
                    objUserAccount.AllowGeneral = true;
                }
                if (chkManagement.Checked)
                {
                    objUserAccount.AllowItemMnagement = true;
                }
                if (chkReports.Checked)
                {
                    objUserAccount.AllowReports = true;
                }
                if (chkJobs.Checked)
                {
                    objUserAccount.AllowJobs = true;
                }
                if (chkSupplier.Checked)
                {
                    objUserAccount.AllowSupplier = true;
                }
                if (chkConfiguration.Checked)
                {
                    objUserAccount.AllowConfiguration = true;
                }
                */

                if (checkBox7.Checked)
                {
                    objUserAccount.AllowGeneral = true;
                }
                if (checkBox4.Checked)
                {
                    objUserAccount.AllowItemMnagement = true;
                }
                if (checkBox5.Checked)
                {
                    objUserAccount.AllowReports = true;
                }
                if (checkBox6.Checked)
                {
                    objUserAccount.AllowJobs = true;
                }
                if (checkBox3.Checked)
                {
                    objUserAccount.AllowSupplier = true;
                }
                if (checkBox1.Checked)
                {
                    objUserAccount.AllowConfiguration = true;
                }

               /* checkBox7.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());               
                checkBox4.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                checkBox5.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                checkBox6.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                checkBox3.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                checkBox1.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());*/

                if (chkLevel1.Checked || chkLevel2.Checked || chkLevel3.Checked)
                {

                    strAccesslevel = string.Empty;
                    if (chkLevel1.Checked)
                    {
                        strAccesslevel = "1";
                    }
                    if (chkLevel2.Checked)
                    {
                        if (!string.IsNullOrEmpty(strAccesslevel))
                        {
                            strAccesslevel = strAccesslevel + ",2";
                        }
                        else
                        {
                            strAccesslevel = "2";
                        }

                    }
                    if (chkLevel3.Checked)
                    {
                        if (!string.IsNullOrEmpty(strAccesslevel))
                        {
                            strAccesslevel = strAccesslevel + ",3";
                        }
                        else
                        {
                            strAccesslevel = "3";
                        }
                    }

                }
                else
                {

                    errorProvider1.SetError(this.grpbxAccessLevel, "Select at least one.");
                    successvalue = false;
                  
                }

                objUserAccount.Company = txtCompany.Text;

                objUserAccount.Mobile = txtMobile.Text;
                //objUserAccount.Fax = txtFax.Text;
                objUserAccount.JobTittle = txtJobTittle.Text;
                objUserAccount.DepartMent = cmbDepartment.SelectedText;
                if (txtPhone.Text == "Phone")
                {
                    objUserAccount.Phone = string.Empty;
                }
                else
                {
                    objUserAccount.Phone = txtPhone.Text;
                }
                if (txtAddress.Text == "Street")
                {
                    objUserAccount.Address = string.Empty;
                }
                else
                {
                    objUserAccount.Address = txtAddress.Text;
                }
                if (txtState.Text == "State")
                {
                    objUserAccount.State = string.Empty;
                }
                else
                {

                    objUserAccount.State = txtState.Text;
                }

                if (txtCity.Text == "City/Town")
                {
                    objUserAccount.Town = string.Empty;
                }
                else
                {
                    objUserAccount.Town = txtCity.Text;
                }
                if (txtCountry.Text == "Country")
                {
                    objUserAccount.Country = string.Empty;
                }
                else
                {
                    objUserAccount.Country = txtCountry.Text;
                }
                if (txtPostalCode.Text == "Postal Code")
                {
                    objUserAccount.PostalCode = string.Empty;
                }
                else
                {
                    objUserAccount.PostalCode = txtPostalCode.Text;
                }

                objUserAccount.Notes = txtNotes.Text;
                objUserAccount.AccessLevel = strAccesslevel;


                //if (chkIsAsmin.Checked == true)
                //{
                //    objUserAccount.IsAdmin = true;
                //}
                //else
                //{
                //    objUserAccount.IsAdmin = false;
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void chkLevel1_Enter(object sender, EventArgs e)
        {
            chkLevel2.Enabled = true;
            chkLevel3.Enabled = true;
            chkLevel2.Enabled = true;
            chkLevel2.Checked = true;
            chkLevel3.Checked = true;
        }

        private void chkLevel2_Enter(object sender, EventArgs e)
        {
            chkLevel1.Enabled = false;
            chkLevel1.Checked = false;
            chkLevel3.Enabled = true;
            chkLevel3.Checked = true;

        }

        private void chkLevel3_Enter(object sender, EventArgs e)
        {
            chkLevel1.Enabled = false;
            chkLevel1.Checked = false;
            chkLevel2.Enabled = false;
            chkLevel2.Checked = false;
        }

        private void chkLevel3_CheckStateChanged(object sender, EventArgs e)
        {
            if (!chkLevel3.Checked)
            {
                chkLevel1.Enabled = true;  
                chkLevel2.Enabled = true;             

            }
        }

        private void tabUserPrevileges_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabUserPrevileges.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabUserPrevileges.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                //g.FillRectangle(Brushes.SteelBlue, e.Bounds);
                Color myrgb = new Color();
                myrgb = Color.FromArgb(58, 73, 83);
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

        //PlaceHolderchanges Start   Added By Ajay.S 11/05/2017
        #region ClearingPlaceHolder
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Street")
            {
                txtAddress.ForeColor = Color.DarkGray; ;
                txtAddress.Text = "";
            }

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.ForeColor = Color.DarkGray;
                txtAddress.Text = "Street";
            }

        }


        private void txtState_Enter(object sender, EventArgs e)
        {
            if (txtState.Text == "State")
            {
                txtState.ForeColor = Color.DarkGray;
                txtState.Text = "";
            }
        }

        private void txtState_Leave(object sender, EventArgs e)
        {
            if (txtState.Text == "")
            {
                txtState.ForeColor = Color.DarkGray;
                txtState.Text = "State";
            }
        }

        private void txtPostalCode_Enter(object sender, EventArgs e)
        {
            if (txtPostalCode.Text == "Postal Code")
            {
                txtPostalCode.ForeColor = Color.DarkGray;
                txtPostalCode.Text = "";
            }
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            if (txtPostalCode.Text == "")
            {
                txtPostalCode.ForeColor = Color.DarkGray;
                txtPostalCode.Text = "Postal Code";
            }
        }
        private void txtCountry_Enter(object sender, EventArgs e)
        {
            if (txtCountry.Text == "Country")
            {
                txtCountry.ForeColor = Color.DarkGray;
                txtCountry.Text = "";
            }
        }
        private void txtCountry_Leave(object sender, EventArgs e)
        {
            if (txtCountry.Text == "")
            {
                txtCountry.ForeColor = Color.DarkGray;
                txtCountry.Text = "Country";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.ForeColor = Color.DarkGray;
                txtPhone.Text = "";
            }

        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.ForeColor = Color.DarkGray;
                txtPhone.Text = "Phone";
                }
        }
       
        private void txtCity_Enter(object sender, EventArgs e)
        {

            if (txtCity.Text == "City/Town")
            {
                txtCity.ForeColor = Color.DarkGray; ;
                txtCity.Text = "";
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text == "")
            {
                txtCity.ForeColor = Color.DarkGray;
                txtCity.Text = "City/Town";
            }
        }
        #endregion ClearingPlaceHolder

        private void gvUsers_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                intSelectedRowId = e.RowIndex;
                int UserID = Convert.ToInt32(gvUsers.Rows[e.RowIndex].Cells["UserID"].Value);
                UserUpdate objUserUpdate = new UserUpdate(UserID);
                objUserUpdate.CallBackUserDetailsBind = new global::BindUserDetailsDeligate(this.BindUsers);
                objUserUpdate.ShowDialog();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string Emailaddress = string.Empty;
            Emailaddress = txtEmail.Text;
            if (!IsValid(Emailaddress))
            {
                txtEmail.Focus();
                errorProvider1.SetError(this.txtEmail, "Please enter valid email.");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                if (!string.IsNullOrEmpty(emailaddress))
                {
                    MailAddress m = new MailAddress(emailaddress);
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string UserName = txtInput.Text;
                    DataTable dt = new DataTable();
                    dt = DAL.BindUserList(UserName, "");
                    if (dt.Rows.Count > 0)
                    {
                        gvUsers.DataSource = dt;
                    }
                    else
                    {
                        gvUsers.DataSource = null;
                    }
                }
                else
                {
                    BindUsers();
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
            BindUsers();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string UserName = txtInput.Text;
                    DataTable dt = new DataTable();
                    dt = DAL.BindUserList(UserName, UserName);
                    if (dt.Rows.Count > 0)
                    {
                        gvUsers.DataSource = dt;
                    }
                    else
                    {
                        gvUsers.DataSource = null;
                    }
                }
                else
                {
                    BindUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDepartment Departmentobj = new AddDepartment();
            Departmentobj.CallbackDepartment = new global::BindCategory(this.CallbackDepartmentlist);
            Departmentobj.ShowDialog();
        }

        //ToolBAL ToolDepobj = new ToolBAL();
        public void CallbackDepartmentlist(string DepartmentName)
        {
            try
            {
                int i = objBAL.InsertDepartment(DepartmentName);
                if (i == 1)
                {
                    MessageBox.Show("Data Saved SuccessFully",this.Text);
                    BindDepartment();
                }
                else
                {
                    MessageBox.Show("Inserted Fail",this.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabUserPrevileges_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                 if (e.TabPage.Name == tbUserHistory.Name)
                {
                    BindLoginHistory("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BindLoginHistory(string UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DAL.BindLoginHistory(UserName);
                if (dt.Rows.Count>0)
                {
                    gvLoginHistory.DataSource = dt;
                    gvLoginHistory.AutoResizeColumns();
                }
                else
                {
                    gvLoginHistory.DataSource = null;
                }
                
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvLoginHistory != null)
                {
                    if (gvLoginHistory.Rows.Count > 0)
                    {
                        ExportToExcel(gvLoginHistory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ExportToExcel(DataGridView gv)
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
                for (int i = 0; i < gv.Rows.Count; i++)
                {
                    for (int j = 0; j < gv.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gv.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = gv.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(gv.Rows[i].Cells[j].ToString()))
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = gv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        cellColumnIndex++;
                    }
                    if (cellRowIndex == 1)
                    {
                        cellRowIndex = 2;
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

        private void txtLoginHistoryInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtLoginHistoryInput.Text))
                {
                    BindLoginHistory(txtLoginHistoryInput.Text);
                }
                else
                {
                    BindLoginHistory("");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
    }
}
