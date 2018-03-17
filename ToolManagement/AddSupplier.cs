using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TooLManagementEntities;
using ToolBusinessLogiclayer;

public delegate void BindSuplier();

namespace ToolManagement
{
    public partial class AddSupplier : Form
    {
       
        public AddSupplier()
        {
            InitializeComponent();
            addSupplierctrl1.OnUserControlButtonClicked += new ToolManagement.Controls.AddSupplierctrl.ButtonClickedEventHandler(addSupplierctrl1_OnUserControlButtonClicked);
        }

        void addSupplierctrl1_OnUserControlButtonClicked(object sender, EventArgs e)
        {
            CallbackSuplierName();
            this.Hide();
        }
        public BindSuplier CallbackSuplierName;
        AddSupplierBo objbo = new AddSupplierBo();

    }
}
