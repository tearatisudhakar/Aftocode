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

//public delegate void BindToolDetailsDeligate(AddItemBo objbo);

namespace ToolManagement.Controls
{

    public partial class Addnewitemctrl : UserControl
    {

        public Addnewitemctrl()
        {
          
            try
            {
                InitializeComponent();
                //BindCategory();
                //BindSuppliers();
                //BindLocatioin();
                //btnOk.Visible = true;
                //btnUpdate.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        //public Addnewitemctrl(string Itemcode)
        //{
        //    try
        //    {
        //        InitializeComponent();
        //        BindCategory();
        //        BindSuppliers();
        //        BindLocatioin();
        //        btnUpdate.Visible = true;
        //        DataSet dset = new DataSet();
        //        //ds = objcontroler.ItemInfo(itemcode);
        //       dset = objcontroler.ItemInfo(Itemcode);
        //        if (dset.Tables[0].Rows.Count > 0)
        //        {
        //            cmbCategory.Text = dset.Tables[0].Rows[0]["Item category"].ToString();
        //            cmbItemGroup.Text = dset.Tables[0].Rows[0]["Item Group"].ToString();                  
        //            txtItemKey.Text = dset.Tables[0].Rows[0]["Item Code"].ToString();
        //            txtDescription.Text = dset.Tables[0].Rows[0]["Item Description"].ToString();
        //            cmbLocation.Text = dset.Tables[0].Rows[0]["Location"].ToString();
        //            cmbSupplier.Text = dset.Tables[0].Rows[0]["Supplier"].ToString();
        //            txtQuantity.Text = dset.Tables[0].Rows[0]["Item Quantity"].ToString();
        //        }
        //        if (dset.Tables.Count > 1)
        //        {
        //            if (dset.Tables[1].Rows.Count > 0)
        //            {
        //                string absolutePath = dset.Tables[1].Rows[0]["imagepath"].ToString();

        //                picforItem.Image = System.Drawing.Image.FromFile(absolutePath);

        //            }
        //        }
               
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        //ToolBAL objcontroler = new ToolBAL();
        //AddItemBo objbo = new AddItemBo();
        //DataTable dt = null;
        //public BindToolDetailsDeligate CallBackToolDetailsBind;
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //}
        //private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbCategory.SelectedIndex != 0)
        //        {
        //            int itemselectedCategory = 0;
        //            itemselectedCategory = Convert.ToInt32(cmbCategory.SelectedValue);
        //            BindItemGroup(itemselectedCategory);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
      //  private void cmbItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbItemGroup.SelectedIndex != 0)
        //    {
        //        if (cmbItemGroup.SelectedIndex != 0)
        //        {
        //            int itemselectedgrooup = Convert.ToInt32(cmbItemGroup.SelectedValue);
        //            BindItemType(itemselectedgrooup);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please Select Group");
        //        }
        //    }
        //}
        //private void cmbItemGroup_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddCategory itemcategory = new AddCategory();
        //        itemcategory.CallbackCategoryName = new global::BindCategory(this.CallbackBindFN);
        //        itemcategory.ShowDialog();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void btnAddNewItemGroup_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddItemGroup additemgroup = new AddItemGroup();
        //        // itemcategory.CallbackCategoryName = new global::BindCategory(this.CallbackBindFN);
        //        additemgroup.CallBackGroupDeligate = new global::BindGroupDeligate(this.BindGroupDeligateFN);
        //        additemgroup.ShowDialog();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //public void InsertItem()
        //{
        //    try
        //    {
        //        objbo.ItemCateGory = cmbCategory.Text;
        //        objbo.ItemGroup = cmbItemGroup.Text;

        //        //objbo.ItemType = cmbItemType.Text;
        //        objbo.ItemCode = txtItemKey.Text;
        //        objbo.ItemDesc = txtDescription.Text;
        //        objbo.ImagePath = txtimagepath.Text;
        //        objbo.Location = cmbLocation.Text;
        //        objbo.Supplier = cmbSupplier.Text;
        //        objbo.Quantity = Convert.ToInt32(txtQuantity.Text);
        //        //objbo.SupplierPartNo = txtSupplierPartNo.Text;
        //        //objbo.LastUnitCost = txtLastUnitcost.Text;
        //        //objbo.LastReceiptDate = dtLastReceipt.Value;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public void CallBackItemDeligateFN(int itemGroupId, string itemtype)
        //{
        //    try
        //    {
        //        int i = objcontroler.InsertItemType(itemGroupId, itemtype, Login.UserId);

        //        if (i == 1)
        //        {
        //            MessageBox.Show("Data Saved Successfully.");
        //            // int itemselectedgrooup = 0;
        //            BindItemType(itemGroupId);
        //            //   objAddItem.BindItemType(itemselectedgrooup);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Data Insertion Failed.");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void BindLocatioin()
        //{
        //    try
        //    {
        //        DataRow dr;
        //        DataTable dt = new DataTable();
        //        dt = objcontroler.BindLocation();
        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Select Location--" };
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbLocation.ValueMember = "LocationID";
        //        cmbLocation.DisplayMember = "LocationName";
        //        cmbLocation.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}
        //public void BindSupplierDeligateFN(AddSupplierBo objSuplierBo)
        //{
        //    int i = objcontroler.InsertSupplier(objSuplierBo, Login.UserId);
        //    if (i == 1)
        //    {
        //        MessageBox.Show("Data Saved SuccessFully");
        //        objsuppli.Hide();
        //        BindSuppliers();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Inserted Fail");
        //    }
        //}
        //public void BindCategory()
        //{
        //    try
        //    {
        //        DataRow dr;
        //        //cmbCategory.Items.Clear();
        //        //   cmbCategory.DataSource = null;
        //        dt = new DataTable();
        //        dt = objcontroler.BindCategory();
        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Select Category--" };
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbCategory.ValueMember = "ItemCategoryId";
        //        cmbCategory.DisplayMember = "ItemCategory";
        //        cmbCategory.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        ///// <summary> 
        ///// This Method Is Bind Item Groups
        ///// </summary>
        /////
        //public void BindItemGroup(int itemselectedCategory)
        //{
        //    try
        //    {
        //        //  int value = Convert.ToInt32(cmbCategory.SelectedValue.ToString());
        //        if (itemselectedCategory == 0)
        //        {
        //            itemselectedCategory = 0;
        //        }

        //        DataRow dr;
        //        DataTable dt = new DataTable();
        //        dt = objcontroler.BindItemGroup(itemselectedCategory);
        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Select Group--" };
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbItemGroup.ValueMember = "ItemGroupId";
        //        cmbItemGroup.DisplayMember = "ItemGroup";
        //        cmbItemGroup.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        ///// <summary> 
        ///// This Method Is BindItemTypes
        ///// </summary>
        /////
        //public void BindItemType(int itemselectedgrooup)
        //{
        //    try
        //    {
        //        DataRow dr;
        //        DataTable dt = new DataTable();
        //        dt = objcontroler.BindItemType(itemselectedgrooup);
        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Select Type--" };
        //        dt.Rows.InsertAt(dr, 0);
        //        //cmbItemType.ValueMember = "ItemTypeId";
        //        //cmbItemType.DisplayMember = "ItemType";
        //        //cmbItemType.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        /////  /// <summary> 
        ///// This Method Is BindSuppliers
        ///// </summary>
        /////
        //public void BindSuppliers()
        //{
        //    try
        //    {
        //        DataRow dr;
        //        DataTable dt = new DataTable();
        //        dt = objcontroler.BindSupplier();
        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Select Type--" };
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbSupplier.ValueMember = "SupplierId";
        //        cmbSupplier.DisplayMember = "SupplierName";
        //        cmbSupplier.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}
        /////  /// <summary> 
        /////  Clear Seleced Feailds 
        ///// </summary>
        ///// 
        //public void ClearFealds()
        //{
        //    try
        //    {
        //        //txtItemKey.Clear();
        //        //txtItemCode.Text = "";
        //        //txtItemDesc.Text = "";
        //        //cmbItemType.SelectedValue = "";
        //        //txtBarcode.Text = "";
        //        //cmbItemGroup.SelectedIndex = 0;
        //        //cmbCategory.SelectedIndex = 0;
        //        //txtSupplier.Text = "";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        //private void cmbItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbItemGroup.SelectedIndex != 0)
        //    {
        //        if (cmbItemGroup.SelectedIndex != 0)
        //        {
        //            int itemselectedgrooup = Convert.ToInt32(cmbItemGroup.SelectedValue);
        //            BindItemType(itemselectedgrooup);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please Select Group");
        //        }
        //    }
        //}
        ////private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        ////{
        ////    try
        ////    {
        ////        if (cmbCategory.SelectedIndex != 0)
        ////        {
        ////            int itemselectedCategory = 0;
        ////            itemselectedCategory = Convert.ToInt32(cmbCategory.SelectedValue);
        ////            BindItemGroup(itemselectedCategory);
        ////        }
        ////    }
        ////    catch (Exception)
        ////    {

        ////        throw;
        ////    }
        ////}
        //private void btnLocation_Click(object sender, EventArgs e)
        //{
        //    LocationDetails frmLocDtls = new LocationDetails();
        //    frmLocDtls.ShowDialog();
        //}
        //AddSupplier objsuppli = new AddSupplier();
        //private void btnSupplier_Click(object sender, EventArgs e)
        //{
        //    objsuppli.CallbackSuplierName = new global::BindSuplier(this.BindSupplierDeligateFN);

        //    objsuppli.ShowDialog();
        //}
        //public void CallbackBindFN(string ItemCategory)
        //{
        //    try
        //    {
        //        int i = objcontroler.InsertCategory(ItemCategory, Login.UserId);
        //        if (i == 1)
        //        {
        //            MessageBox.Show("Data Saved SuccessFully");
        //            BindCategory();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Inserted Fail");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //public void BindGroupDeligateFN(int ItemCategoryId, string ItemNewGroup)
        //{
        //    try
        //    {
        //        int i = objcontroler.InsertGroup(ItemCategoryId, ItemNewGroup, Login.UserId);
        //        if (i == 1)
        //        {
        //            MessageBox.Show("Data Saved SuccessFully");
        //            //   int itemselectedCategory = 0;
        //            // objAddItem.BindItemGroup(itemselectedCategory);
        //            // cmbCategory.SelectedValue = 0;
        //            // txtItemGroup.Text = "";
        //            //  this.Hide();
        //            BindItemGroup(ItemCategoryId);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Insert  Failed");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void AddNewItem_Load(object sender, EventArgs e)
        //{
        //    // BindItemType();
        //}
        //OpenFileDialog fd1 = new OpenFileDialog();
        //private void btnbrowse_Click(object sender, EventArgs e)
        //{
        //    fd1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";

        //    DialogResult dres1 = fd1.ShowDialog();

        //    if (dres1 == DialogResult.Abort)

        //        return;

        //    if (dres1 == DialogResult.Cancel)
        //        return;
        //    string absolutePath = fd1.FileName; ;
        //    picforItem.Image = System.Drawing.Image.FromFile(absolutePath);
        //    txtimagepath.Text = fd1.FileName;
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
    }
}
