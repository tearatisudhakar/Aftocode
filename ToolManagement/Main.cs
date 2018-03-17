using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using ToolDataAccessLayer;

namespace ToolManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "AFTRACX";
            DisableMenus();
            VisableMenus();
            lblUsername.Text = "Welcome : " + Login.Username;
            Screen loc = Screen.PrimaryScreen;
            int width = loc.Bounds.Width;
            int height = loc.Bounds.Height;

            menu_homepage.Renderer = new MyRenderer();
            // pnlMail.Size = new System.Drawing.Size(1400, 800);
            pnlMail.Dock = DockStyle.Fill;
            InsertLogid();
        }
        ToolDAL DAL = new ToolDAL();
        int LogId;
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(11, 126, 222); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(11, 126, 222); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(11, 126, 222); }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(8, 64, 101); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(8, 64, 101); }
            }
            public override Color MenuBorder
            {
                get
                {
                    return Color.Red;
                }
            }
            public override Color MenuItemBorder
            {
                get
                {
                    return Color.White;
                }
            }
        }
        
        public void VisableMenus()
        {
            if (!Login.IsAdmin)
            {

                if (Login.AllowItemMnagement)
                {
                    itemManagementToolStripMenuItem.Visible = true;             
                                     
                  //  tbAddItem.
                }

                else
                    itemManagementToolStripMenuItem.Visible = false;

                if (Login.AllowJobs)
                    jobsToolStripMenuItem.Visible = true;
                else
                    jobsToolStripMenuItem.Visible = false;

                if (Login.AllowReports)
                    reportsToolStripMenuItem.Visible = true;
                else
                    reportsToolStripMenuItem.Visible = false;
                
                loadItemMgmnt();
            }
            else
            {
                if (Login.AllowGeneral)
                {
                    DisableMenuscolors();
                    generalToolStripMenuItem.BackColor = Color.SteelBlue;
                    generalToolStripMenuItem.Visible = true;

                    pnlMail.Controls.Clear();
                    Ganeral frmganaral = new Ganeral();

                    frmganaral.Dock = DockStyle.Fill;
                    frmganaral.TopLevel = false;
                    frmganaral.FormBorderStyle = FormBorderStyle.None;

                    pnlMail.Controls.Add(frmganaral);
                    frmganaral.Visible = true;
                }
                else
                {
                    generalToolStripMenuItem.Visible = false;
                }

                if (Login.AllowItemMnagement)
                    itemManagementToolStripMenuItem.Visible = true;
                else
                    itemManagementToolStripMenuItem.Visible = false;

                if (Login.AllowInventory)
                    inventoryToolStripMenuItem.Visible = true;
                else
                    inventoryToolStripMenuItem.Visible = false;

                if (Login.AllowJobs)
                    jobsToolStripMenuItem.Visible = true;
                else
                    jobsToolStripMenuItem.Visible = false;

                if (Login.AllowReports)
                    reportsToolStripMenuItem.Visible = true;
                else
                    reportsToolStripMenuItem.Visible = false;

                if (Login.AllowSupplier)
                    supplierToolStripMenuItem.Visible = true;
                else
                    supplierToolStripMenuItem.Visible = false;

                //if (Login.AllowConfiguration)
                //    configurationToolStripMenuItem.Visible = true;
                //else
                //    configurationToolStripMenuItem.Visible = false;
            }
        }
        public void DisableMenus()
        {
            generalToolStripMenuItem.Visible = false;
            itemManagementToolStripMenuItem.Visible = false;
            inventoryToolStripMenuItem.Visible = false;
            jobsToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            supplierToolStripMenuItem.Visible = false;
           // configurationToolStripMenuItem.Visible = false;
        }
        public void DisableMenuscolors()
        {
            generalToolStripMenuItem.BackColor = Color.Transparent;
            itemManagementToolStripMenuItem.BackColor = Color.Transparent;
            inventoryToolStripMenuItem.BackColor = Color.Transparent;
            jobsToolStripMenuItem.BackColor = Color.Transparent;
            reportsToolStripMenuItem.BackColor = Color.Transparent;
            supplierToolStripMenuItem.BackColor = Color.Transparent;
           // configurationToolStripMenuItem.BackColor = Color.Transparent;
        }
        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Home frmHome = new Home();
                // frmHome.Dock = DockStyle.Fill;
                frmHome.TopLevel = false;
                frmHome.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmHome);
                frmHome.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddaNewItem frmItem = new AddaNewItem();
                frmItem.Dock = DockStyle.Fill;
                frmItem.TopLevel = false;
                frmItem.FormBorderStyle = FormBorderStyle.None;

                pnlMail.Controls.Add(frmItem);
                frmItem.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void loadItemMgmnt()
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
                itemManagementToolStripMenuItem.BackColor = Color.SteelBlue;
                ItemManagement frmItem = new ItemManagement();
                frmItem.Dock = DockStyle.Fill;
                frmItem.TopLevel = false;
                frmItem.FormBorderStyle = FormBorderStyle.None;

                pnlMail.Controls.Add(frmItem);
                frmItem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadItemMgmnt();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                Ganeral frmganaral = new Ganeral();
                DisableMenuscolors();
                generalToolStripMenuItem.BackColor = Color.SteelBlue;
                frmganaral.Dock = DockStyle.Fill;
                frmganaral.TopLevel = false;
                frmganaral.FormBorderStyle = FormBorderStyle.None;

                pnlMail.Controls.Add(frmganaral);
                frmganaral.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
                inventoryToolStripMenuItem.BackColor = Color.SteelBlue;
                Inventory frmInventory = new Inventory();
                frmInventory.Dock = DockStyle.Fill;
                frmInventory.TopLevel = false;
                frmInventory.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmInventory);
                frmInventory.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
                jobsToolStripMenuItem.BackColor = Color.SteelBlue;
                Job frmJob = new Job();
                frmJob.Dock = DockStyle.Fill;
                frmJob.TopLevel = false;
                frmJob.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmJob);
                frmJob.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
                supplierToolStripMenuItem.BackColor = Color.SteelBlue;
                Supliermenu frmSupplier = new Supliermenu();
                frmSupplier.Dock = DockStyle.Fill;
                frmSupplier.TopLevel = false;
                frmSupplier.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmSupplier);
                frmSupplier.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void barcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //pnlMail.Controls.Clear();
                //BarcodeMenu frmBarcode = new BarcodeMenu();
                //frmBarcode.Dock = DockStyle.Fill;
                //frmBarcode.TopLevel = false;
                //frmBarcode.FormBorderStyle = FormBorderStyle.None;
                //pnlMail.Controls.Add(frmBarcode);
                //frmBarcode.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
                reportsToolStripMenuItem.BackColor = Color.SteelBlue;
                ReportsMenu frmReport = new ReportsMenu();
                frmReport.Dock = DockStyle.Fill;
                frmReport.TopLevel = false;
                frmReport.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmReport);
                frmReport.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMail.Controls.Clear();
                DisableMenuscolors();
               // configurationToolStripMenuItem.BackColor = Color.SteelBlue;
                ConfigurationMenu frmconfig = new ConfigurationMenu();
                frmconfig.Dock = DockStyle.Fill;
                frmconfig.TopLevel = false;
                frmconfig.FormBorderStyle = FormBorderStyle.None;
                pnlMail.Controls.Add(frmconfig);
                frmconfig.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Login frmLogin = new Login();
                frmLogin.Show();
                DAL.UpdateLogid(LogId);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Application.Restart();
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                DAL.UpdateLogid(LogId);
                Environment.Exit(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void InsertLogid()
        {
            try
            {
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
                // Get the IP  
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                LogId = DAL.InsertLogid(Login.UserId, Login.LoginTypeId, myIP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            //ntfncontextMenuStrip
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //pnlMail.Controls.Clear();
                //DisableMenuscolors();
                //reportsToolStripMenuItem.BackColor = Color.SteelBlue;
                //Help frmHelp = new Help();
                //frmHelp.Dock = DockStyle.Fill;
                //frmHelp.TopLevel = false;
                //frmHelp.FormBorderStyle = FormBorderStyle.None;
                //pnlMail.Controls.Add(frmHelp);
                //frmHelp.Visible = true;
                System.Diagnostics.Process.Start("..\\Document\\Aftomat_Help.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }
    }
}
