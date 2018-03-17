using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TooLManagementEntities;
using ToolBusinessLogiclayer;

namespace ToolManagement.Controls
{
    public partial class AddSupplierctrl : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;

        public AddSupplierctrl()
        {
            InitializeComponent();
            btnSave.Click += new EventHandler(OnButtonClicked);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (OnUserControlButtonClicked != null)
            {
                OnUserControlButtonClicked(this, e);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ToolBAL objBAL = new ToolBAL();
                SupplierDetails objSupplierDetails = new SupplierDetails();
                objSupplierDetails.SupplierName = txtFirstName.Text;
                //objSupplierDetails.MiddleName = txtMiddleName.Text;
                //objSupplierDetails.LastName = txtLastName.Text;

                if (txtCompany.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Please enter company name.");
                    txtCompany.Focus();
                    return;
                }
                objSupplierDetails.Company = txtCompany.Text;              
                objSupplierDetails.Displayname = txtDisplayName.Text;                
                objSupplierDetails.Mobile = txtMobile.Text;
                objSupplierDetails.Email = txtEmail.Text;
                objSupplierDetails.Fax = txtFax.Text;
                objSupplierDetails.AccountNo = txtAccountNo.Text;
                objSupplierDetails.PanNumber = txtPanNo.Text;
                objSupplierDetails.TaxRegistrationNo = txtRegisterNo.Text;
                if (txtSupplierCode.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Please enter Supplier Code.");
                    txtSupplierCode.Focus();
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
               
                int i = objBAL.AddSupplierDetails(objSupplierDetails);

                if (i != 0)
                {
                    MessageBox.Show("Data Saved Successfully.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed.");
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
            try
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
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clear();
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