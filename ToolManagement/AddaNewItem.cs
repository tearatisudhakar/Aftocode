using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;
using TooLManagementEntities;
using ToolTracker;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Configuration;

public delegate void BindToolDetailsDeligate();
namespace ToolManagement
{
    public partial class AddaNewItem : Form
    {
        ToolBAL objcontroler = new ToolBAL();
        AddItemBo objbo = new AddItemBo();
        DataTable dt = null;
        public BindToolDetailsDeligate CallBackToolDetailsBind;
        int ItemID;
        StringBuilder sb = null;
        SerialPort objPort;
        int intIsCabinet = Convert.ToInt32(ConfigurationSettings.AppSettings["IsConnectedToCabinet"].ToString());
        bool IsCabinet = true;
        private string _strImagepath = ConfigurationSettings.AppSettings["ImagePath"].ToString();
        public AddaNewItem()
        {
            try
            {
                InitializeComponent();
                BindCategory();
                BindSuppliers();
                //  BindLocatioin();
                BindDrawer();
                BindAccessLevel();
                if (Login.IsAdmin)
                {
                    btnOk.Visible = true;    
                }
                else
                {
                    btnOk.Visible = false;
                }
                btnUpdate.Visible = false;
                BindItemType(0);
                BindLocatioin(0);
                btnAddQnty.Visible = false;
                txtQuantity.ReadOnly = false;
                numaricMOQ.ResetText();
                if (intIsCabinet == 1)
                {
                    IsCabinet = true;
                }
                else if (intIsCabinet == 0)
                {
                    IsCabinet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public AddaNewItem(string Itemcode, int intItemId)
        {
            try
            {
                //btnUpdateCancel.Visible = true;
                //btnCancel.Visible = false;
                ItemID = intItemId;
                InitializeComponent();
               // btnAddQnty.Visible = true;
                txtQuantity.ReadOnly = true;
                txtaddQntity.Visible = true;
                BindCategory();
                BindSuppliers();
                BindAccessLevel();
                //  BindLocatioin();
                BindDrawer();
                if (Login.IsAdmin)
                {
                    btnUpdate.Visible = true;
                }
                else
                {
                    btnUpdate.Visible = false;
                }
                btnOk.Visible = false;
                DataSet ds = new DataSet();
                ds = objcontroler.ItemInfo(Itemcode);
                string strLocation = string.Empty;
                string strDrawerLocation = string.Empty;
                string strBinLocation = string.Empty;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    strLocation = ds.Tables[0].Rows[0]["Location"].ToString();
                   // string[] aryLocation = null;
                    //if (!string.IsNullOrEmpty(strLocation) && strLocation.Contains("-"))
                    //{
                    //    aryLocation = strLocation.Split('-');
                    //    if (aryLocation.Length > 2)
                    //    {
                    //        strDrawerLocation = aryLocation[1].ToString();
                    //        strBinLocation = aryLocation[2].ToString();
                    //    }
                    //}
                    if (!string.IsNullOrEmpty(strLocation))
                    {

                        if (strLocation.Length >1 )
                        {
                            strDrawerLocation = strLocation.Substring(0, 1).ToString();
                            strBinLocation = strLocation;
                        }
                    }

                    cmbCategory.Text = ds.Tables[0].Rows[0]["Item Category"].ToString();
                    cmbItemGroup.Text = ds.Tables[0].Rows[0]["Item Group"].ToString();
                    cmbItemType.Text = ds.Tables[0].Rows[0]["Item Type"].ToString();  //commented by Rajkumar due to removed item type
                    txtItemKey.Text = ds.Tables[0].Rows[0]["Item Code"].ToString();
                    txtDescription.Text = ds.Tables[0].Rows[0]["Item Description"].ToString();
                    // cmbLocation.Text = ds.Tables[0].Rows[0]["Location"].ToString(); commented By Rajkumar due to Location divided into Drawer and bin
                    cmbSupplier.Text = ds.Tables[0].Rows[0]["Supplier"].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0]["Item Quantity"].ToString();
                    if (ds.Tables[0].Rows[0]["MOQ"].ToString() != string.Empty)
                    {
                        numaricMOQ.Value = Convert.ToInt32(ds.Tables[0].Rows[0]["MOQ"].ToString());
                    }
                    txtproductcode.Text = ds.Tables[0].Rows[0]["Product Code"].ToString();
                    cmbDrawer.Text = strDrawerLocation;
                    cmbLocation.Text = strBinLocation;
                    cmbAccessLevel.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0]["Access Level"].ToString());
                }
                if (ds.Tables.Count > 1)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
                        if (File.Exists(absolutePath))
                        {
                            picforItem.Image = System.Drawing.Image.FromFile(absolutePath);
                            txtimagepath.Text = absolutePath;
                        }
                        else
                        {
                            picforItem.Image = null;
                            // MessageBox.Show("Image file was not found", this.Text);
                            // return;
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindLocatioin(int DrawerId)
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindLocation(DrawerId);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Bin--" };
                dt.Rows.InsertAt(dr, 0);
                cmbLocation.ValueMember = "Code";
                cmbLocation.DisplayMember = "BinCode";
                cmbLocation.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void BindDrawer()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindDrawer();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Drawer--" };
                dt.Rows.InsertAt(dr, 0);
                cmbDrawer.ValueMember = "DrawerId";
                cmbDrawer.DisplayMember = "DrawerCode";
                cmbDrawer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void CallBackItemDeligateFN(int itemGroupId, string itemtype)
        {
            try
            {
                int i = objcontroler.InsertItemType(itemGroupId, itemtype, Login.UserId);

                if (i == 1)
                {
                    MessageBox.Show("Data Saved Successfully.", this.Text);
                    // int itemselectedgrooup = 0;
                    //  BindItemType(itemGroupId);
                    //   objAddItem.BindItemType(itemselectedgrooup);
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed.", this.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindSupplierDeligateFN()
        {
            try
            {
                BindSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            try
            {
                AddCategory itemcategory = new AddCategory();
                itemcategory.CallbackCategoryName = new global::BindCategory(this.CallbackBindFN);
                itemcategory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void BindCategory()
        {
            try
            {
                DataRow dr;
                //cmbCategory.Items.Clear();
                //   cmbCategory.DataSource = null;
                dt = new DataTable();
                dt = objcontroler.BindCategory();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Category--" };
                dt.Rows.InsertAt(dr, 0);
                cmbCategory.ValueMember = "ItemCategoryId";
                cmbCategory.DisplayMember = "ItemCategory";
                cmbCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindItemGroup(int itemselectedCategory)
        {
            try
            {
                //  int value = Convert.ToInt32(cmbCategory.SelectedValue.ToString());
               
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindItemGroup(itemselectedCategory);
                if (itemselectedCategory>0)
                {
                    dt = objcontroler.BindItemGroup(itemselectedCategory);
                    dr = dt.NewRow();
                    dr.ItemArray = new object[] { 0, "--Select Item Group--" };
                    dt.Rows.InsertAt(dr, 0);
                    cmbItemGroup.ValueMember = "ItemGroupId";
                    cmbItemGroup.DisplayMember = "ItemGroup";
                    cmbItemGroup.DataSource = dt;
                }
                else
                {
                    dt.Rows.Clear();
                    dr = dt.NewRow();
                    dr.ItemArray = new object[] { "--Select Item Group--",0 };
                    dt.Rows.InsertAt( dr,0);
                    cmbItemGroup.ValueMember = "ItemGroupId";
                    cmbItemGroup.DisplayMember = "ItemGroup";
                    cmbItemGroup.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindItemType(int itemselectedgrooup)
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindItemType(itemselectedgrooup);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select item type--" };
                dt.Rows.InsertAt(dr, 0);
                cmbItemType.ValueMember = "ItemTypeId";
                cmbItemType.DisplayMember = "ItemType";
                cmbItemType.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindSuppliers()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindSupplier();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0,"", "--Select Supplier--" };
                dt.Rows.InsertAt(dr, 0);
                cmbSupplier.ValueMember = "SupplierId";
                cmbSupplier.DisplayMember = "Company";
                cmbSupplier.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public void ClearFealds()
        {
            try
            {
                //txtItemKey.Clear();
                //txtItemCode.Text = "";
                //txtItemDesc.Text = "";
                //cmbItemType.SelectedValue = "";
                //txtBarcode.Text = "";
                //cmbItemGroup.SelectedIndex = 0;
                //cmbCategory.SelectedIndex = 0;
                //txtSupplier.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAddNewItemGroup_Click_1(object sender, EventArgs e)
        {
            try
            {
                AddItemGroup additemgroup = new AddItemGroup();
                // itemcategory.CallbackCategoryName = new global::BindCategory(this.CallbackBindFN);
                additemgroup.CallBackGroupDeligate = new global::BindGroupDeligate(this.BindGroupDeligateFN);
                additemgroup.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemGroup.SelectedIndex != 0)
                {
                    if (cmbItemGroup.SelectedIndex != 0)
                    {
                        int itemselectedgrooup = Convert.ToInt32(cmbItemGroup.SelectedValue);
                        BindItemType(itemselectedgrooup);
                    }
                    else
                    {
                        MessageBox.Show("Please Select Group",this.Text);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #region Validation

        private void Validations()
        {
            errorProvider1.Clear();
            sb = new StringBuilder();
            int _quantity = 0;  
            try
            {
                if (cmbCategory.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(btnAddNewCategory, "Please select Item Group");
                    sb.Append("Please select Group");
                }
                if (cmbItemGroup.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(btnAddNewItemGroup, "Please select Item sub Group");

                    if (sb != null)
                    {
                        sb.Append(",\n Please select sub Group.");
                    }
                    else
                    {
                        sb.Append("Please select sub Group");
                    }
                }
                if (cmbItemType.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(cmbItemType, "Please select Item type");

                    if (sb != null)
                    {
                        sb.Append(",\n Please select Item type.");
                    }
                    else
                    {
                        sb.Append("Please select Item type");
                    }
                }
                if (string.IsNullOrEmpty(txtItemKey.Text.Trim()))
                {
                    errorProvider1.SetError(txtItemKey, "Please enter Item Code");
                    if (sb != null)
                    {
                        sb.Append(",\n Please enter Item Code");

                    }
                    else
                    {
                        sb.Append("Please enter Item Code");
                    }
                }
                if (cmbDrawer.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(cmbDrawer, "Plese select Drawer location");
                    if (sb != null)
                    {
                        sb.Append(",\n Please select Drawer location.");
                    }
                    else
                    {
                        sb.Append("Please select Drawer location");
                    }
                }
                if (cmbLocation.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(cmbLocation, "Plese select Bin location.");
                    if (sb != null)
                    {
                        sb.Append(",\n Please select Bin location.");
                    }
                    else
                    {
                        sb.Append("Please select Bin location");
                    }
                }
                if (cmbSupplier.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(btnSupplier, "Plese select Supplier");
                    if (sb != null)
                    {
                        sb.Append(",\n Please select Supplier.");
                    }
                    else
                    {
                        sb.Append("Please select Supplier");
                    }
                }
                if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
                {
                    errorProvider1.SetError(txtQuantity, "Please enter Quantity");
                    if (sb != null)
                    {
                        sb.Append(",\n Please enter Quantity");

                    }
                    else
                    {
                        sb.Append("Please enter Quantity");
                    }
                }
                else if (int.TryParse(txtQuantity.Text, out _quantity))
                {
                    if (_quantity <= 0)
                    {
                        errorProvider1.SetError(txtQuantity, "Please enter valid Quantity");
                        sb.Append("Please enter valid Quantity");
                    }
                }

                if (numaricMOQ.Value <= 0)
                {
                    errorProvider1.SetError(numaricMOQ, "Please enter MOQ");
                    if (sb != null)
                    {
                        sb.Append(",\n Please enter MOQ");
                    }
                    else
                    {
                        sb.Append("Please enter MOQ");
                    }
                }

                if (cmbAccessLevel.SelectedIndex <= 0)
                {
                    errorProvider1.SetError(cmbAccessLevel, "Plese select access level");
                    if (sb != null)
                    {
                        sb.Append(",\n Plese select access level.");
                    }
                    else
                    {
                        sb.Append("Plese select access level");
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        #endregion
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                i = objcontroler.CheckItemCodeExit(txtItemKey.Text.Trim());

                if (i > 0)
                {
                    errorProvider1.SetError(txtItemKey, "Already exit item code.");
                    txtItemKey.Focus();
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                 Validations();
                if (sb != null && sb.ToString() != string.Empty)
                {
                    //MessageBox.Show(sb.ToString(), "Mandatary Fields");
                    return;
                }
                else
                {
                    InsertItem();
                    //CallBackToolDetailsBind(objbo);
                    InsertItemDetailsFn(objbo);
                    //ItemManagement obj = new ItemManagement();
                    //obj.fillItemList();
                    //Home obj = new Home();
                    // this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void InsertItemDetailsFn(AddItemBo objbo)
        {
            try
            {
                if (IsCabinet)
                {
                    objPort = new SerialPort();
                    string[] ArrayComPortsNames = null;
                    string portname = string.Empty;
                    ArrayComPortsNames = SerialPort.GetPortNames();
                    if (ArrayComPortsNames.Length > 0)
                    {
                        objPort.PortName = ArrayComPortsNames[0];

                        if (objPort != null && objPort.IsOpen)
                        {
                            objPort.Close();
                        }
                        objPort.Parity = Parity.None;
                        objPort.StopBits = StopBits.One;
                        objPort.DataBits = 8;
                        objPort.Handshake = Handshake.None;
                        objPort.RtsEnable = true;
                        objPort.WriteTimeout = 2000;
                        objPort.Open();
                        objPort.WriteLine("BIC");
                        Thread.Sleep(2000);
                        objPort.WriteLine(objbo.Location);
                    }
                    else
                    {
                        MessageBox.Show("System couldn't find a cabinet, please connect it.", this.Text);
                        return;
                    }
                }
                int i = objcontroler.InsertItemDetails(objbo, Login.UserId);
                if (i != 0)
                {
                    MessageBox.Show("Data Saved Successfully.", this.Text);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (IsCabinet)
                {
                    objPort.Close();
                }
            }
        }
        public void UpdateItemDetails(AddItemBo objbo, int ItemCode)
        {
            try
            {
                // ToolBAL objcontroler = new ToolBAL();
                int i = objcontroler.UpdateItemDetails(objbo, Login.UserId, ItemCode);
                if (i != 0)
                {
                    MessageBox.Show("Data Updated Successfully.", this.Text);
                    CallBackToolDetailsBind();
                    this.Hide();
                    // GetItemsinfo();
                    // GvIteminfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void InsertItem()
        {
            try
            {

                //write a validations here
                //commented by Rajkimar due to validations handle in String builderseperate method 
                //Boolean value = true;
                //if (cmbLocation.SelectedValue == null)
                //{

                //    value = false;

                //}
                string DestinationFile = string.Empty;
                if (!string.IsNullOrEmpty(txtimagepath.Text) && File.Exists(txtimagepath.Text))
                {
                    string currentDate = string.Empty;
                    string SourceDirectory = string.Empty;
                    string FileName = string.Empty;
                    string GetExxtention = string.Empty;
                    
                    currentDate = DateTime.Now.ToString("ddMMyyyy");
                    SourceDirectory = _strImagepath + "\\" + currentDate;
                    GetExxtention = Path.GetExtension(txtimagepath.Text);
                    if (!Directory.Exists(SourceDirectory))
                    {
                        Directory.CreateDirectory(SourceDirectory);
                    }

                    FileName = Path.GetFileName(txtimagepath.Text);
                    DestinationFile = SourceDirectory + "\\" + FileName;
                    if (!File.Exists(DestinationFile))
                    {
                       // DestinationFile = SourceDirectory + "\\" + FileName + "1" + GetExxtention;
                        File.Copy(txtimagepath.Text, DestinationFile);
                    }
                }

                objbo.ItemCateGory = cmbCategory.Text;
                objbo.ItemGroup = cmbItemGroup.Text;
                objbo.ItemType = cmbItemType.Text;
                objbo.ItemCode = txtItemKey.Text;
                objbo.ItemDesc = txtDescription.Text;
                objbo.ImagePath = DestinationFile;
                objbo.Location = cmbLocation.SelectedValue.ToString();
                objbo.Supplier = cmbSupplier.Text;
                objbo.Quantity = Convert.ToInt32(txtQuantity.Text);
                objbo.MOQ = Convert.ToInt32(numaricMOQ.Value);
                objbo.ProductCode = txtproductcode.Text;
                objbo.Accesslevel = Convert.ToInt32(cmbAccessLevel.SelectedValue.ToString());

                //objbo.SupplierPartNo = txtSupplierPartNo.Text;
                //objbo.LastUnitCost = txtLastUnitcost.Text;
                //objbo.LastReceiptDate = dtLastReceipt.Value;

                //return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int itemselectedCategory = 0;
                if (cmbCategory.SelectedIndex != 0)
                {
                    itemselectedCategory = Convert.ToInt32(cmbCategory.SelectedValue);
                    BindItemGroup(itemselectedCategory);
                }
                else
                {
                    BindItemGroup(itemselectedCategory);
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
            try
            {
                Clear();

                //  this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Clear()
        {
            errorProvider1.Clear();
            cmbCategory.SelectedIndex = 0;
            cmbItemGroup.SelectedIndex = 0;
            cmbDrawer.SelectedIndex = 0;
            cmbLocation.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            cmbItemType.SelectedIndex = 0;
            txtItemKey.Text = "";
            txtDescription.Text = "";
            txtproductcode.Text = "";
            txtQuantity.Text = "";
            picforItem.Image = null;
            txtimagepath.Text = "";
            numaricMOQ.ResetText();
            cmbAccessLevel.SelectedIndex = 0;
            txtaddQntity.Text = "";
        }
        public void CallbackBindFN(string ItemCategory)
        {
            try
            {
                int i = objcontroler.InsertCategory(ItemCategory, Login.UserId);
                if (i == 1)
                {
                    MessageBox.Show("Data Saved SuccessFully", this.Text);
                    BindCategory();
                }
                else
                {
                    MessageBox.Show("Inserted Fail", this.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BindGroupDeligateFN(int ItemCategoryId, string ItemNewGroup)
        {
            try
            {
                int i = objcontroler.InsertGroup(ItemCategoryId, ItemNewGroup, Login.UserId);
                if (i == 1)
                {
                    MessageBox.Show("Data Saved SuccessFully", this.Text);
                    //   int itemselectedCategory = 0;
                    // objAddItem.BindItemGroup(itemselectedCategory);
                    // cmbCategory.SelectedValue = 0;
                    // txtItemGroup.Text = "";
                    //  this.Hide();
                    BindItemGroup(ItemCategoryId);
                }
                else
                {
                    MessageBox.Show("Insert  Failed", this.Text);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddaNewItem_Load(object sender, EventArgs e)
        {
            //BindItemType();
        }
        OpenFileDialog fd1 = new OpenFileDialog();
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                fd1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";
                DialogResult dres1 = fd1.ShowDialog();
                if (dres1 == DialogResult.Abort)
                    return;
                if (dres1 == DialogResult.Cancel)
                    return;
                string absolutePath = fd1.FileName; ;
                if (File.Exists(absolutePath))
                {
                    picforItem.Image = System.Drawing.Image.FromFile(absolutePath);
                    txtimagepath.Text = fd1.FileName;
                }
                else
                {
                    picforItem.Image = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnLocation_Click(object sender, EventArgs e)
        {
            try
            {
                LocationDetails frmLocDtls = new LocationDetails();
                frmLocDtls.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        AddSupplier objsuppli = new AddSupplier();
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                objsuppli.CallbackSuplierName = new global::BindSuplier(this.BindSupplierDeligateFN);
                objsuppli.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Validations();
                if (sb != null && sb.ToString() != string.Empty)
                {
                    // MessageBox.Show(sb.ToString());
                    return;
                }
                else
                {
                    InsertItem();
                    UpdateItemDetails(objbo, ItemID);
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrawer.SelectedIndex != 0)
            {
                int DrawerId = 0;
                DrawerId = Convert.ToInt32(cmbDrawer.SelectedValue);
                BindLocatioin(DrawerId);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void txtItemKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void numaricMOQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numaricMOQ_Enter(object sender, EventArgs e)
        {
            numaricMOQ.Select();

        }

        private int CheckItemCode(string stritemcode)
        {
            int i = 0;
            try
            {

                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AddaNewItem(AddItemBo objboAdditem)
        {
            try
            {
                InitializeComponent();
                BindCategory();
                BindSuppliers();
                BindDrawer();
                ValidateExcelItemDetails(objboAdditem);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ValidateExcelItemDetails(AddItemBo objboAdditem)
        {

            try
            {
                //sb = new StringBuilder();
                //sbValidateExcelItem = new StringBuilder();
                objcontroler.CheckDataHavingInDataTableOrNot(objboAdditem, Login.UserId);
                txtItemKey.Text = objboAdditem.ItemCode;
                txtDescription.Text = objboAdditem.ItemDesc;
                txtQuantity.Text = objboAdditem.Quantity.ToString();
                //  cmbCategory.Items.Add(objboAdditem.ItemCateGory);
                cmbCategory.Text = objboAdditem.ItemCateGory;
                //  cmbItemGroup.Items.Add(objboAdditem.ItemGroup);
                cmbItemGroup.Text = objboAdditem.ItemGroup;
                // cmbLocation.Items.Add(objboAdditem.Location);
                //   cmbLocation.Text = objboAdditem.Location;
                // cmbSupplier.Items.Add(objboAdditem.Supplier);
                cmbSupplier.Text = objboAdditem.Supplier;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        ///
        #region Bind Access Level

        public void BindAccessLevel()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindAccessLevel();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select level--" };
                dt.Rows.InsertAt(dr, 0);
                cmbAccessLevel.ValueMember = "AccessLevelID";
                cmbAccessLevel.DisplayMember = "AccessLevel";
                cmbAccessLevel.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        private void btnAddNewItemType_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewItem addnewitem = new AddNewItem();
                addnewitem.CallBackItemDeligate = new global::BindNewItemDeligate(this.CallBackItemDeligateFN);
                addnewitem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAddQnty_Click(object sender, EventArgs e)
        {
            try
            {
                txtaddQntity.Visible = true;
                txtaddQntity.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtaddQntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        int ActualQuantity = 0;
        int AddedQuantity = 0;
        int TotalQuantity = 0;
        int tempQuantity = 0;

        private void txtaddQntity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ActualQuantity == 0)
                {
                    if (int.TryParse(txtQuantity.Text, out ActualQuantity))
                    {
                        tempQuantity = ActualQuantity;
                    }
                }
                if (!string.IsNullOrEmpty(txtaddQntity.Text))
                {
                    if (int.TryParse(txtaddQntity.Text, out AddedQuantity))
                    {
                        TotalQuantity = tempQuantity + AddedQuantity;
                        txtQuantity.Text = TotalQuantity.ToString();
                    }
                }
                else
                {
                    txtQuantity.Text = tempQuantity.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtItemKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
        }
        //commented by Rajkumar due to removed ZC button
        //private void btnZC_Click(object sender, EventArgs e)
        //{
        //    objPort = new SerialPort();
        //    try
        //    {
        //        string[] ArrayComPortsNames = null;
        //        string portname = string.Empty;
        //        ArrayComPortsNames = SerialPort.GetPortNames();
        //        if (ArrayComPortsNames.Length > 0)
        //        {
        //            objPort.PortName = ArrayComPortsNames[0];

        //            if (objPort != null && objPort.IsOpen)
        //            {
        //                objPort.Close();
        //            }
        //            objPort.Parity = Parity.None;
        //            objPort.StopBits = StopBits.One;
        //            objPort.DataBits = 8;
        //            objPort.Handshake = Handshake.None;
        //            objPort.RtsEnable = true;
        //            objPort.WriteTimeout = 2000;
        //            objPort.Open();
        //            // objPort.WriteLine("BIC");

        //            objPort.WriteLine("AC");
        //            Thread.Sleep(2000);
        //            objPort.WriteLine("BC");
        //            //  Thread.Sleep(2000);
        //            ////  objPort.WriteLine("BC");
        //            //  objPort.WriteLine("AC");
        //            // // objPort.WriteLine("AC");
        //        }
        //        else
        //        {
        //            MessageBox.Show("System couldn't find a cabinet.", this.Text);
        //            return;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objPort.Close();
        //    }
        //}

    }
}
