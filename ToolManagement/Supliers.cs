using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TooLManagementEntities;
using ToolBusinessLogiclayer;

public delegate void BindSupplierDetailsDeligate();

namespace ToolManagement
{
    public partial class Supliers : Form
    {
        public Supliers()
        {
            InitializeComponent();           
        }
        int SupplierID = 0;
 
        public Supliers(DataTable dt,int supplierID)
        {
            InitializeComponent();
            SupplierID = supplierID;

            txtFirstName.Text = dt.Rows[0]["SupplierName"].ToString();

            txtCompany.Text = dt.Rows[0]["Company"].ToString();
            txtDisplayName.Text = dt.Rows[0]["DisplayName"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtFax.Text = dt.Rows[0]["Fax"].ToString();
            txtAccountNo.Text = dt.Rows[0]["AccountNo"].ToString();
            txtPanNo.Text = dt.Rows[0]["PanNumber"].ToString();
            txtRegisterNo.Text = dt.Rows[0]["TaxRegistrationNo"].ToString();
            txtSupplierCode.Text = dt.Rows[0]["SupplierCode"].ToString();
            txtCity.Text = dt.Rows[0]["City"].ToString();
            txtState.Text = dt.Rows[0]["State"].ToString();
            txtCountry.Text = dt.Rows[0]["Country"].ToString();
            txtPostalCode.Text = dt.Rows[0]["PostalCode"].ToString();
            txtNote.Text = dt.Rows[0]["Notes"].ToString();

        }
        public BindSupplierDetailsDeligate CallbackFunctn;
        DataSet ds = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtCompany.Text = "";
            txtDisplayName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            txtAccountNo.Text = "";
            txtPanNo.Text = "";
            txtRegisterNo.Text = "";
            txtSupplierCode.Text = "";
            txtSupplierCode.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
            txtPostalCode.Text = "";
            txtNote.Text = "";
            txtFirstName.Text = "";
            txtWebsite.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDetails objSupplierDetails = new SupplierDetails();
                objSupplierDetails.SupplierName = txtFirstName.Text;
                //objSupplierDetails.MiddleName = txtMiddleName.Text;
                //objSupplierDetails.LastName = txtLastName.Text;

                if (txtCompany.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Please enter company name");
                    return;
                }
                objSupplierDetails.Company = txtCompany.Text;
                objSupplierDetails.Displayname = txtDisplayName.Text;
                objSupplierDetails.Mobile = txtMobile.Text;
                objSupplierDetails.Email = txtEmail.Text;
                objSupplierDetails.Address = txtAddress.Text;
                objSupplierDetails.Phone = txtPhone.Text;
                objSupplierDetails.Fax = txtFax.Text;
                objSupplierDetails.AccountNo = txtAccountNo.Text;
                objSupplierDetails.PanNumber = txtPanNo.Text;
                objSupplierDetails.TaxRegistrationNo = txtRegisterNo.Text;
                if (txtSupplierCode.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Please enter Supplier Code");
                    return;
                }
                objSupplierDetails.SupplierCode = txtSupplierCode.Text;

                //objSupplierDetails.Address = txtAddress.Text;
                //objSupplierDetails.Phone = txtPhone.Text;
                //objSupplierDetails.City = txtCity.Text;
                //objSupplierDetails.State = txtState.Text;
                //objSupplierDetails.Country = txtCountry.Text;
                //objSupplierDetails.PostalCode = txtPostalCode.Text;

                if (txtPhone.Text == "Phone")
                {
                    objSupplierDetails.Phone = string.Empty;
                }
                else
                {
                    objSupplierDetails.Phone = txtPhone.Text;
                }
                if (txtAddress.Text == "Street")
                {
                    objSupplierDetails.Address = string.Empty;
                }
                else
                {
                    objSupplierDetails.Address = txtAddress.Text;
                }
                if (txtState.Text == "State")
                {
                    objSupplierDetails.State = string.Empty;
                }
                else
                {

                    objSupplierDetails.State = txtState.Text;
                }

                if (txtCity.Text == "City/Town")
                {
                    objSupplierDetails.City = string.Empty;
                }
                else
                {
                    objSupplierDetails.City = txtCity.Text;
                }
                if (txtCountry.Text == "Country")
                {
                    objSupplierDetails.Country = string.Empty;
                }
                else
                {
                    objSupplierDetails.Country = txtCountry.Text;
                }
                if (txtPostalCode.Text == "Postal Code")
                {
                    objSupplierDetails.PostalCode = string.Empty;
                }
                else
                {
                    objSupplierDetails.PostalCode = txtPostalCode.Text;
                }

                objSupplierDetails.Notes = txtNote.Text;
                objSupplierDetails.UserId = Login.UserId;
                objSupplierDetails.SupplierID = SupplierID;
                ToolBAL objBAL = new ToolBAL();
                int i = objBAL.UpdateSupplierDetails(objSupplierDetails);

                if (i != 0)
                {
                    MessageBox.Show("Supplier updated successfully.");
                    CallbackFunctn();
                    Clear();
                    this.Hide();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
        }

        //PlaceHolderchanges Start   Added By Ajay.S 11/05/2017

        #region ClearingPlaceHolder
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
                txtAddress.Text = "Street";
            }
        }
        private void txtCity_Enter(object sender, EventArgs e)
        {
            if (txtCity.Text == "City/Town")
            {
                txtCity.ForeColor = Color.Black; ;
                txtCity.Text = "";
            }
        }
        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text == "")
            {
                txtCity.ForeColor = Color.Gray;
                txtCity.Text = "City/Town";
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
                txtPostalCode.ForeColor = Color.Black;
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
        #endregion ClearingPlaceHolder

        //PlaceHolderchanges End    Added By Ajay.S 11/05/2017
    }
}
