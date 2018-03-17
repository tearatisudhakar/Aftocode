using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolDataAccessLayer;
using ToolBusinessLogiclayer;
using ToolManagement;
using TooLManagementEntities;
using System.IO;


namespace ToolManagement.Controls
{
    public partial class ItemsDisplayctrl : UserControl
    {
        public ItemsDisplayctrl()
        {
            InitializeComponent();
            //GetItemsinfo();
           // Fillitemstatus();
            //lbluser.Text = "Hello " + Login.Username.ToUpper().ToString();
            //txtInput.Focus();
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //string strItemcode = string.Empty;
        //ToolDAL DAL1 = new ToolDAL();
        //AddItemBo objbo = new AddItemBo();
        //DataSet ds = null;
        //int itemId = 0;

     

        //public void GetItemsinfo()
        //{
        //    // DataGridView GvIteminfo = (DataGridView)pnlcenter.Controls.Find("GvIteminfo", true).GetValue(0);
        //    GvIteminfo.Columns.Clear();
        //    ds = new DataSet();
        //    ds = DAL1.ItemInfo();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        GvIteminfo.DataSource = ds.Tables[0];
        //       // lblpitemlocation.Text = ds.Tables[0].Rows[0]["Location"].ToString();
        //        lblpitemcode.Text = ds.Tables[0].Rows[0]["Item Code"].ToString();
        //        lblpitemdesc.Text = ds.Tables[0].Rows[0]["Item Description"].ToString();
        //        lblpcategory.Text = ds.Tables[0].Rows[0]["Item category"].ToString();
        //        lblpitemgroup.Text = ds.Tables[0].Rows[0]["Item Group"].ToString();
        //        //lblpitemtype.Text = ds.Tables[0].Rows[0]["Item Type"].ToString();
        //        lblpsupplier.Text = ds.Tables[0].Rows[0]["Supplier"].ToString();
        //        strItemcode = ds.Tables[0].Rows[0]["Item Code"].ToString();
        //        itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["Item Id"].ToString());
        //        DataSet dsImage = new DataSet();
        //        dsImage = DAL1.ItemInfo(strItemcode);
        //        if (dsImage.Tables[1].Rows.Count > 0)
        //        {
        //            string absolutePath = dsImage.Tables[1].Rows[0]["imagepath"].ToString();

        //            imgItem.Image = System.Drawing.Image.FromFile(absolutePath);

        //        }
        //    }
        //}
      

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (txtInput.Text != string.Empty)
        //    {
        //        string itemcode = txtInput.Text;
        //        DataSet ds = new DataSet();
        //        ds = DAL1.ItemInfo(itemcode);
        //        GvIteminfo.DataSource = ds.Tables[0];
        //    }
        //}

        //private void GvIteminfo_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //    {
        //        strItemcode = GvIteminfo.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        itemId = Convert.ToInt32(GvIteminfo.Rows[e.RowIndex].Cells[0].Value);

        //        DataSet ds = new DataSet();
        //        ds = DAL1.ItemInfo(strItemcode);
        //        FiilSelectedDetails(ds);
        //        if (ds.Tables[1].Rows.Count > 0)
        //        {
        //            string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();

        //            imgItem.Image = System.Drawing.Image.FromFile(absolutePath);

        //        }
        //    }
        //    //Fillitemstatus();
        //}
        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    txtInput.Text = "";
        //    GetItemsinfo();
        //}


        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //public void FilllItemDetails()
        //{


        //}

        //public void FiilSelectedDetails(DataSet ds)
        //{
        //    //   DataSet ds = new DataSet();
        //    //if (ds.Tables[0].Rows.Count > 0)
        //    //{
        //    //    txtSerialno.Text = ds.Tables[0].Rows[0]["Item Code"].ToString();
        //    //    //  txtAvailable.Text = ds.Tables[0].Rows[0]["Item Quantity"].ToString();
        //    //    txtCribLocaton.Text = ds.Tables[0].Rows[0]["Location"].ToString();
        //    //}
        //}
        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    AddaNewItem obj = new AddaNewItem();

        //    obj.CallBackToolDetailsBind = new global::BindToolDetailsDeligate(this.InsertItemDetailsFn);
        //    obj.ShowDialog();
        //}

        //public void InsertItemDetailsFn(AddItemBo objbo)
        //{
        //    try
        //    {
        //        ToolBAL objcontroler = new ToolBAL();
        //        int i = objcontroler.InsertItemDetails(objbo, Login.UserId);
        //        if (i != 0)
        //        {
        //            MessageBox.Show("Data Saved Successfully.");

        //            GetItemsinfo();
        //            // GvIteminfo();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddaNewItem objItemdetailsform = new AddaNewItem();
        //    objItemdetailsform.ShowDialog();
        //}

        //private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Supliers frmSuplier = new Supliers();
        //    frmSuplier.ShowDialog();
        //}

        //private void btnIssedItem_Click(object sender, EventArgs e)
        //{

        //    //int Available = 0;
        //    //if (txtAvailable.Text != string.Empty && txtAvailable.Text != null)
        //    //    Available = Convert.ToInt32(txtAvailable.Text);
        //    //if (Available > 0)
        //    //{
        //    //    IssueItem objissueitem = new IssueItem(strItemcode, Available);
        //    //    objissueitem.ShowDialog();
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("There is no quantity available to issue", "NO QUANTITY AVAILABLE");
        //    //}
        //}

        //private void btnReturnItem_Click(object sender, EventArgs e)
        //{
        //    //int issued = 0;
        //    //if (txtIssued.Text == string.Empty || txtIssued.Text == null)
        //    //    txtIssued.Text = "0";
        //    //else
        //    //    issued = Convert.ToInt32(txtIssued.Text);
        //    //if (issued > 0)
        //    //{
        //    //    ReturnItem returnfrm = new ReturnItem(strItemcode, issued);
        //    //    returnfrm.ShowDialog();
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Non of this item has been issued", "No Issues");
        //    //}
        //}
        //private void btnProcess_Click(object sender, EventArgs e)
        //{

        //    TransactionItemDetails FrmLog = new TransactionItemDetails(itemId);
        //    FrmLog.ShowDialog();
        //}

        //private void btnIssues_Click(object sender, EventArgs e)
        //{
        //    IssuedDetals frmissuedetail = new IssuedDetals();
        //    frmissuedetail.ShowDialog();
        //}

        //private void btnorders_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnOrderItem_Click(object sender, EventArgs e)
        //{
        //    OrderItem frmorderitem = new OrderItem();
        //    frmorderitem.ShowDialog();
        //}

        //private void btnRecive_Click(object sender, EventArgs e)
        //{
        //    Receiveorder frmRecive = new Receiveorder();
        //    frmRecive.ShowDialog();
        //}

        //private void issueListToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IssuedDetals frmissuedddtl = new IssuedDetals();
        //    frmissuedddtl.ShowDialog();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Are you sure to delete item " + itemId + " ?", "Delete Item", MessageBoxButtons.YesNoCancel);
        //    if (dr == DialogResult.Yes)
        //    {
        //        int Result = 0;
        //        Result = DAL1.ItemDelete(itemId, Login.UserId);
        //        if (Result == 1)
        //        {
        //            MessageBox.Show("Item has been removed successfully.", "Item Deleted");
        //        }
        //        GetItemsinfo();
        //    }
        //    else if (dr == DialogResult.No)
        //    {
        //        return;
        //    }
        //    else
        //        return;
        //}

        //private void itemsRemovedToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DeletedItemdetails frmdeleteditemdtls = new DeletedItemdetails();
        //    frmdeleteditemdtls.ShowDialog();
        //}

        //private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TransactionItemDetails FrmLog = new TransactionItemDetails(itemId);
        //    FrmLog.ShowDialog();
        //}

        //private void txtInput_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtInput.Text != string.Empty)
        //    {
        //        string itemcode = txtInput.Text;
        //        DataSet ds = new DataSet();
        //        ds = DAL1.ItemInfo(itemcode);
        //        GvIteminfo.DataSource = ds.Tables[0];
        //    }
        //}

        //private void toolUsersToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SystemUsers frmsyemusr = new SystemUsers();
        //    frmsyemusr.ShowDialog();
        //}

        //private void aboutToolToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    About frmabout = new About();
        //    frmabout.ShowDialog();
        //}

        //private void cribLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    LocationDetails frmLocDtls = new LocationDetails();
        //    frmLocDtls.ShowDialog();
        //}

        //private void btnChange_Click(object sender, EventArgs e)
        //{
        //    AddaNewItem obj = new AddaNewItem(strItemcode);

        //    // obj.CallBackToolDetailsBind = new global::BindToolDetailsDeligate(this.InsertItemDetailsFn);
        //    obj.ShowDialog();
        //}

        //private void GvIteminfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void createJobToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    JobCreation frmjobcreate = new JobCreation();
        //    frmjobcreate.ShowDialog();
        //}

        //private void jobInfoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    JobDetails frmjobdtls = new JobDetails();
        //    frmjobdtls.ShowDialog();
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
