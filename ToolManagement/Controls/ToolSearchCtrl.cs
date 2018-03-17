using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ToolDataAccessLayer;
//using ToolBusinessLogiclayer;
//using ToolManagement;
//using TooLManagementEntities;

namespace ToolManagement.Controls
{
    public partial class ToolSearchCtrl : UserControl
    {
        public ToolSearchCtrl()
        {
            InitializeComponent();
            GetItemsinfo();
        }
        
        //ToolDAL DAL = new ToolDAL();

        //    AddItemBo objbo = new AddItemBo();
           
        public void GetItemsinfo()
        {
           
            //DataSet ds = new DataSet();
            //ds = DAL.ItemInfo();
            //GvIteminfo.DataSource = ds.Tables[0];
            
           
        }

        public void btnAddVisble()
        {
            //if (objbo.IsAdmin == true)
            //{
            //    btnAdd.Visible = true;
            //}
            //else
            //{
            //    btnAdd.Visible = false;
            //}
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtInput.Text != string.Empty)
            {
                string itemcode = txtInput.Text;
                //DataSet ds = new DataSet();
                //ds = DAL.ItemInfo(itemcode);
                //GvIteminfo.DataSource = ds.Tables[0];
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            GetItemsinfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void GvIteminfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  ItemDetails Pannel2 = new ItemDetails();
          //  string strItemcode = GvIteminfo.Rows[e.RowIndex].Cells[1].Value.ToString();
          //  DataSet ds = new DataSet();
          //  ds = DAL.ItemInfo(strItemcode);

          //  ItemDetails kk = new ItemDetails();
          //  kk.lblpitemkey.Text = "rahhhhh";

           

          //Pannel2.PannelDetails(ds);

           
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            AddaNewItem obj = new AddaNewItem();
            obj.Show();
        }
    }
}
