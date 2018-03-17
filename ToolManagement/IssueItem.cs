using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Configuration;
using ToolBusinessLogiclayer;
using ToolDataAccessLayer;

public delegate void BindItemsGrid();

namespace ToolManagement
{
    public partial class IssueItem : Form
    {
        int AvailableQnty = 0;
        string Drawer = string.Empty;
        string strDrawer = string.Empty;
        int intIsCabinet = Convert.ToInt32(ConfigurationSettings.AppSettings["IsConnectedToCabinet"].ToString());
        bool IsCabinet = true;
        public IssueItem(string Itemcode, int Qnt ,StringBuilder sb)
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            btnSave.Visible = true;
           // btnZC.Visible = false;

            touchScreen1.OnUserControlButtonClicked += new Controls.TouchScreen.ButtonClickedEventHandler(touchScreen1_OnUserControlButtonClicked);
            KeyPad.SendKeyvalue += new KeyPad.Keypressedhandler(GetKeyvalue);
            FillItemissue(Itemcode);
            AvailableQnty = Qnt;
            txtAvailableQnty.Text = Qnt.ToString();
            txtUserid.Text = Convert.ToString(Login.UserId);
            txtusername.Text = Login.Username;
            txtReturn.Text = Home.ReturnQuantity.ToString();
            BindJob();

            if (intIsCabinet == 1)
            {
                IsCabinet = true;
            }
            else if(intIsCabinet == 0)
            {
                IsCabinet = false;
            }
            if (sb!=null)
            {
                FillIssuedKit(sb);
            }
            // BindToolUser();
        }
        ToolDAL DAL = new ToolDAL();
        SerialPort objPort;
        string strCategory = string.Empty;
        string strGroup = string.Empty;
        string strItemtype = string.Empty;
        string strDescription = string.Empty;
        string strItemcode = string.Empty;
        int itemId = 0;
        string KitItemCode = string.Empty;
        bool Isissue = false;

