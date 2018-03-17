using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToolDataAccessLayer;
using ToolBusinessLogiclayer;
using TooLManagementEntities;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ToolManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            GetItemsinfo();
            Fillitemstatus();
            txtInput.Focus();
            pnlAdvancedSearch.Visible = false;
            lnklblAdvancedSearch.Show();
            lnklblCloseAdvancedSearch.Visible = false;
            BindItemGroup();
            BindCategory();
            BindSuppliers();
            cmbSearchQty.SelectedIndex = 0;

            GvIteminfo.ReadOnly = false;
            txtSearchQuantity.Visible = false;
        }

        private string strItemcode = string.Empty;
        string strAccessLevel = string.Empty;
        int intSelectedRowId = 0;
        int intIssueRowId = 0;

        private ToolDAL DAL = new ToolDAL();
        DataSet ds = null;
        private int itemId = 0;
        private int Available = 0;
        private int _returnqnty = 0;
        ItemSearch objboItemSearch = new ItemSearch();
        ToolBAL objcontroler = new ToolBAL();

        public static string ReturnQuantity = string.Empty;

        public void GetItemsinfo()
        {
            try
            {

                GvIteminfo.Columns.Clear();
                ds = new DataSet();
                ds = DAL.ItemInfo(Login.UserId);  
                Filldata(ds);
                GvButton();
                if (GvIteminfo.Columns.Contains("Issue"))
                {
                    GvIteminfo.Columns["Issue"].ReadOnly = false;
                }

              //  GvIteminfo.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void RowSelect(string itemCode)
        {

        }

        public void Filldata(DataSet ds)
        {
            GvIteminfo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            GvIteminfo.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            GvIteminfo.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            try
            {
               
                if (ds.Tables[0].Rows.Count > 0)                
                {
                    GvIteminfo.DataSource = null;
                    GvIteminfo.DataSource = ds.Tables[0];
                    
                    if (GvIteminfo.Columns.Contains("Item Id"))
                    {
                        GvIteminfo.Columns["Item Id"].Visible = false;
                    }

                    if (GvIteminfo.Columns.Contains("Location"))
                    {
                        GvIteminfo.Columns["Location"].Visible = false;
                    }

                    if (GvIteminfo.Columns.Contains("Del"))
                    {
                        GvIteminfo.Columns["Del"].DisplayIndex = GvIteminfo.Columns.Count - 1;
                    }

                    int columnindex = GvIteminfo.Columns["Item code"].Index;
                    GvIteminfo.CurrentCell = GvIteminfo[columnindex, intSelectedRowId];
                  //  GvIteminfo.AutoResizeColumns();
                    // lblpitemlocation.Text = ds.Tables[0].Rows[0]["Location"].ToString();
                    //lblpitemcode.Text = ds.Tables[0].Rows[0]["Item Code"].ToString();
                    GvIteminfo.Columns[1].DefaultCellStyle.ForeColor = Color.CornflowerBlue;
                    //lblpitemdesc.Text = ds.Tables[0].Rows[0]["Item Description"].ToString();
                    //  lblpcategory.Text = ds.Tables[0].Rows[0]["Item SubGroup"].ToString();
                    //  lblpitemgroup.Text = ds.Tables[0].Rows[0]["Item Group"].ToString();
                    // lblpitemtype.Text = ds.Tables[0].Rows[0]["Item Type"].ToString();
                    // lblpsupplier.Text = ds.Tables[0].Rows[0]["Supplier"].ToString();

                    //strItemcode = ds.Tables[0].Rows[0]["Item Code"].ToString();
                    //itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["Item Id"].ToString());
                    //strAccessLevel = ds.Tables[0].Rows[0]["Access Level"].ToString();

                    strItemcode = ds.Tables[0].Rows[intSelectedRowId]["Item Code"].ToString();
                    itemId = Convert.ToInt32(ds.Tables[0].Rows[intSelectedRowId]["Item Id"].ToString());
                    strAccessLevel = ds.Tables[0].Rows[intSelectedRowId]["Access Level"].ToString();
                    DataSet dsImage = new DataSet();
                    dsImage = DAL.ItemInfo(strItemcode);
                    if (dsImage.Tables[1].Rows.Count > 0)
                    {
                        string absolutePath = dsImage.Tables[1].Rows[0]["imagepath"].ToString();
                        if (File.Exists(absolutePath))
                            imgItem.Image = System.Drawing.Image.FromFile(absolutePath);
                        else
                            imgItem.Image = null;
                    }
                    Fillitemstatus();
                }
                else
                {
                    imgItem.Image = null;
                    itemId = 0;
                    txtAvailable.Text = "";
                    txtIssued.Text = "";
                    txtReturn.Text = "";
                    txtCribLocaton.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void GvButton()
        {
            try
            {
                DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.HeaderText = "Issue";
                chkColumn.Name = "Issue";
                chkColumn.DataPropertyName = "Issue";
                GvIteminfo.Columns.Add(chkColumn);
                GvIteminfo.Columns["Issue"].DisplayIndex = 0;
                // GvIteminfo.Columns["Issue"].

                if (Login.IsAdmin)
                {
                    // DataGridViewButtonColumn DelColumn = new DataGridViewButtonColumn();
                    DataGridViewImageColumn DelColumn = new DataGridViewImageColumn();
                    // Bitmap img=new Bitmap("..\\Resources\\del.png");
                    Bitmap img = new Bitmap(ToolManagement.Properties.Resources.DEL);
                    DelColumn.HeaderText = "Action";
                    // DelColumn.Text = "Delete";
                    DelColumn.Name = "Del";
                    // DelColumn.UseColumnTextForButtonValue = true;
                    DelColumn.DataPropertyName = "Del";
                    DelColumn.Image = img;
                    GvIteminfo.Columns.Add(DelColumn);
                    GvIteminfo.Columns["Del"].DisplayIndex = GvIteminfo.Columns.Count - 1;
                    GvIteminfo.Columns["Del"].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void CallBackBindGrid()
        {
            GetItemsinfo();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string itemcode = string.Empty;
            DataSet ds = new DataSet();
            try
            {
                if (lnklblAdvancedSearch.Visible == true)
                {
                    if (txtInput.Text != string.Empty)
                    {
                        itemcode = txtInput.Text;
                        ds = DAL.ItemInfo(itemcode);
                        GvIteminfo.DataSource = ds.Tables[0];
                        Filldata(ds);
                    }
                }
                else
                {
                    if (cmbSearchQty.SelectedIndex > 0 && string.IsNullOrEmpty(txtSearchQuantity.Text))
                    {
                        MessageBox.Show("Please enter item quantity.");
                        return;
                    }
                    BindAdvanceSearch();
                    //ds = DAL.ItemInfo(objboItemSearch);
                    //GvIteminfo.DataSource = ds.Tables[0];
                    //Filldata(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BindAdvanceSearch()
        {
            try
            {
                intSelectedRowId = 0;
                if (txtSearchItemCode.Text != "")
                {
                    objboItemSearch.ItemCode = txtSearchItemCode.Text;
                }
                else
                {
                    objboItemSearch.ItemCode = "";
                }
                if (cmbSearchCategory.SelectedIndex != 0)
                {
                    objboItemSearch.ItemGroup = cmbSearchCategory.Text;
                }
                else
                {
                    objboItemSearch.ItemGroup = "";
                }
                if (cmbSearchGroup.SelectedIndex != 0)
                {
                    objboItemSearch.ItemSubGroup = cmbSearchGroup.Text;
                }
                else
                {
                    objboItemSearch.ItemSubGroup = "";
                }
                if (cmbSearchSupplier.SelectedIndex != 0)
                {
                    objboItemSearch.ItemSupplier = cmbSearchSupplier.Text;
                }
                else
                {
                    objboItemSearch.ItemSupplier = "";
                }
                if (cmbSearchQty.SelectedIndex != 0)
                {
                    objboItemSearch.QuantityType = cmbSearchQty.SelectedItem.ToString();
                }
                else
                {
                    objboItemSearch.QuantityType = "=";
                }
                if (txtSearchQuantity.Text != "")
                {
                    objboItemSearch.ItemQuanity = Convert.ToInt32(txtSearchQuantity.Text);
                }
                else
                {
                    objboItemSearch.ItemQuanity = 0;
                }
                ds = DAL.ItemInfo(objboItemSearch, Login.UserId);
                GvIteminfo.DataSource = ds.Tables[0];
                Filldata(ds);

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void GvIteminfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.RowIndex > -1)
                {
                    intIssueRowId = e.RowIndex;
                    if (GvIteminfo.Columns[e.ColumnIndex].Name.ToLower().ToString() != "issue".ToString())
                    {
                        if (GvIteminfo.Rows.Count > 0)
                        {                           
                            foreach (DataGridViewRow dr in GvIteminfo.Rows)
                            {
                                if (dr.Cells["issue"].Value != null && (bool)(dr.Cells["issue"].Value))
                                {
                                    dr.Cells["issue"].Value = false;
                                   // GvIteminfo.Rows[e.RowIndex].DefaultCellStyle.BackColor = 
                                }
                            }
                        }
                        GvIteminfo.ReadOnly = true;
                        GvIteminfo.Rows[e.RowIndex].Cells["Issue"].Value = true;
                        GvIteminfo.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        GvIteminfo.ReadOnly = false;
                        GvIteminfo.Rows[e.RowIndex].Cells["Issue"].Value = true;
                        GvIteminfo.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        
                        //GvIteminfo.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    }


                    if (GvIteminfo.Columns[e.ColumnIndex].Name == "Del")
                    {
                        Available = Convert.ToInt32(GvIteminfo.Rows[e.RowIndex].Cells["Item quantity"].Value);
                        strItemcode = GvIteminfo.Rows[e.RowIndex].Cells["Item code"].Value.ToString();
                        itemId = Convert.ToInt32(GvIteminfo.Rows[e.RowIndex].Cells["Item id"].Value);
                        Delete();
                    }
                    else
                    {
                        strItemcode = GvIteminfo.Rows[e.RowIndex].Cells["Item code"].Value.ToString();
                        itemId = Convert.ToInt32(GvIteminfo.Rows[e.RowIndex].Cells["Item id"].Value);

                        DataSet ds = new DataSet();
                        ds = DAL.ItemInfo(strItemcode);
                        FiilSelectedDetails(ds);
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            strAccessLevel = ds.Tables[0].Rows[0]["Access level"].ToString();
                            string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
                            if (File.Exists(absolutePath))
                            {
                                imgItem.Image = System.Drawing.Image.FromFile(absolutePath);
                            }
                            else
                            {
                                imgItem.Image = null;
                            }
                        }
                        else
                        {
                            imgItem.Image = null;
                        }
                    }
                }
                Fillitemstatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearchItemCode.Text = "";
                cmbSearchGroup.SelectedIndex = 0;
                cmbSearchQty.SelectedIndex = 0;
                cmbSearchCategory.SelectedIndex = 0;
                cmbSearchSupplier.SelectedIndex = 0;
                txtSearchQuantity.Text = "";
                txtInput.Text = "";
                intSelectedRowId = 0;
                GetItemsinfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void FilllItemDetails()
        {

        }

        public void FiilSelectedDetails(DataSet ds)
        {
            //   DataSet ds = new DataSet();
            if (ds.Tables[0].Rows.Count > 0)
            {
                // txtSerialno.Text = ds.Tables[0].Rows[0]["Item Code"].ToString();
                //  txtAvailable.Text = ds.Tables[0].Rows[0]["Item Quantity"].ToString();
                // txtCribLocaton.Text = ds.Tables[0].Rows[0]["Location"].ToString();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                AddaNewItem obj = new AddaNewItem();
                //   obj.CallBackToolDetailsBind = new global::BindToolDetailsDeligate(this.InsertItemDetailsFn);
                obj.ShowDialog();
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

                int i = objcontroler.InsertItemDetails(objbo, Login.UserId);
                if (i != 0)
                {
                    var massage = "Data Saved Successfully.";
                    MessageBox.Show(massage);

                    GetItemsinfo();
                    // GvIteminfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddaNewItem objItemdetailsform = new AddaNewItem();
                objItemdetailsform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Supliers frmSuplier = new Supliers();
                frmSuplier.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnIssedItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = null;
            if (GvIteminfo.Rows.Count > 0)
            {
                sb = new StringBuilder();
                foreach (DataGridViewRow dr in GvIteminfo.Rows)
                {
                    if (dr.Cells["issue"].Value != null && (bool) (dr.Cells["issue"].Value))
                    {
                        if (sb.ToString() == string.Empty)
                        {
                            sb.Append(dr.Cells["Item Id"].Value);
                        }
                        else
                        {
                            sb.Append("," + dr.Cells["Item Id"].Value);
                        }
                    }
                }
            }
            try
            {
                if (sb != null)
                {
                    if (!string.IsNullOrEmpty(sb.ToString()))
                    {
                        //MessageBox.Show(sb.ToString());

                        if (Login.Accesslevel.Contains(strAccessLevel))
                        {
                            if (!string.IsNullOrEmpty(txtAvailable.Text))
                            {
                                Available = Convert.ToInt32(txtAvailable.Text);
                            }

                            if (!string.IsNullOrEmpty(txtReturn.Text))
                            {
                                if (int.TryParse(txtReturn.Text, out _returnqnty)) ;

                            }

                            if (Available > 0 || _returnqnty > 0)
                            {
                                IssueItem objissueitem = new IssueItem(strItemcode, Available, sb);
                                objissueitem.CallBackItemGrid = new global::BindItemsGrid(this.CallBackBindGrid);
                                objissueitem.ShowDialog();
                                //  GetItemsinfo();
                                intSelectedRowId = intIssueRowId;
                            }
                            else
                            {
                                MessageBox.Show("There is no quantity available to issue", "NO QUANTITY AVAILABLE");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You don't have access level.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select atleast one item.");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Please select atleast one item.");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            try
            {
                int issued = 0;
                if (string.IsNullOrEmpty(txtIssued.Text))
                    txtIssued.Text = "0";
                else
                    issued = Convert.ToInt32(txtIssued.Text);
                if (issued > 0)
                {
                    intSelectedRowId = intIssueRowId;
                    ReturnItem returnfrm = new ReturnItem(strItemcode, issued);
                    returnfrm.CallBackItemGrid = new global::BindReturnItemsGrid(this.CallBackBindGrid);
                    returnfrm.ShowDialog();
                    
                }
                else
                {
                    var dialogResult = MessageBox.Show("Non of this item has been issued", "No Issues");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemId > 0)
                {
                    TransactionItemDetails FrmLog = new TransactionItemDetails(itemId);
                    FrmLog.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            try
            {
                IssuedDetals frmissuedetail = new IssuedDetals();
                frmissuedetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                //OrderItem frmorderitem = new OrderItem();
                //frmorderitem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRecive_Click(object sender, EventArgs e)
        {
            try
            {
                //Receiveorder frmRecive = new Receiveorder();
                //frmRecive.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void Fillitemstatus()
        {
            try
            {
                
                txtAvailable.Text = "";
                txtIssued.Text = "";
                //txtOnorder.Text = "";
                //txtTotalinInventory.Text = "";
                DataSet ds = new DataSet();

                ds = DAL.ItemStatus(itemId);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtAvailable.Text = ds.Tables[0].Rows[0]["Available"].ToString();
                        txtIssued.Text = ds.Tables[0].Rows[0]["Issued"].ToString();
                        txtReturn.Text = ds.Tables[0].Rows[0]["ReturnItems"].ToString();
                        ReturnQuantity = txtReturn.Text;
                        // txtOnorder.Text = ds.Tables[0].Rows[0]["OnOrder"].ToString();
                        //txtTotalinInventory.Text = ds.Tables[0].Rows[0]["TotalInInventory"].ToString();

                    }
                }
                if (ds.Tables.Count > 1)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtCribLocaton.Text = ds.Tables[1].Rows[0]["Location"].ToString();
                        //lblpitemlocation.Text = ds.Tables[1].Rows[0]["Location"].ToString();
                        //lblpitemcode.Text = ds.Tables[1].Rows[0]["Item Code"].ToString();
                        //lblpitemdesc.Text = ds.Tables[1].Rows[0]["Item Description"].ToString();
                        //lblpcategory.Text = ds.Tables[1].Rows[0]["Item SubGroup"].ToString();
                        //lblpitemgroup.Text = ds.Tables[1].Rows[0]["Item Group"].ToString();
                        ////lblpitemtype.Text = ds.Tables[1].Rows[0]["Item Type"].ToString();
                        //lblpsupplier.Text = ds.Tables[1].Rows[0]["Supplier"].ToString();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void issueListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IssuedDetals frmissuedddtl = new IssuedDetals();
                frmissuedddtl.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete item " + itemId + " ?", "Delete Item", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    int result = 0;
                    result = DAL.ItemDelete(itemId, Login.UserId);
                    if (result == 1)
                    {
                        MessageBox.Show("Item has been removed successfully.", "Item Deleted");
                    }
                    GetItemsinfo();
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void itemsRemovedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeletedItemdetails frmdeleteditemdtls = new DeletedItemdetails();
                frmdeleteditemdtls.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionItemDetails FrmLog = new TransactionItemDetails(itemId);
                FrmLog.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            intSelectedRowId = 0;
            try
            {
                if (txtInput.Text != string.Empty)
                {
                    string itemcode = txtInput.Text;
                    DataSet ds = new DataSet();
                    ds = DAL.ItemInfo(itemcode);
                    GvIteminfo.DataSource = ds.Tables[0];

                    Filldata(ds);
                }
                else
                {
                    GetItemsinfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void aboutToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                About frmabout = new About();
                frmabout.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cribLocationsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                AddaNewItem obj = new AddaNewItem(strItemcode, itemId);
                // obj.CallBackToolDetailsBind = new global::BindToolDetailsDeligate(this.InsertItemDetailsFn);
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void createJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                JobCreation frmjobcreate = new JobCreation();
                frmjobcreate.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void jobInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                JobDetails frmjobdtls = new JobDetails();
                frmjobdtls.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Commented by Rajkumar due to key up and down functionality implemented.
        //private void GvIteminfo_RowLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (e.RowIndex > -1)
        //        {
        //            strItemcode = GvIteminfo.Rows[e.RowIndex].Cells["Item Code"].Value.ToString();
        //            itemId = Convert.ToInt32(GvIteminfo.Rows[e.RowIndex].Cells["Item Id"].Value);

        //            DataSet ds = new DataSet();
        //            ds = DAL.ItemInfo(strItemcode);
        //            FiilSelectedDetails(ds);
        //            if (ds.Tables[1].Rows.Count > 0)
        //            {
        //                string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
        //                if (File.Exists(absolutePath))
        //                    imgItem.Image = System.Drawing.Image.FromFile(absolutePath);
        //                else
        //                    imgItem.Image = null;

        //            }
        //        }
        //        Fillitemstatus();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        private void GvIteminfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                intSelectedRowId = e.RowIndex;
                if (e.RowIndex > -1)
                {
                    if (GvIteminfo.Columns[e.ColumnIndex].Name != "Del" && GvIteminfo.Columns[e.ColumnIndex].Name != "Issue")
                    {
                        int columnindex = GvIteminfo.Columns["Item code"].Index;
                        AddaNewItem obj = new AddaNewItem(strItemcode, itemId);
                        obj.CallBackToolDetailsBind = new global::BindToolDetailsDeligate(this.GetItemsinfo);
                        obj.ShowDialog();
                        GvIteminfo.CurrentCell = GvIteminfo[columnindex, intSelectedRowId];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Added by Ajay 10/08/2017 Start
        #region AdvancedSearch
        public void BindCategory()
        {
            try
            {
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindSubGroup();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Category--" };
                dt.Rows.InsertAt(dr, 0);
                cmbSearchCategory.ValueMember = "ItemCategoryId";
                cmbSearchCategory.DisplayMember = "ItemCategory";
                cmbSearchCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void BindItemGroup()
        {
            try
            {
                int itemselectedCategory = 0;
                DataRow dr;
                DataTable dt = new DataTable();
                dt = objcontroler.BindItemGroup(itemselectedCategory);
                dr = dt.NewRow();
                dr.ItemArray = new object[] { "--Select Group--",0 };
                dt.Rows.InsertAt(dr, 0);
                cmbSearchGroup.ValueMember = "ItemGroupId";
                cmbSearchGroup.DisplayMember = "ItemGroup";
                cmbSearchGroup.DataSource = dt;
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
                cmbSearchSupplier.ValueMember = "SupplierId";
                cmbSearchSupplier.DisplayMember = "Company";
                cmbSearchSupplier.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lnklblCloseAdvancedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                pnlAdvancedSearch.Visible = false;
                lnklblAdvancedSearch.Visible = true;
                lnklblCloseAdvancedSearch.Visible = false;
                txtInput.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lnklblAdvancedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                pnlAdvancedSearch.Visible = true;
                lnklblAdvancedSearch.Hide();
                lnklblCloseAdvancedSearch.Visible = true;
                txtInput.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Added by Ajay 10/08/2017 End
        #endregion

        private void txtSearchQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtSearchItemCode_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchItemCode_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTime dt = new DateTime();
                string fileName = DateTime.Now.Ticks.ToString();
                fileName = "ItemInfo" + fileName;
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("D:\\Tool\\" + fileName + ".pdf", FileMode.Create));
                //PdfWriter.GetInstance(document, new FileStream);
                //  PdfWriter.GetInstance(document, new FileStream("D:\\Tool", FileMode.Open));
                document.Open();

                PdfPTable table = new PdfPTable(ds.Tables[0].Columns.Count);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(ds.Tables[0].Rows[i][j].ToString()));
                    }
                }
                document.Add(table);

                document.Close();


            }
            catch (DocumentException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbSearchGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbSearchSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbSearchQty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchQty.SelectedIndex > 0)
                {
                    txtSearchQuantity.Visible = true;
                }
                else
                {
                    txtSearchQuantity.Visible = false;
                }

                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSearchQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSearchItemCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindAdvanceSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnitemDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void Delete()
        {
            try
            {
                int result = 0;
              //  Available = Convert.ToInt32(txtAvailable.Text);
                if (itemId > 0)
                {

                    if (MessageBox.Show("Are you sure you want to delete " + strItemcode + " item ?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Available > 0)
                        {
                            MessageBox.Show("Please check this item having " + Available + " quantity.");
                            return;
                        }
                        else
                        {
                            result = DAL.ItemDelete(itemId, Login.UserId);
                            if (result > 0)
                            {
                                MessageBox.Show("Item deleted successfully.");
                                GetItemsinfo();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (GvIteminfo != null)
            {
                if (GvIteminfo.Rows.Count > 0)
                {
                    ExportToExcel();
                }
            }
        }

        /// <summary> 
        /// Exports the datagridview values to Excel. 
        /// </summary> 
        private void ExportToExcel()
        {
            try
            {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;


              //  ExcelPackage obj;
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

               // worksheet.Cells[3, 5].Value = "AFTOMAT";
                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i <GvIteminfo.Rows.Count ; i++)
                {
                    for (int j = 0; j <GvIteminfo.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            if (GvIteminfo.Columns[j].HeaderText!="Issue"&&GvIteminfo.Columns[j].HeaderText!="Action")
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = GvIteminfo.Columns[j].HeaderText;
                                worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = GvIteminfo.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        else
                        {
                            if (GvIteminfo.Columns[j].HeaderText != "Issue" && GvIteminfo.Columns[j].HeaderText != "Action")
                            {
                                if (!string.IsNullOrEmpty(GvIteminfo.Rows[i].Cells[j].ToString()))
                                {
                                    worksheet.Cells[cellRowIndex, cellColumnIndex] = GvIteminfo.Rows[i].Cells[j].Value.ToString();
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GvIteminfo_KeyDown(object sender, KeyEventArgs e)  
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                moveUp();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                moveDown();
            }
            Fillitemstatus();
           // e.Handled = true;
        }
        private void moveUp()
        {
            try
            {
                if (GvIteminfo.RowCount > 0)
                {
                    if (GvIteminfo.SelectedRows.Count > 0)
                    {
                        int rowCount = GvIteminfo.Rows.Count;
                        int index = GvIteminfo.SelectedCells[0].OwningRow.Index;

                        if (index == 0)
                        {
                            return;
                        }
                        if (index < rowCount)
                        {
                            index = index - 1;
                        }
                        strItemcode = GvIteminfo.Rows[index].Cells["Item code"].Value.ToString();
                        itemId = Convert.ToInt32(GvIteminfo.Rows[index].Cells["Item id"].Value);

                        DataSet ds = new DataSet();
                        ds = DAL.ItemInfo(strItemcode);
                        FiilSelectedDetails(ds);
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            strAccessLevel = ds.Tables[0].Rows[0]["Access level"].ToString();
                            string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
                            if (File.Exists(absolutePath))
                            {
                                imgItem.Image = System.Drawing.Image.FromFile(absolutePath);
                            }
                            else
                            {
                                imgItem.Image = null;
                            }
                        }
                        else
                        {
                            imgItem.Image = null;
                        }
                    }
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void moveDown() 
        {
            try
            {
                if (GvIteminfo.RowCount > 0)
                {
                    if (GvIteminfo.SelectedRows.Count > 0)
                    {
                        int rowCount = GvIteminfo.Rows.Count;
                        int index = GvIteminfo.SelectedCells[0].OwningRow.Index;

                        if (index == (rowCount - 1)) // include the header row
                        {
                            return;
                        }
                        if (index < rowCount && index != rowCount-1)
                        {
                            index = index + 1;
                        }
                        strItemcode = GvIteminfo.Rows[index].Cells["Item code"].Value.ToString();
                        itemId = Convert.ToInt32(GvIteminfo.Rows[index].Cells["Item id"].Value);

                        DataSet ds = new DataSet();
                        ds = DAL.ItemInfo(strItemcode);
                        FiilSelectedDetails(ds);
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            strAccessLevel = ds.Tables[0].Rows[0]["Access level"].ToString();
                            string absolutePath = ds.Tables[1].Rows[0]["imagepath"].ToString();
                            if (File.Exists(absolutePath))
                            {
                                imgItem.Image = System.Drawing.Image.FromFile(absolutePath);
                            }
                            else
                            {
                                imgItem.Image = null;
                            }
                        }
                        else
                        {
                            imgItem.Image = null;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}