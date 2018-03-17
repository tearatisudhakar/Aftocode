using System;
using System.Data;
using System.Windows.Forms;
using ToolBusinessLogiclayer;
using TooLManagementEntities;
using System.IO.Ports;
using System.Timers;
namespace ToolManagement
{
    public partial class Login : Form
    {
        public static int UserId;
        public static string Username;
        public static bool AllowGeneral;
        public static bool AllowItemMnagement;
        public static bool AllowInventory;
        public static bool AllowJobs;
        public static bool AllowReports;
        public static bool AllowSupplier;
        public static bool AllowConfiguration;
        public static string Accesslevel;
        public static int LoginTypeId;



        // private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Login()
        {
            InitializeComponent();

            /* System.Timers.Timer timer = new System.Timers.Timer(1000);
             timer.Elapsed += OnTimedEvent;
             timer.AutoReset = true;
             timer.Enabled = true;*/

        }

        static ToolBAL objBAL = new ToolBAL();
        public static bool IsAdmin;
        static AddItemBo objBo = new AddItemBo();
        static FingerPrintlogin fingerobj = new FingerPrintlogin();
        SerialPort portobj = new SerialPort();
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            int value5 = fingerobj.RFIDLogin();
            if (value5 > 0)
            {
                DataSet ds = new DataSet();
                // int value = fingerobj.RFIDLogin();
                //  if (value != 0)
                {
                    ds = objBAL.CheckUser(string.Empty, string.Empty, value5);
                    if (ds.Tables.Count > 1)
                    {
                        if (ds.Tables[0].Rows.Count == 1)
                        {
                            if (ds.Tables[0].Rows[0]["UserId"].ToString() != null)
                            {
                                UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"].ToString());
                                Username = ds.Tables[0].Rows[0]["FirstName"].ToString() + " " + ds.Tables[0].Rows[0]["LastName"].ToString();
                                //objBo.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"].ToString());
                                IsAdmin = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsAdmin"].ToString());
                                Accesslevel = ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                AllowGeneral = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());
                                AllowInventory = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowInventory"].ToString());
                                AllowItemMnagement = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                                AllowJobs = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                                AllowReports = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                                AllowSupplier = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                                AllowConfiguration = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());
                            }
                            //Home mainwindow = new Home();
                            //HomePage mainwindow = new HomePage();
                            Main mainwindow = new Main();
                            mainwindow.Show();
                            mainwindow.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Validation failed");
                            return;
                        }
                    }
                }
                //else
                //{

                //    MessageBox.Show("Please place your RFID Card to login", this.Text);
                //    return;
                //}

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginTypeId = 2;
            string strUserName = txtUsername.Text;
            string strPassword = txtPassword.Text;
            DataSet ds = new DataSet();
            try
            {
                if (radioButton3.Checked)
                {
                    if (strUserName != string.Empty && strPassword != string.Empty)
                    {
                        //B  int i = 0;
                        ds = objBAL.CheckUser(strUserName, strPassword, 0);
                        if (ds.Tables.Count > 1)
                        {
                            if (ds.Tables[0].Rows.Count == 1)
                            {
                                if (ds.Tables[0].Rows[0]["UserId"].ToString() != null)
                                {
                                    UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"].ToString());
                                    Username = ds.Tables[0].Rows[0]["FirstName"].ToString() + " " + ds.Tables[0].Rows[0]["LastName"].ToString();
                                    //objBo.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"].ToString());
                                    IsAdmin = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsAdmin"].ToString());
                                    Accesslevel = ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                                }
                                if (ds.Tables[1].Rows.Count > 0)
                                {
                                    AllowGeneral = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());
                                    AllowInventory = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowInventory"].ToString());
                                    AllowItemMnagement = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                                    AllowJobs = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                                    AllowReports = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                                    AllowSupplier = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                                    AllowConfiguration = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());
                                }

                                Main mainwindow = new Main();
                                mainwindow.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid User Name and Password.", this.Text);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid User Name and Password.", this.Text);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid User Name and Password.", this.Text);
                        return;
                    }
                }

                else if (radioButton2.Checked)
                {
                    int value = fingerobj.SendLoginF(out portobj);
                    if (value != 0)
                    {
                        ds = objBAL.CheckUser(strUserName, strPassword, value);
                        if (ds.Tables.Count > 1)
                        {
                            if (ds.Tables[0].Rows.Count == 1)
                            {
                                if (ds.Tables[0].Rows[0]["UserId"].ToString() != null)
                                {
                                    UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserId"].ToString());
                                    Username = ds.Tables[0].Rows[0]["FirstName"].ToString() + " " + ds.Tables[0].Rows[0]["LastName"].ToString();
                                    //objBo.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"].ToString());
                                    IsAdmin = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsAdmin"].ToString());
                                    Accesslevel = ds.Tables[0].Rows[0]["AccessLevels"].ToString();
                                }
                                if (ds.Tables[1].Rows.Count > 0)
                                {
                                    AllowGeneral = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowGeneral"].ToString());
                                    AllowInventory = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowInventory"].ToString());
                                    AllowItemMnagement = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowItemMnagement"].ToString());
                                    AllowJobs = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowJobs"].ToString());
                                    AllowReports = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowReports"].ToString());
                                    AllowSupplier = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowSupplier"].ToString());
                                    AllowConfiguration = Convert.ToBoolean(ds.Tables[1].Rows[0]["AllowConfiguration"].ToString());
                                }
                                //Home mainwindow = new Home();
                                //HomePage mainwindow = new HomePage();
                                Main mainwindow = new Main();
                                mainwindow.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Validation failed", this.Text);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Validation failed", this.Text);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please place your indext finger for bio-metric login", this.Text);
                        return;
                    }
                }
                else if (radioButton1.Checked) //rfid
                {
                    //past rfid code
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void keyboardcontrol1_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
        {
            SendKeys.Send(e.KeyboardKeyPressed);
        }
    }
}
