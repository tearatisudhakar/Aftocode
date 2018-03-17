using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolManagement
{
    public partial class KeyPad : Form
    {

        public delegate void Keypressedhandler(string key);
        public static event Keypressedhandler SendKeyvalue;
        public KeyPad()
        {
            InitializeComponent();
        }
     
        private void keyboardcontrol1_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
        {
              // SendKeys.Send(e.KeyboardKeyPressed);
            try
            {
                if (SendKeyvalue != null)
                {
                    SendKeyvalue(e.KeyboardKeyPressed);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
