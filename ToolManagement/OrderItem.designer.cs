namespace ToolManagement
{
    partial class OrderItem
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPoNo = new System.Windows.Forms.TextBox();
            this.txtOrderOnDate = new System.Windows.Forms.TextBox();
            this.lblPoNo = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblOrderOn = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnOrederOnDate = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblDateWanted = new System.Windows.Forms.Label();
            this.txtDateWanted = new System.Windows.Forms.TextBox();
            this.btnDateWanted = new System.Windows.Forms.Button();
            this.cbxPrintLocstion = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(142, 52);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(20, 29);
            this.txtItemCode.Multiline = true;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(139, 20);
            this.txtItemCode.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(161, 29);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(334, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(19, 8);
            this.txtIndex.Multiline = true;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(476, 20);
            this.txtIndex.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(198, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 25);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtPoNo
            // 
            this.txtPoNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoNo.Location = new System.Drawing.Point(178, 161);
            this.txtPoNo.Multiline = true;
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Size = new System.Drawing.Size(109, 20);
            this.txtPoNo.TabIndex = 10;
            // 
            // txtOrderOnDate
            // 
            this.txtOrderOnDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderOnDate.Location = new System.Drawing.Point(410, 82);
            this.txtOrderOnDate.Multiline = true;
            this.txtOrderOnDate.Name = "txtOrderOnDate";
            this.txtOrderOnDate.Size = new System.Drawing.Size(87, 18);
            this.txtOrderOnDate.TabIndex = 5;
            // 
            // lblPoNo
            // 
            this.lblPoNo.AutoSize = true;
            this.lblPoNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoNo.Location = new System.Drawing.Point(123, 160);
            this.lblPoNo.Name = "lblPoNo";
            this.lblPoNo.Size = new System.Drawing.Size(54, 18);
            this.lblPoNo.TabIndex = 35;
            this.lblPoNo.Text = "PO No :";
            this.lblPoNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(107, 108);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 18);
            this.lblSupplier.TabIndex = 34;
            this.lblSupplier.Text = " Supplier :";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderOn
            // 
            this.lblOrderOn.AutoSize = true;
            this.lblOrderOn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderOn.Location = new System.Drawing.Point(336, 82);
            this.lblOrderOn.Name = "lblOrderOn";
            this.lblOrderOn.Size = new System.Drawing.Size(72, 18);
            this.lblOrderOn.TabIndex = 39;
            this.lblOrderOn.Text = "Order On :";
            this.lblOrderOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(102, 134);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(75, 18);
            this.lblUnitPrice.TabIndex = 38;
            this.lblUnitPrice.Text = "Unit Price :";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(19, 84);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(158, 18);
            this.lblQuantity.TabIndex = 37;
            this.lblQuantity.Text = "Quantity to be Ordered :";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(178, 85);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(120, 20);
            this.nupQuantity.TabIndex = 4;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(178, 108);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(311, 21);
            this.cmbSupplier.TabIndex = 7;
            // 
            // btnOrederOnDate
            // 
            this.btnOrederOnDate.Location = new System.Drawing.Point(500, 81);
            this.btnOrederOnDate.Name = "btnOrederOnDate";
            this.btnOrederOnDate.Size = new System.Drawing.Size(25, 20);
            this.btnOrederOnDate.TabIndex = 6;
            this.btnOrederOnDate.Text = "...";
            this.btnOrederOnDate.UseVisualStyleBackColor = true;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(178, 134);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(109, 20);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // lblDateWanted
            // 
            this.lblDateWanted.AutoSize = true;
            this.lblDateWanted.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateWanted.Location = new System.Drawing.Point(310, 136);
            this.lblDateWanted.Name = "lblDateWanted";
            this.lblDateWanted.Size = new System.Drawing.Size(98, 18);
            this.lblDateWanted.TabIndex = 39;
            this.lblDateWanted.Text = "Date Wanted  :";
            this.lblDateWanted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDateWanted
            // 
            this.txtDateWanted.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateWanted.Location = new System.Drawing.Point(410, 136);
            this.txtDateWanted.Multiline = true;
            this.txtDateWanted.Name = "txtDateWanted";
            this.txtDateWanted.Size = new System.Drawing.Size(87, 18);
            this.txtDateWanted.TabIndex = 9;
            // 
            // btnDateWanted
            // 
            this.btnDateWanted.Location = new System.Drawing.Point(500, 134);
            this.btnDateWanted.Name = "btnDateWanted";
            this.btnDateWanted.Size = new System.Drawing.Size(24, 21);
            this.btnDateWanted.TabIndex = 55;
            this.btnDateWanted.Text = "...";
            this.btnDateWanted.UseVisualStyleBackColor = true;
            // 
            // cbxPrintLocstion
            // 
            this.cbxPrintLocstion.AutoSize = true;
            this.cbxPrintLocstion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrintLocstion.Location = new System.Drawing.Point(255, 185);
            this.cbxPrintLocstion.Name = "cbxPrintLocstion";
            this.cbxPrintLocstion.Size = new System.Drawing.Size(158, 22);
            this.cbxPrintLocstion.TabIndex = 11;
            this.cbxPrintLocstion.Text = "Check Print Location :";
            this.cbxPrintLocstion.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(266, 210);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(62, 25);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Cancel";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // OrderItem
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(546, 249);
            this.Controls.Add(this.cbxPrintLocstion);
            this.Controls.Add(this.btnDateWanted);
            this.Controls.Add(this.btnOrederOnDate);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtPoNo);
            this.Controls.Add(this.txtDateWanted);
            this.Controls.Add(this.txtOrderOnDate);
            this.Controls.Add(this.lblPoNo);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblDateWanted);
            this.Controls.Add(this.lblOrderOn);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Item";            
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPoNo;
        private System.Windows.Forms.TextBox txtOrderOnDate;
        private System.Windows.Forms.Label lblPoNo;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblOrderOn;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnOrederOnDate;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblDateWanted;
        private System.Windows.Forms.TextBox txtDateWanted;
        private System.Windows.Forms.Button btnDateWanted;
        private System.Windows.Forms.CheckBox cbxPrintLocstion;
        private System.Windows.Forms.Button btnCheck;
    }
}