using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;

namespace ToolManagement.Controls
{
    public partial class Useralerts : UserControl
    {
       // public static string Username;

        public Useralerts()
        {
            InitializeComponent();
            lblUsername.Text = "Welcome : " + Login.Username;
            CreateMenuItems();
        }
        //ToolBAL objcontroler = new ToolBAL();
        private void btnUser_Click(object sender, EventArgs e)
        {
            //UserView frm = new UserView();
            //frm.Location = Point(0, 10);
            //frm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ctmForNotification.Show();
           ctmForNotification.Show(Cursor.Position.X, Cursor.Position.Y);
            
        }

        public void Show(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            Show(control, control.ClientRectangle);
        }
        private void Show(Control control, Rectangle area)
        {
            if (control == null)
                throw new ArgumentNullException("control");


            //Point location = control.PointToScreen(new Point(0, btnMOQnotifications.Height));
            //location = btnMOQnotifications.PointToScreen(location);
            //ctmForNotification.Show(btnMOQnotifications.Left+this.Left,btnMOQnotifications.Top+btnMOQnotifications.Height+this.Top);
            Point location = control.PointToScreen(new Point(area.Right, area.Top + area.Height));

            Rectangle screen = Screen.FromControl(control).WorkingArea;

            if (location.X + Size.Width > (screen.Left + screen.Width))
                location.X = (screen.Right + screen.Width) - Size.Width;

            if (location.Y + Size.Height > (screen.Top + screen.Height))
                location.Y -= Size.Height + area.Height;

            location = control.PointToClient(location);
            //ContextMenu cm1 = new ContextMenu();
            //cm1.MenuItems.Add("User Details");
            //cm1.MenuItems.Add("Log Out");
            //// ctmForLogOut.Show(this, new Point(location));//places the menu at the pointer position            
            //ctmForLogOut.Show(control, location, ToolStripDropDownDirection.Left);
        }
        public void CreateMenuItems()
        {
            try
            {

               // DataTable dt = objcontroler.GetMoQNotificationDetails();
                //if (dt.Rows.Count > 0)
                //{
                //    string lbl = string.Empty;
                //    foreach (DataRow item in dt.Rows)
                //    {
                //        lbl = " " + item["ItemCode"].ToString() + " item  is Less than MOQ ";
                //        ctmForNotification.Items.Add(lbl);
                //    }
                //}
                ////ctmForLogOut.Items.Add("User Details");
                //ctmForLogOut.Items.Add("Log Out");

            }
            catch (Exception ex)
            {


            }
        }
    }

}
