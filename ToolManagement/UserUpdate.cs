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

public delegate void BindUserDetailsDeligate(); 
namespace ToolManagement
{
    public partial class UserUpdate : Form
    {
        public UserUpdate()
        {
            InitializeComponent();
        }

        public BindUserDetailsDeligate CallBackUserDetailsBind;
        ToolBAL objBAL = new ToolBAL();
        ToolDAL DAL = new ToolDAL();
        UserAccountBo objUserAccount = new UserAccountBo();
        DataSet ds = null;
        bool successvalue = true;
        int UserID = 0;
        public UserUpdate(int intUserId)
        {
            UserID = intUserId;
            InitializeComponent();

            ds = new DataSet();
            string AccessLevel = string.Empty;
            ds = objBAL.BindUsers(UserID);
            if (ds != null && ds.Tables.Count > 1)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtFirstName.Text = ds.Tables[0].Rows[0]["First name"].ToString();
                    txtLastName.Text = ds.Tables[0].Rows[0]["Last name"].ToString();
                    txtUserName.Text = ds.Tables[0].Rows[0]["User name"].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    txtConfirmPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    txtCompany.Text = ds.Tables[0].Rows[0]["Company"].ToString();
                    txtPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();

                    txtJobTittle.Text = ds.Tables[0].Rows[0]["Job tittle"].ToString();
                    cmbDepartment.Text = ds.Tables[0].Rows[0]["Department"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["Town"].ToString();
                    txtState.Text = ds.Tables[0].Rows[0]["State"].ToString();
                    txtPostalCode.Text = ds.Tables[0].Rows[0]["Postal code"].ToString();
                    txtCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
                    txtNotes.Text = ds.Tables[0].Rows[0]["Notes"].ToString();
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Is admin"].ToString()))
                    {
                        Cboxusertype.SelectedIndex = 0;

                        //***Night changes***/
                        chkGeneral.Enabled = false;
                        chkItemManagement.Enabled = false;
                        chkJobs.Enabled = false;
                        chkReports.Enabled =false ;
                        chkSupplier.Enabled=false ;
                        chkConfiguration.Enabled = false;

                        chkLevel1.Enabled = false;
                        chkLevel2.Enabled = false; 
                        chkLevel3.Enabled = false;

                        //*
                    }
                    else
                    {
                        Cboxusertype.SelectedIndex = 1;

                        //***Night changes***/
                        chkGeneral.Enabled = false;
                        chkItemManagement.Enabled = true;
                        chkJobs.Enabled = true ;
                        chkReports.Enabled = true ;
                        chkSupplier.Enabled = false ;
                        chkConfiguration.Enabled = false;
                        //*
                    }
                    //ds.Tables[0].Rows[0]["IsAdmin"].ToString();
                    //ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["Email Id"].ToString();

                    AccessLevel = ds.Tables[0].Rows[0]["Access levels"].ToString();
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
                    chkItemManagement.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                    chkJobs.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                    chkReports.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                    chkSupplier.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                    chkConfiguration.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());

                  
                }
                else
                {
                    chkGeneral.Checked = false;
                    chkItemManagement.Checked = false;
                     chkJobs.Checked = false;
                     chkReports.Checked = false;
                     chkSupplier.Checked = false;
                     chkConfiguration.Checked = false;
                }
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
                        CallBackUserDetailsBind();
                        Clear();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Clear()
        {
           
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
        public void Validations()
        {
            try
            {
                errorProvider1.Clear();
                string strAccesslevel = null;
                if (txtFirstName.Text.Trim() != string.Empty)
                {
                    objUserAccount.FirstName = txtFirstName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtFirstName, "First Name is required.");
                    successvalue = false;
                }
                if (txtLastName.Text.Trim() != string.Empty)
                {
                    objUserAccount.LastName = txtLastName.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtLastName, "Last Name is required.");
                    successvalue = false;
                }

                if (txtEmail.Text.Trim() != string.Empty)
                {
                    objUserAccount.Email = txtEmail.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtEmail, "Email ID is required.");
                    successvalue = false;
                }

                if (txtPassword.Text.Trim() != string.Empty)
                {
                    objUserAccount.Password = txtPassword.Text;
                }
                else
                {
                    errorProvider1.SetError(this.txtPassword, "Password is required.");
                    successvalue = false;
                }

                if (txtConfirmPassword.Text.Trim() != string.Empty)
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
               

                if (chkGeneral.Checked)
                {
                    objUserAccount.AllowGeneral = true;
                }
                if (chkItemManagement.Checked)
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

                chkGeneral.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());
                // = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowInventory"].ToString());
                chkItemManagement.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                chkJobs.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                chkReports.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                chkSupplier.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                chkConfiguration.Checked = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());

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
                objUserAccount.Phone = txtPhone.Text;
                objUserAccount.Mobile = txtMobile.Text;
                //objUserAccount.Fax = txtFax.Text;
                objUserAccount.JobTittle = txtJobTittle.Text;
                objUserAccount.DepartMent = cmbDepartment.SelectedText;
                objUserAccount.Address = txtAddress.Text;
                objUserAccount.State = txtState.Text;
                objUserAccount.Town = txtCity.Text;
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
        public int CheckRegisterUser(string email)
        {

            int i = objBAL.CheckRegisteredEmail(email);
            return i;
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


                    chkGeneral.Checked = true;
                    chkGeneral.Enabled = false;

                    chkItemManagement.Enabled = false;
                    chkItemManagement.Checked = true;

                    chkJobs.Enabled = false;
                    chkJobs.Checked = true;

                    chkReports.Enabled = false;
                    chkReports.Checked = true;

                    chkSupplier.Enabled = false;
                    chkSupplier.Checked = true;

                    chkConfiguration.Enabled = false;
                    chkConfiguration.Checked = true;

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


                    chkGeneral.Checked = false;
                    chkGeneral.Enabled = false;

                    chkItemManagement.Enabled = true;
                    chkItemManagement.Checked = true;

                    chkJobs.Enabled = true;
                    chkJobs.Checked = true;

                    chkReports.Enabled = true;
                    chkReports.Checked = true;

                    chkSupplier.Enabled = false;
                    chkSupplier.Checked = false;

                    chkConfiguration.Enabled = false;
                    chkConfiguration.Checked = false;



                }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
