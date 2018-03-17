namespace ToolManagement
{
    partial class ImportDataFromExcel
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
            this.pnlImportExcel = new System.Windows.Forms.Panel();
            this.lnklblDownloadExcelDefaultTemplate = new System.Windows.Forms.LinkLabel();
            this.btnUplloadExcelFile = new System.Windows.Forms.Button();
            this.lblExcelOpenDailog = new System.Windows.Forms.Label();
            this.grpbxNewitem = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancelInsert = new System.Windows.Forms.Button();
            this.btnInsertItemFromExcel = new System.Windows.Forms.Button();
            this.gvInsertExcelINewtems = new System.Windows.Forms.DataGridView();
            this.grpbxUpdateitems = new System.Windows.Forms.GroupBox();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdateExcelitems = new System.Windows.Forms.Button();
            this.gvUpdateExceltem = new System.Windows.Forms.DataGridView();
            this.pnlImportExcel.SuspendLayout();
            this.grpbxNewitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsertExcelINewtems)).BeginInit();
            this.grpbxUpdateitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdateExceltem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImportExcel
            // 
            this.pnlImportExcel.BackColor = System.Drawing.Color.White;
            this.pnlImportExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImportExcel.Controls.Add(this.lnklblDownloadExcelDefaultTemplate);
            this.pnlImportExcel.Controls.Add(this.btnUplloadExcelFile);
            this.pnlImportExcel.Controls.Add(this.lblExcelOpenDailog);
            this.pnlImportExcel.Controls.Add(this.grpbxNewitem);
            this.pnlImportExcel.Controls.Add(this.grpbxUpdateitems);
            this.pnlImportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImportExcel.Location = new System.Drawing.Point(0, 0);
            this.pnlImportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImportExcel.Name = "pnlImportExcel";
            this.pnlImportExcel.Size = new System.Drawing.Size(1137, 598);
            this.pnlImportExcel.TabIndex = 0;
            // 
            // lnklblDownloadExcelDefaultTemplate
            // 
            this.lnklblDownloadExcelDefaultTemplate.AutoSize = true;
            this.lnklblDownloadExcelDefaultTemplate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblDownloadExcelDefaultTemplate.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnklblDownloadExcelDefaultTemplate.Location = new System.Drawing.Point(848, 57);
            this.lnklblDownloadExcelDefaultTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblDownloadExcelDefaultTemplate.Name = "lnklblDownloadExcelDefaultTemplate";
            this.lnklblDownloadExcelDefaultTemplate.Size = new System.Drawing.Size(166, 23);
            this.lnklblDownloadExcelDefaultTemplate.TabIndex = 1;
            this.lnklblDownloadExcelDefaultTemplate.TabStop = true;
            this.lnklblDownloadExcelDefaultTemplate.Text = "Download template ";
            this.lnklblDownloadExcelDefaultTemplate.Click += new System.EventHandler(this.lnklblDownloadExcelDefaultTemplate_Click);
            // 
            // btnUplloadExcelFile
            // 
            this.btnUplloadExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnUplloadExcelFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnUplloadExcelFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUplloadExcelFile.Location = new System.Drawing.Point(504, 48);
            this.btnUplloadExcelFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUplloadExcelFile.Name = "btnUplloadExcelFile";
            this.btnUplloadExcelFile.Size = new System.Drawing.Size(104, 31);
            this.btnUplloadExcelFile.TabIndex = 0;
            this.btnUplloadExcelFile.Text = "Browse";
            this.btnUplloadExcelFile.UseVisualStyleBackColor = false;
            this.btnUplloadExcelFile.Visible = false;
            this.btnUplloadExcelFile.Click += new System.EventHandler(this.btnUplloadExcelFile_Click);
            // 
            // lblExcelOpenDailog
            // 
            this.lblExcelOpenDailog.AutoSize = true;
            this.lblExcelOpenDailog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExcelOpenDailog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcelOpenDailog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExcelOpenDailog.Location = new System.Drawing.Point(348, 53);
            this.lblExcelOpenDailog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExcelOpenDailog.Name = "lblExcelOpenDailog";
            this.lblExcelOpenDailog.Size = new System.Drawing.Size(117, 20);
            this.lblExcelOpenDailog.TabIndex = 123;
            this.lblExcelOpenDailog.Text = "Select Excel File:";
            // 
            // grpbxNewitem
            // 
            this.grpbxNewitem.Controls.Add(this.lblDescription);
            this.grpbxNewitem.Controls.Add(this.lblNote);
            this.grpbxNewitem.Controls.Add(this.btnCancelInsert);
            this.grpbxNewitem.Controls.Add(this.btnInsertItemFromExcel);
            this.grpbxNewitem.Controls.Add(this.gvInsertExcelINewtems);
            this.grpbxNewitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxNewitem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpbxNewitem.Location = new System.Drawing.Point(29, 85);
            this.grpbxNewitem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpbxNewitem.Name = "grpbxNewitem";
            this.grpbxNewitem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxNewitem.Size = new System.Drawing.Size(1089, 231);
            this.grpbxNewitem.TabIndex = 2;
            this.grpbxNewitem.TabStop = false;
            this.grpbxNewitem.Text = "New Items";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(137, 196);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(372, 21);
            this.lblDescription.TabIndex = 134;
            this.lblDescription.Text = "Please Insert individual Items by double clicking row";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(67, 197);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(67, 17);
            this.lblNote.TabIndex = 133;
            this.lblNote.Text = "NOTE :-";
            // 
            // btnCancelInsert
            // 
            this.btnCancelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnCancelInsert.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelInsert.Location = new System.Drawing.Point(951, 190);
            this.btnCancelInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelInsert.Name = "btnCancelInsert";
            this.btnCancelInsert.Size = new System.Drawing.Size(104, 33);
            this.btnCancelInsert.TabIndex = 2;
            this.btnCancelInsert.Text = "Cancel";
            this.btnCancelInsert.UseVisualStyleBackColor = false;
            this.btnCancelInsert.Click += new System.EventHandler(this.btnCancelInsert_Click);
            // 
            // btnInsertItemFromExcel
            // 
            this.btnInsertItemFromExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnInsertItemFromExcel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInsertItemFromExcel.Location = new System.Drawing.Point(845, 190);
            this.btnInsertItemFromExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertItemFromExcel.Name = "btnInsertItemFromExcel";
            this.btnInsertItemFromExcel.Size = new System.Drawing.Size(104, 33);
            this.btnInsertItemFromExcel.TabIndex = 1;
            this.btnInsertItemFromExcel.Text = "Insert";
            this.btnInsertItemFromExcel.UseVisualStyleBackColor = false;
            this.btnInsertItemFromExcel.Visible = false;
            this.btnInsertItemFromExcel.Click += new System.EventHandler(this.btnInsertItemFromExcel_Click);
            // 
            // gvInsertExcelINewtems
            // 
            this.gvInsertExcelINewtems.AllowDrop = true;
            this.gvInsertExcelINewtems.AllowUserToAddRows = false;
            this.gvInsertExcelINewtems.AllowUserToOrderColumns = true;
            this.gvInsertExcelINewtems.AllowUserToResizeColumns = false;
            this.gvInsertExcelINewtems.AllowUserToResizeRows = false;
            this.gvInsertExcelINewtems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvInsertExcelINewtems.BackgroundColor = System.Drawing.Color.White;
            this.gvInsertExcelINewtems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInsertExcelINewtems.Location = new System.Drawing.Point(75, 30);
            this.gvInsertExcelINewtems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvInsertExcelINewtems.MultiSelect = false;
            this.gvInsertExcelINewtems.Name = "gvInsertExcelINewtems";
            this.gvInsertExcelINewtems.ReadOnly = true;
            this.gvInsertExcelINewtems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvInsertExcelINewtems.Size = new System.Drawing.Size(981, 159);
            this.gvInsertExcelINewtems.TabIndex = 0;
            this.gvInsertExcelINewtems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInsertExcelINewtems_CellDoubleClick);
            // 
            // grpbxUpdateitems
            // 
            this.grpbxUpdateitems.Controls.Add(this.btnCancelUpdate);
            this.grpbxUpdateitems.Controls.Add(this.btnUpdateExcelitems);
            this.grpbxUpdateitems.Controls.Add(this.gvUpdateExceltem);
            this.grpbxUpdateitems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxUpdateitems.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpbxUpdateitems.Location = new System.Drawing.Point(29, 326);
            this.grpbxUpdateitems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxUpdateitems.Name = "grpbxUpdateitems";
            this.grpbxUpdateitems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxUpdateitems.Size = new System.Drawing.Size(1089, 244);
            this.grpbxUpdateitems.TabIndex = 3;
            this.grpbxUpdateitems.TabStop = false;
            this.grpbxUpdateitems.Text = "Updated Items";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnCancelUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelUpdate.Location = new System.Drawing.Point(956, 190);
            this.btnCancelUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(104, 33);
            this.btnCancelUpdate.TabIndex = 2;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = false;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnUpdateExcelitems
            // 
            this.btnUpdateExcelitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnUpdateExcelitems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateExcelitems.Location = new System.Drawing.Point(847, 190);
            this.btnUpdateExcelitems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateExcelitems.Name = "btnUpdateExcelitems";
            this.btnUpdateExcelitems.Size = new System.Drawing.Size(104, 33);
            this.btnUpdateExcelitems.TabIndex = 1;
            this.btnUpdateExcelitems.Text = "Update All";
            this.btnUpdateExcelitems.UseVisualStyleBackColor = false;
            this.btnUpdateExcelitems.Visible = false;
            this.btnUpdateExcelitems.Click += new System.EventHandler(this.btnUpdateExcelitems_Click);
            // 
            // gvUpdateExceltem
            // 
            this.gvUpdateExceltem.AllowUserToAddRows = false;
            this.gvUpdateExceltem.AllowUserToDeleteRows = false;
            this.gvUpdateExceltem.AllowUserToOrderColumns = true;
            this.gvUpdateExceltem.AllowUserToResizeColumns = false;
            this.gvUpdateExceltem.AllowUserToResizeRows = false;
            this.gvUpdateExceltem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUpdateExceltem.BackgroundColor = System.Drawing.Color.White;
            this.gvUpdateExceltem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUpdateExceltem.Location = new System.Drawing.Point(75, 26);
            this.gvUpdateExceltem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvUpdateExceltem.Name = "gvUpdateExceltem";
            this.gvUpdateExceltem.ReadOnly = true;
            this.gvUpdateExceltem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUpdateExceltem.Size = new System.Drawing.Size(980, 160);
            this.gvUpdateExceltem.TabIndex = 0;
            // 
            // ImportDataFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 598);
            this.Controls.Add(this.pnlImportExcel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportDataFromExcel";
            this.Text = "ImportDataFromExcel";
            this.pnlImportExcel.ResumeLayout(false);
            this.pnlImportExcel.PerformLayout();
            this.grpbxNewitem.ResumeLayout(false);
            this.grpbxNewitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsertExcelINewtems)).EndInit();
            this.grpbxUpdateitems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdateExceltem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImportExcel;
        private System.Windows.Forms.GroupBox grpbxUpdateitems;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdateExcelitems;
        private System.Windows.Forms.DataGridView gvUpdateExceltem;
        private System.Windows.Forms.Button btnUplloadExcelFile;
        private System.Windows.Forms.Label lblExcelOpenDailog;
        private System.Windows.Forms.GroupBox grpbxNewitem;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancelInsert;
        private System.Windows.Forms.Button btnInsertItemFromExcel;
        private System.Windows.Forms.DataGridView gvInsertExcelINewtems;
        private System.Windows.Forms.LinkLabel lnklblDownloadExcelDefaultTemplate;
    }
}