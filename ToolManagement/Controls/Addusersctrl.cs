using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using TooLManagementEntities;
using ToolBusinessLogiclayer;
using System.Windows.Forms;
using System.IO.Ports;


namespace ToolManagement.Controls
{
    public partial class Addusersctrl : UserControl
    {

        public Addusersctrl()
        {
            InitializeComponent();
            BindUsers();
            btnSave.Visible = true;
            btnuserUpdate.Visible = false;
        }


        ToolBAL objBAL = new ToolBAL();
        UserAccountBo objUserAccount = new UserAccountBo();
        DataSet ds = null;
        bool successvalue = true;
        int UserID = 0;
        private void BindUsers()
        {
            gvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            gvUsers.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            gvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            try
            {
                ds = objBAL.BindUsers(0);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    gvUsers.DataSource = ds.Tables[0];
                    gvUsers.Columns["userID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Validations()
        {
            try
            {
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

                if (txtUserName.Text != string.Empty)
                {
                    objUserAccount.UserName = txtUserName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtUserName, "User Name is required.");
                    successvalue = false;
                }
                if (chkGeneral.Checked)
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


                if (!chkLevel1.Checked || !chkLevel2.Checked || !chkLevel3.Checked)
                {
                    errorProvider1.SetError(this.grpbxAccessLevel, "Select at least one.");
                    successvalue = false;
                }
                else
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

                objUserAccount.Company = txtCompany.Text;
                objUserAccount.Phone = txtPhone.Text;
                objUserAccount.Mobile = txtMobile.Text;
                //objUserAccount.Fax = txtFax.Text;
                objUserAccount.JobTittle = txtJobTittle.Text;
                objUserAccount.DepartMent = cmbDepartment.SelectedText;
                objUserAccount.Address = txtAddress.Text;
                objUserAccount.State = txtState.Text;
                objUserAccount.Town = txtTown.Text;
                objUserAccount.Country = txtCountry.Text;
                objUserAccount.PostalCode = txtPostalCode.Text;
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
        FingerPrintlogin fingerprintobj = new FingerPrintlogin();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort objPort1 = new SerialPort();
                Validations();
                if (successvalue)
                {
                    int i = objBAL.InsertUserAccountDetails(objUserAccount);
                    int value = 0;// fingerprintobj.ReeadIDresponse(out objPort1);

                    if (value == 2)
                    {
                        if (MessageBox.Show("Please place user index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            int value1 = fingerprintobj.ReeadIDresponse2(objPort1);
                            if (value1 == 3)
                            {
                                if (MessageBox.Show("Please remove index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    int value2 = fingerprintobj.ReeadIDresponse2(objPort1);
                                    if (value2 == 4)
                                    {
                                        if (MessageBox.Show("Please place user index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                        {
                                            int value3 = fingerprintobj.ReeadIDresponse2(objPort1);
                                            if (value3 == 5)
                                            {
                                                MessageBox.Show("Your fingerprint has been configured successfully");

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("User has been created Successfully.", this.Text);
                        ///BindUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #region TextboxEvents

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Street")
            {
                txtAddress.ForeColor = Color.Black;
                txtAddress.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.ForeColor = Color.Gray;

                txtAddress.Text = "Enter Address";
            }
        }

        private void txtTown_Enter(object sender, EventArgs e)
        {
            if (txtTown.Text == "City/Town")
            {
                txtTown.ForeColor = Color.Black; ;
                txtTown.Text = "";
            }

        }

        private void txtTown_Leave(object sender, EventArgs e)
        {
            if (txtTown.Text == "")
            {
                txtTown.ForeColor = Color.Gray;
                txtTown.Text = "City/Town";
            }
        }

        private void txtState_Enter(object sender, EventArgs e)
        {
            if (txtState.Text == "State")
            {
                txtState.ForeColor = Color.Black;
                txtState.Text = "";
            }
        }

        private void txtState_Leave(object sender, EventArgs e)
        {
            if (txtState.Text == "")
            {
                txtState.ForeColor = Color.Gray;
                txtState.Text = "State";
            }

        }

        private void txtPostalCode_Enter(object sender, EventArgs e)
        {
            if (txtPostalCode.Text == "Postal Code")
            {
                txtState.ForeColor = Color.Black;
                txtPostalCode.Text = "";
            }

        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            if (txtPostalCode.Text == "")
            {
                txtPostalCode.ForeColor = Color.Gray;
                txtPostalCode.Text = "Postal Code";
            }

        }

        private void txtCountry_Enter(object sender, EventArgs e)
        {
            if (txtCountry.Text == "Country")
            {
                txtCountry.ForeColor = Color.Black;
                txtCountry.Text = "";
            }

        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            if (txtCountry.Text == "")
            {
                txtCountry.ForeColor = Color.Gray;
                txtCountry.Text = "Country";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                string email = string.Empty;
                email = txtEmail.Text;
                if (email != string.Empty)
                {
                    CheckRegisterUser(email);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            if (txtFirstName.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtFirstName, String.Empty);
            }

            else
            {

                errorProvider1.SetError(this.txtFirstName, "Name is required.");
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtEmail, String.Empty);
            }

            else
            {
                errorProvider1.SetError(this.txtEmail, "Email Id is required.");
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            if (txtLastName.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtLastName, String.Empty);
            }

            else
            {
                errorProvider1.SetError(this.txtLastName, "Last Name is required.");
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtPassword, String.Empty);
            }

            else
            {
                errorProvider1.SetError(this.txtPassword, "Password is required.");
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtConfirmPassword, String.Empty);
            }

            else
            {
                errorProvider1.SetError(this.txtConfirmPassword, "Confirm Password is required.");
            }
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty)
            {
                errorProvider1.SetError(this.txtUserName, String.Empty);
            }

            else
            {
                errorProvider1.SetError(this.txtUserName, "User Name is required.");
            }
        }
        #endregion
        public int CheckRegisterUser(string email)
        {

            int i = objBAL.CheckRegisteredEmail(email);
            return i;
        }


        private void chkIsAsmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string AccessLevel = string.Empty;
            btnSave.Visible = false;
            btnuserUpdate.Visible = true;
            if (e.RowIndex > -1)
            {
                UserID = Convert.ToInt32(gvUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                DataSet ds = new DataSet();
                ds = objBAL.BindUsers(UserID);
                if (ds != null && ds.Tables.Count > 1)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtFirstName.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                        txtLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                        txtUserName.Text = ds.Tables[0].Rows[0]["UserName"].ToString();
                        txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                        txtConfirmPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                        txtCompany.Text = ds.Tables[0].Rows[0]["Company"].ToString();
                        txtPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                        txtMobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();

                        txtJobTittle.Text = ds.Tables[0].Rows[0]["JobTittle"].ToString();
                        cmbDepartment.Text = ds.Tables[0].Rows[0]["DepartMent"].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                        txtTown.Text = ds.Tables[0].Rows[0]["Town"].ToString();
                        txtState.Text = ds.Tables[0].Rows[0]["State"].ToString();
                        txtPostalCode.Text = ds.Tables[0].Rows[0]["PostalCode"].ToString();
                        txtCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
                        txtNotes.Text = ds.Tables[0].Rows[0]["Notes"].ToString();
                        //ds.Tables[0].Rows[0]["IsAdmin"].ToString();
                        //ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                        txtEmail.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();

                        AccessLevel = ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                        if (!string.IsNullOrEmpty(AccessLevel))
                        {
                            if (AccessLevel.Contains('1'))
                            {
                                chkLevel1.Checked = true;
                            }
                            else
                            {
                                chkLevel1.Checked = false;
                            }
                            if (AccessLevel.Contains('2'))
                            {
                                chkLevel2.Checked = true;
                            }
                            else
                            {
                                chkLevel2.Checked = false;
                            }
                            if (AccessLevel.Contains('3'))
                            {
                                chkLevel3.Checked = true;
                            }
                            else
                            {
                                chkLevel3.Checked = false;
                            }
                        }
                        else
                        {
                            chkLevel1.Checked = false;
                            chkLevel2.Checked = false;
                            chkLevel3.Checked = false;
                        }
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {

                        chkGeneral.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());
                        // = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowInventory"].ToString());
                        chkManagement.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                        chkJobs.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                        chkReports.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                        chkSupplier.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                        chkConfiguration.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());
                    }
                    else
                    {
                        //chkGeneral.Checked = false;
                        chkManagement.Checked = false;
                        chkJobs.Checked = false;
                        chkReports.Checked = false;
                        chkSupplier.Checked = false;
                        chkConfiguration.Checked = false;
                        //chkHelp.Checked = false;
                    }
                }
            }
        }

        private void btnuserUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                Validations();
                if (successvalue)
                {
                    int i = objBAL.UpdateUserAccountDetails(objUserAccount, UserID);
                    if (i > 0)
                    {
                        MessageBox.Show("User has been updated successfully.", this.Text);
                      //  BindUsers();
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
            txtTown.Text = "";
            txtState.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtNotes.Text = "";
            txtEmail.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtNotes.Text = "";
            txtEmail.Text = "";


            chkLevel1.Checked = false;
            chkLevel2.Checked = false;
            chkLevel3.Checked = false;

            //chkGeneral.Checked = false;
            chkManagement.Checked = false;
            chkJobs.Checked = false;
            chkReports.Checked = false;
            chkSupplier.Checked = false;
            chkConfiguration.Checked = false;
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

                    chkGeneral.Checked = true;
                    chkManagement.Checked = true;
                    chkJobs.Checked = true;
                    chkReports.Checked = true;
                    chkSupplier.Checked = true;
                    chkConfiguration.Checked = true;
                    chkHelp.Checked = true;
                }
                else
                {
                    objUserAccount.IsAdmin = false;
                    chkLevel1.Checked = false;
                    chkLevel2.Checked = false;
                    chkLevel3.Checked = false;

                    chkGeneral.Checked = false;
                    chkManagement.Checked = false;
                    chkJobs.Checked = false;
                    chkReports.Checked = false;
                    chkSupplier.Checked = false;
                    chkConfiguration.Checked = false;
                    chkHelp.Checked = false;
                }
            }

        }

        private void chkLevel3_CheckedChanged(object sender, EventArgs e)
        {
            chkLevel1.Enabled = false;
            chkLevel2.Enabled = false;
        }

        private void chkLevel2_CheckedChanged(object sender, EventArgs e)
        {
            chkLevel1.Enabled = false;
            chkLevel3.Enabled = true ;

        }

        private void chkLevel1_CheckedChanged(object sender, EventArgs e)
        {
            chkLevel2.Enabled = true ;
            chkLevel3.Enabled = true;
        }

    }
}