        public BindItemsGrid CallBackItemGrid;
        public void FillItemissue(string Itemcode)
        {
            try
            {
                
                DataSet ds = new DataSet();
                ds = DAL.ItemInfo(Itemcode);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    strCategory = ds.Tables[0].Rows[0]["Item Category"].ToString();
                    strGroup = ds.Tables[0].Rows[0]["Item Group"].ToString();
                    strItemtype = ds.Tables[0].Rows[0]["Item Type"].ToString();
                    strItemcode = ds.Tables[0].Rows[0]["Item Code"].ToString();
                    strDescription = ds.Tables[0].Rows[0]["Item Description"].ToString();
                    itemId = Convert.ToInt32(ds.Tables[0].Rows[0]["Item id"].ToString());
                    txtIndex.Text = strGroup + " , " + strCategory;
                    txtDesc.Text = strDescription;
                    txtItemCode.Text = strItemcode;
                    txtlocation.Text = ds.Tables[0].Rows[0]["Location"].ToString();
                   

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
        public void GetKeyvalue(string Key)
        {
            if (Key.ToString() == "{BACKSPACE}")
            {

                //wRITE BACKSPACE CODE
            }
            else
            {
                txtItemCode.Text += Key;
            }
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gvIssueItems.Rows.Count > 0)
            {
              Isissue=  Issue();
                if (Isissue)
                {
                    if (gvIssueItems.Rows.Count == 1)
                    {
                        btnSave.Visible = true;
                        btnIssueNext.Visible = false;
                      //  btnZC.Visible = true;
                       
                    }
                    DataGridViewRow row = gvIssueItems.SelectedRows[0];
                    gvIssueItems.Rows.Remove(row);
                   
                }
                else
                {
                     return;
                }
                if (gvIssueItems.Rows.Count > 0)
                {
                    if (gvIssueItems.Rows.Count == 1)
                    {
                        btnSave.Visible = true;
                        btnIssueNext.Visible = false;
                       // btnZC.Visible = true;
                    }
                    else
                    {
                        btnSave.Visible = false;
                        btnIssueNext.Visible = true;
                    }
                    KitItemCode = gvIssueItems.Rows[0].Cells["Item code"].Value.ToString();
                    itemId = Convert.ToInt32(gvIssueItems.Rows[0].Cells["Item id"].Value);
                    FillItemissue(KitItemCode);
                    ItemStatus();
                }
                else
                {
                    this.Hide();
                    CallBackItemGrid();
                }

            }
        }
        private bool Issue()
        {
            Isissue = true;
            int NewQuantity = 0;
            int UsedQuantity = 0;
            int intReturnQuantity = 0;
            try
            {
                //if (AvailableQnty > 0)
                {
                    if (cmbjob.SelectedIndex != 0)
                    {
                        //int issueQnt = 0;
                        //issueQnt = Convert.ToInt32(numericUpDown1.Value);
                        int Jobid = Convert.ToInt32(cmbjob.SelectedValue);
                        intReturnQuantity = Convert.ToInt32(Home.ReturnQuantity);
                        if (string.IsNullOrEmpty(txtUsed.Text) && string.IsNullOrEmpty(txtNew.Text))
                        {
                            MessageBox.Show("Please select Item type atleast one.");
                            Isissue = false;
                            return Isissue;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txtUsed.Text))
                            {
                                int.TryParse(txtUsed.Text, out UsedQuantity);
                                if (UsedQuantity <= 0)
                                {
                                    MessageBox.Show("Used Item quantity should be more than zero", "QUANTITY INVALID");
                                    Isissue = false;
                                    return Isissue;
                                }
                            }
                            if (!string.IsNullOrEmpty(txtNew.Text))
                            {
                                int.TryParse(txtNew.Text, out NewQuantity);
                                if (NewQuantity<=0)
                                {
                                    MessageBox.Show("New Item quantity should be more than zero", "QUANTITY INVALID");
                                    Isissue = false;
                                    return Isissue;
                                    
                                }
                            }
                            if (NewQuantity <= AvailableQnty)
                            {

                            }
                            else
                            {
                               // MessageBox.Show("New Item quantity specified is more than " + AvailableQnty + "", "QUANTITY INVALID");
                                MessageBox.Show("New item quantity specified is more than available item quantity.", "QUANTITY INVALID");
                                Isissue = false;
                                return Isissue;

                            }
                            if (UsedQuantity <= intReturnQuantity)
                            {

                            }
                            else
                            {
                               // MessageBox.Show("Used Item quantity specified is more than " + intReturnQuantity + "", "QUANTITY INVALID");
                                MessageBox.Show("Used item quantity specified is more than available used items.", "QUANTITY INVALID");
                                Isissue = false;
                                return Isissue;
                            }
                           
                            if (MessageBox.Show("Are you sure " + strItemcode + " item issue ?", "Confirm Issue", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                                            if (!string.IsNullOrEmpty(txtlocation.Text))
                                            {
                                                strDrawer = txtlocation.Text;
                                                if (strDrawer.Length > 1)
                                                {
                                                    strDrawer = strDrawer.Substring(0, 1);
                                                }
                                                if (string.IsNullOrEmpty(Drawer))
                                                {
                                                    Drawer = strDrawer;
                                                }
                                            }
                                            if (!string.IsNullOrEmpty(Drawer))
                                            {
                                                if (strDrawer != Drawer)
                                                {
                                                    string DrawerClose = string.Empty;
                                                    DrawerClose = Drawer + "C";
                                                    MessageBox.Show(DrawerClose);
                                                    // objPort.WriteLine(DrawerClose.ToUpper());
                                                    Drawer = string.Empty;
                                                }
                                            }

                                            Thread.Sleep(2000);
                                            objPort.WriteLine(txtlocation.Text);

                                            int AvlQnt = AvailableQnty - NewQuantity;
                                            int rtnQnty = intReturnQuantity - UsedQuantity;
                                            DAL.ItemIssue(NewQuantity, Login.UserId, itemId, AvlQnt, Jobid, UsedQuantity, rtnQnty);
                                            MessageBox.Show("Item issued successfully.");
                                        }

                                        else
                                        {
                                            MessageBox.Show("System couldn't find a cabinet, please connect it.");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        int AvlQnt = AvailableQnty - NewQuantity;
                                        int rtnQnty = intReturnQuantity - UsedQuantity;
                                        DAL.ItemIssue(NewQuantity, Login.UserId, itemId, AvlQnt, Jobid, UsedQuantity, rtnQnty);
                                        MessageBox.Show("Item issued successfully.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                                finally
                                {
                                    if (IsCabinet)
                                    {
                                        objPort.Close();
                                    }
                                }
                               
                                //btnSave.Visible = false;
                                //btnIssueNext.Visible = true;
                                txtNew.Text = "";
                                txtUsed.Text = "";
                                //this.Hide();
                                //CallBackItemGrid();
                            }
                            else
                            {
                                Isissue = false;
                                return Isissue;
                            }
                        }

                        /* if (numericUpDown1.Value <= AvailableQnty)
                         {
                             if (numericUpDown1.Value > 0)
                             {

                             }
                             else
                             {
                                 MessageBox.Show("Please select Quantity.");
                             }
                         }
                         else
                         {
                             MessageBox.Show("The quantity specified is more than " + AvailableQnty + ", ", "QUANTITY INVALID");
                         }*/
                    }
                    else
                    {
                        MessageBox.Show("Please select Job.");
                        Isissue = false;
                        return Isissue;
                    }
                }
                return Isissue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Isissue = false;
                return Isissue;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private TextBox focusedTextbox = null;
        protected void touchScreen1_OnUserControlButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (focusedTextbox != null)
            {
                if (b.Text == "<-")
                {
                    if (focusedTextbox.Text.Length > 1)
                    {
                        focusedTextbox.Text = focusedTextbox.Text.Substring(0, focusedTextbox.Text.Length - 1);
                    }
                    else
                    {
                        focusedTextbox.Text = string.Empty;
                    }
                }
                else
                {
                    if (MyGlobal.bTouch)
                        focusedTextbox.Text = b.Text;
                    else
                    {
                        MyGlobal.bTouch = false;
                        focusedTextbox.Text += b.Text;
                    }
                }
            }
        }
        private void txtNew_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void txtUsed_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void txtQtyIssue_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }
        KeyPad npad = new KeyPad();
        private void txtItemCode_MouseDown(object sender, MouseEventArgs e)
        {
            if (npad.IsDisposed)
            {
                npad = new KeyPad();
                npad.Show();
            }
            else
            {
               
                npad.Show();
            }
        }
        private void btnjobadd_Click(object sender, EventArgs e)
        {
            JobCreation obj = new JobCreation();
           // objissueitem.CallBackItemGrid = new global::BindItemsGrid(this.CallBackBindGrid);

            obj.CallBackJob = new global::BindIssueJob(this.BindJob);
            obj.ShowDialog();
        }
        private void FillIssuedKit(StringBuilder sb)
        {
            try
            {
                DataTable dt = new DataTable();
               
                dt = DAL.BindIssueKit(sb);
                if (dt != null && dt.Rows.Count > 0)
                {
                    gvIssueItems.DataSource = dt;
                    itemId = Convert.ToInt32(gvIssueItems.Rows[0].Cells["Item id"].Value);
                    gvIssueItems.Columns["Item Id"].Visible = false;
                    gvIssueItems.AutoResizeColumns();

                    KitItemCode = gvIssueItems.Rows[0].Cells["Item code"].Value.ToString();
                    FillItemissue(KitItemCode);
                    ItemStatus();
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void gvIssueItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    KitItemCode = gvIssueItems.Rows[e.RowIndex].Cells["Item code"].Value.ToString();
                    itemId = Convert.ToInt32(gvIssueItems.Rows[e.RowIndex].Cells["Item id"].Value);
                    FillItemissue(KitItemCode);
                    ItemStatus();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void btnIssueNext_Click(object sender, EventArgs e)
        {
            if (gvIssueItems.Rows.Count > 0)
            {
               Isissue= Issue();
                if (Isissue)
                {
                    if (gvIssueItems.Rows.Count == 1)
                    {
                        btnSave.Visible = true;
                        btnIssueNext.Visible = false;
                       // btnZC.Visible = true;
                    }
                    DataGridViewRow row = gvIssueItems.SelectedRows[0];
                    gvIssueItems.Rows.Remove(row);
                    btnSave.Visible = false;
                    btnIssueNext.Visible = true;
                }
                if (gvIssueItems.Rows.Count > 0)
                {
                    if (gvIssueItems.Rows.Count ==1)
                    {
                        btnSave.Visible = true;
                        btnIssueNext.Visible = false;
                       // btnZC.Visible = true;
                    }
                    KitItemCode = gvIssueItems.Rows[0].Cells["Item code"].Value.ToString();
                    itemId = Convert.ToInt32(gvIssueItems.Rows[0].Cells["Item id"].Value);
                    FillItemissue(KitItemCode);
                    ItemStatus();
                }                
            }            
        }
        private void ItemStatus( )
        {
            try
            {
                DataSet ds = new DataSet();
                ds = DAL.ItemStatus(itemId);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtAvailableQnty.Text = ds.Tables[0].Rows[0]["Available"].ToString();
                        txtReturn.Text = ds.Tables[0].Rows[0]["ReturnItems"].ToString();
                        if (!string.IsNullOrEmpty(txtAvailableQnty.Text))
                        {
                            AvailableQnty = Convert.ToInt32(txtAvailableQnty.Text);     
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Commented by Rajkumar due to removed BC and ZC buttons
        //private void btnZC_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (IsCabinet)
        //        {
        //            objPort = new SerialPort();
        //            string[] ArrayComPortsNames = null;
        //            string portname = string.Empty;
        //            ArrayComPortsNames = SerialPort.GetPortNames();
        //            if (ArrayComPortsNames.Length > 0)
        //            {
        //                objPort.PortName = ArrayComPortsNames[0];

        //                if (objPort != null && objPort.IsOpen)
        //                {
        //                    objPort.Close();
        //                }
        //                objPort.Parity = Parity.None;
        //                objPort.StopBits = StopBits.One;
        //                objPort.DataBits = 8;
        //                objPort.Handshake = Handshake.None;
        //                objPort.RtsEnable = true;
        //                objPort.WriteTimeout = 2000;
        //                objPort.Open();
        //                //objPort.WriteLine("BIC");                                        

        //                Thread.Sleep(2000);
        //                objPort.WriteLine("AC");
        //            }
        //            else
        //            {
        //                MessageBox.Show("System couldn't find a cabinet, please connect it.");
        //                return;
        //            }
        //        }
        //        this.Hide();
        //        CallBackItemGrid();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    finally
        //    {
        //        if (IsCabinet)
        //        {
        //            objPort.Close();
        //        }
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
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
        //            //objPort.WriteLine("BIC");                                        
                    
        //            Thread.Sleep(2000);
        //            objPort.WriteLine("BC");
        //            this.Hide();
        //            CallBackItemGrid();
        //        }
        //        else
        //        {
        //            MessageBox.Show("System couldn't find a cabinet, please connect it.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        objPort.Close();
        //    }

        //}
    }
}
