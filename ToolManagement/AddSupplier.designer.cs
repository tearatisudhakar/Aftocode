namespace ToolManagement
{
    partial class AddSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSupplierctrl1 = new ToolManagement.Controls.AddSupplierctrl();
            this.SuspendLayout();
            // 
            // addSupplierctrl1
            // 
            this.addSupplierctrl1.Location = new System.Drawing.Point(0, 0);
            this.addSupplierctrl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSupplierctrl1.Name = "addSupplierctrl1";
            this.addSupplierctrl1.Size = new System.Drawing.Size(1084, 553);
            this.addSupplierctrl1.TabIndex = 0;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(951, 551);
            this.Controls.Add(this.addSupplierctrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AddSupplierctrl addSupplierctrl1;


    }
}