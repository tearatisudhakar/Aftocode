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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            LoadPdf();
        }
        private void LoadPdf()
        {
            try
            {
                System.Diagnostics.Process.Start("~\\Document\\Aftomat_Help.pdf");
               // ToolManagement.Properties.
            }
            catch (Exception ex)
            {
                

                throw ex;
            }
        }
    }
}
