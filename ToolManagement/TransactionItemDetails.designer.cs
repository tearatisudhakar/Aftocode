namespace ToolManagement
{
    partial class TransactionItemDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.txtTransactionDate = new System.Windows.Forms.TextBox();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.txtPoNo = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.TxtMadeBy = new System.Windows.Forms.TextBox();
            this.lblPoNo = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtInDex = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpboximage = new System.Windows.Forms.GroupBox();
            this.picBxforIssue = new System.Windows.Forms.PictureBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetails)).BeginInit();
            this.grpboximage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTransactionDetails
            // 
            this.gvTransactionDetails.AllowUserToAddRows = false;
            this.gvTransactionDetails.AllowUserToDeleteRows = false;
            this.gvTransactionDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.gvTransactionDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTransactionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTransactionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvTransactionDetails.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTransactionDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTransactionDetails.EnableHeadersVisualStyles = false;
            this.gvTransactionDetails.Location = new System.Drawing.Point(31, 267);
            this.gvTransactionDetails.MultiSelect = false;
            this.gvTransactionDetails.Name = "gvTransactionDetails";
            this.gvTransactionDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTransactionDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvTransactionDetails.RowHeadersVisible = false;
            this.gvTransactionDetails.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gvTransactionDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvTransactionDetails.RowTemplate.Height = 32;
            this.gvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTransactionDetails.Size = new System.Drawing.Size(758, 210);
            this.gvTransactionDetails.TabIndex = 12;
            this.gvTransactionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTransactionDetails_CellClick);
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTransactionDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTransactionDate.Location = new System.Drawing.Point(178, 144);
            this.txtTransactionDate.Multiline = true;
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.ReadOnly = true;
            this.txtTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.txtTransactionDate.TabIndex = 6;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTransactionDate.Location = new System.Drawing.Point(46, 144);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(120, 20);
            this.lblTransactionDate.TabIndex = 25;
            this.lblTransactionDate.Text = "Transaction date:";
            this.lblTransactionDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPoNo
            // 
            this.txtPoNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPoNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPoNo.Location = new System.Drawing.Point(178, 222);
            this.txtPoNo.Multiline = true;
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.ReadOnly = true;
            this.txtPoNo.Size = new System.Drawing.Size(250, 21);
            this.txtPoNo.TabIndex = 9;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSupplier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSupplier.Location = new System.Drawing.Point(178, 196);
            this.txtSupplier.Multiline = true;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(250, 21);
            this.txtSupplier.TabIndex = 8;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUnitCost.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUnitCost.Location = new System.Drawing.Point(178, 170);
            this.txtUnitCost.Multiline = true;
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.ReadOnly = true;
            this.txtUnitCost.Size = new System.Drawing.Size(250, 21);
            this.txtUnitCost.TabIndex = 7;
            // 
            // TxtMadeBy
            // 
            this.TxtMadeBy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtMadeBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMadeBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtMadeBy.Location = new System.Drawing.Point(177, 118);
            this.TxtMadeBy.Multiline = true;
            this.TxtMadeBy.Name = "TxtMadeBy";
            this.TxtMadeBy.ReadOnly = true;
            this.TxtMadeBy.Size = new System.Drawing.Size(250, 21);
            this.TxtMadeBy.TabIndex = 4;
            // 
            // lblPoNo
            // 
            this.lblPoNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPoNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPoNo.Location = new System.Drawing.Point(97, 222);
            this.lblPoNo.Name = "lblPoNo";
            this.lblPoNo.Size = new System.Drawing.Size(69, 20);
            this.lblPoNo.TabIndex = 14;
            this.lblPoNo.Text = "Quantity:";
            this.lblPoNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupplier
            // 
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupplier.Location = new System.Drawing.Point(95, 196);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = " Supplier:";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.Color.Transparent;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTask.Location = new System.Drawing.Point(124, 170);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(41, 20);
            this.lblTask.TabIndex = 17;
            this.lblTask.Text = "Task:";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.lblMadeBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMadeBy.Location = new System.Drawing.Point(59, 118);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(106, 20);
            this.lblMadeBy.TabIndex = 16;
            this.lblMadeBy.Text = "Entry done by:";
            this.lblMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLocation.Location = new System.Drawing.Point(176, 92);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(250, 21);
            this.txtLocation.TabIndex = 3;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemCode.Location = new System.Drawing.Point(176, 40);
            this.txtItemCode.Multiline = true;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(250, 21);
            this.txtItemCode.TabIndex = 1;
            // 
            // txtInDex
            // 
            this.txtInDex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInDex.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInDex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtInDex.Location = new System.Drawing.Point(176, 14);
            this.txtInDex.Multiline = true;
            this.txtInDex.Name = "txtInDex";
            this.txtInDex.ReadOnly = true;
            this.txtInDex.Size = new System.Drawing.Size(250, 21);
            this.txtInDex.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.Location = new System.Drawing.Point(176, 66);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(250, 21);
            this.txtDescription.TabIndex = 2;
            // 
            // lblItemCode
            // 
            this.lblItemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Location = new System.Drawing.Point(82, 40);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(83, 20);
            this.lblItemCode.TabIndex = 26;
            this.lblItemCode.Text = "Item code:";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemDesc.Location = new System.Drawing.Point(48, 66);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(118, 20);
            this.lblItemDesc.TabIndex = 27;
            this.lblItemDesc.Text = "Item description:";
            this.lblItemDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocation.Location = new System.Drawing.Point(66, 92);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 20);
            this.lblLocation.TabIndex = 28;
            this.lblLocation.Text = "Item location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Location = new System.Drawing.Point(80, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 20);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Item category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpboximage
            // 
            this.grpboximage.BackColor = System.Drawing.Color.Transparent;
            this.grpboximage.Controls.Add(this.picBxforIssue);
            this.grpboximage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboximage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpboximage.Location = new System.Drawing.Point(445, 11);
            this.grpboximage.Margin = new System.Windows.Forms.Padding(2);
            this.grpboximage.Name = "grpboximage";
            this.grpboximage.Padding = new System.Windows.Forms.Padding(2);
            this.grpboximage.Size = new System.Drawing.Size(294, 246);
            this.grpboximage.TabIndex = 50;
            this.grpboximage.TabStop = false;
            this.grpboximage.Text = "ToolImage";
            // 
            // picBxforIssue
            // 
            this.picBxforIssue.Location = new System.Drawing.Point(10, 21);
            this.picBxforIssue.Name = "picBxforIssue";
            this.picBxforIssue.Size = new System.Drawing.Size(276, 215);
            this.picBxforIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxforIssue.TabIndex = 50;
            this.picBxforIssue.TabStop = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(745, 233);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 62;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // TransactionItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 509);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.grpboximage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtInDex);
            this.Controls.Add(this.txtTransactionDate);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.txtPoNo);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.TxtMadeBy);
            this.Controls.Add(this.lblPoNo);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.gvTransactionDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Item Details";
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetails)).EndInit();
            this.grpboximage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTransactionDetails;
        private System.Windows.Forms.TextBox txtTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.TextBox txtPoNo;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.TextBox TxtMadeBy;
        private System.Windows.Forms.Label lblPoNo;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtInDex;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpboximage;
        private System.Windows.Forms.PictureBox picBxforIssue;
        private System.Windows.Forms.Button btnExportExcel;
    }
}