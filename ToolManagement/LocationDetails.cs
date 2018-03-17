using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;


namespace ToolManagement
{
    public partial class LocationDetails : Form
    {
        public LocationDetails()
        {
            InitializeComponent();
            GetLocationName();

        }
        ToolBAL BAl = new ToolBAL();
        DataTable dt = null;
        public void GetLocationName()
        {
            try
            {
                dt = new DataTable();  
                dt = BAl.GetLocations();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {            
            int x = 0;
            int y = 0;
            string Order = string.Empty;
            string[] z = null;
            if (dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Order = dr["Location"].ToString();
                    if (Order!=string.Empty)
                    {
                        z = Order.Split('-');    
                    }
                    if (z.Length==2)
                    {
                        x = Convert.ToInt32(z[0]);
                        y = Convert.ToInt32(z[1]);
                    }
                    if (e.Row == x && e.Column == y)
                    {
                        e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds);
                        break;
                    }
                }
            }
           

        }
    }
}
