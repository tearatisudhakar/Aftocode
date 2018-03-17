namespace ToolManagement
{
    partial class BarcodeMenu
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
            this.tbBarcodeganarator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbBarcodeganarator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBarcodeganarator
            // 
            this.tbBarcodeganarator.Controls.Add(this.tabPage1);
            this.tbBarcodeganarator.Controls.Add(this.tabPage2);
            this.tbBarcodeganarator.Controls.Add(this.tabPage3);
            this.tbBarcodeganarator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBarcodeganarator.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbBarcodeganarator.Location = new System.Drawing.Point(0, 0);
            this.tbBarcodeganarator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBarcodeganarator.Name = "tbBarcodeganarator";
            this.tbBarcodeganarator.SelectedIndex = 0;
            this.tbBarcodeganarator.Size = new System.Drawing.Size(1319, 603);
            this.tbBarcodeganarator.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1311, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barcode Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1311, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1311, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Barcode Printer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BarcodeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 603);
            this.Controls.Add(this.tbBarcodeganarator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeMenu";
            this.Text = "BarcodeMenu";
            this.tbBarcodeganarator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbBarcodeganarator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}