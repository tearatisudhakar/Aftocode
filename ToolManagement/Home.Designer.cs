namespace ToolManagement
{
    partial class Home
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
            this.pnldown = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpbxItemDetails = new System.Windows.Forms.GroupBox();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.txtIssued = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtCribLocaton = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblIssued = new System.Windows.Forms.Label();
            this.crbLocation = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.btnIssedItem = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblpitemtype = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.GvIteminfo = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnitemDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlAdvancedSearch = new System.Windows.Forms.Panel();
            this.cmbSearchQty = new System.Windows.Forms.ComboBox();
            this.cmbSearchSupplier = new System.Windows.Forms.ComboBox();
            this.cmbSearchGroup = new System.Windows.Forms.ComboBox();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchQuantity = new System.Windows.Forms.TextBox();
            this.lblSearchSupplier = new System.Windows.Forms.Label();
            this.lblSearchGroup = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearchQty = new System.Windows.Forms.Label();
            this.txtSearchItemCode = new System.Windows.Forms.TextBox();
            this.lblISearchtemCode = new System.Windows.Forms.Label();
            this.lnklblCloseAdvancedSearch = new System.Windows.Forms.LinkLabel();
            this.lnklblAdvancedSearch = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbxItemDetails.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvIteminfo)).BeginInit();
            this.pnlAdvancedSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldown
            // 
            this.pnldown.Location = new System.Drawing.Point(3, 809);
            this.pnldown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnldown.Name = "pnldown";
            this.pnldown.Size = new System.Drawing.Size(1564, 24);
            this.pnldown.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.Location = new System.Drawing.Point(16, 22);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(749, 29);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(773, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpbxItemDetails
            // 
            this.grpbxItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpbxItemDetails.Controls.Add(this.txtReturn);
            this.grpbxItemDetails.Controls.Add(this.lblReturn);
            this.grpbxItemDetails.Controls.Add(this.txtIssued);
            this.grpbxItemDetails.Controls.Add(this.txtAvailable);
            this.grpbxItemDetails.Controls.Add(this.txtCribLocaton);
            this.grpbxItemDetails.Controls.Add(this.lblAvailable);
            this.grpbxItemDetails.Controls.Add(this.lblIssued);
            this.grpbxItemDetails.Controls.Add(this.crbLocation);
            this.grpbxItemDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpbxItemDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpbxItemDetails.Location = new System.Drawing.Point(872, 279);
            this.grpbxItemDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpbxItemDetails.Name = "grpbxItemDetails";
            this.grpbxItemDetails.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpbxItemDetails.Size = new System.Drawing.Size(225, 154);
            this.grpbxItemDetails.TabIndex = 13;
            this.grpbxItemDetails.TabStop = false;
            this.grpbxItemDetails.Text = "Details of the Selected Item";
            // 
            // txtReturn
            // 
            this.txtReturn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReturn.Location = new System.Drawing.Point(80, 121);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.ReadOnly = true;
            this.txtReturn.Size = new System.Drawing.Size(116, 27);
            this.txtReturn.TabIndex = 19;
            this.txtReturn.TabStop = false;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReturn.Location = new System.Drawing.Point(19, 128);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(72, 20);
            this.lblReturn.TabIndex = 18;
            this.lblReturn.Text = "Returned:";
            // 
            // txtIssued
            // 
            this.txtIssued.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIssued.Location = new System.Drawing.Point(80, 54);
            this.txtIssued.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIssued.Name = "txtIssued";
            this.txtIssued.ReadOnly = true;
            this.txtIssued.Size = new System.Drawing.Size(116, 27);
            this.txtIssued.TabIndex = 15;
            this.txtIssued.TabStop = false;
            // 
            // txtAvailable
            // 
            this.txtAvailable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAvailable.Location = new System.Drawing.Point(80, 17);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(116, 27);
            this.txtAvailable.TabIndex = 15;
            this.txtAvailable.TabStop = false;
            // 
            // txtCribLocaton
            // 
            this.txtCribLocaton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCribLocaton.Location = new System.Drawing.Point(80, 88);
            this.txtCribLocaton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCribLocaton.Name = "txtCribLocaton";
            this.txtCribLocaton.ReadOnly = true;
            this.txtCribLocaton.Size = new System.Drawing.Size(116, 27);
            this.txtCribLocaton.TabIndex = 15;
            this.txtCribLocaton.TabStop = false;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvailable.Location = new System.Drawing.Point(20, 29);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(74, 20);
            this.lblAvailable.TabIndex = 14;
            this.lblAvailable.Text = "Available:";
            // 
            // lblIssued
            // 
            this.lblIssued.AutoSize = true;
            this.lblIssued.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssued.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIssued.Location = new System.Drawing.Point(35, 66);
            this.lblIssued.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssued.Name = "lblIssued";
            this.lblIssued.Size = new System.Drawing.Size(53, 20);
            this.lblIssued.TabIndex = 14;
            this.lblIssued.Text = "Issued:";
            // 
            // crbLocation
            // 
            this.crbLocation.AutoSize = true;
            this.crbLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.crbLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crbLocation.Location = new System.Drawing.Point(22, 95);
            this.crbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crbLocation.Name = "crbLocation";
            this.crbLocation.Size = new System.Drawing.Size(69, 20);
            this.crbLocation.TabIndex = 14;
            this.crbLocation.Text = "Location:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcess.Location = new System.Drawing.Point(894, 490);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(182, 45);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Transactions";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnReturnItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnItem.Location = new System.Drawing.Point(894, 541);
            this.btnReturnItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(182, 45);
            this.btnReturnItem.TabIndex = 8;
            this.btnReturnItem.Text = "Return";
            this.btnReturnItem.UseVisualStyleBackColor = false;
            this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
            // 
            // btnIssedItem
            // 
            this.btnIssedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnIssedItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssedItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIssedItem.Location = new System.Drawing.Point(894, 439);
            this.btnIssedItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIssedItem.Name = "btnIssedItem";
            this.btnIssedItem.Size = new System.Drawing.Size(182, 45);
            this.btnIssedItem.TabIndex = 6;
            this.btnIssedItem.Text = "Issue";
            this.btnIssedItem.UseVisualStyleBackColor = false;
            this.btnIssedItem.Click += new System.EventHandler(this.btnIssedItem_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(183, 759);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 46);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Add Item";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(286, 759);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 46);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Edit Item";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(386, 759);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblpitemtype
            // 
            this.lblpitemtype.AutoSize = true;
            this.lblpitemtype.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpitemtype.Location = new System.Drawing.Point(122, 530);
            this.lblpitemtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpitemtype.Name = "lblpitemtype";
            this.lblpitemtype.Size = new System.Drawing.Size(0, 24);
            this.lblpitemtype.TabIndex = 14;
            this.lblpitemtype.Visible = false;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.White;
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHome.Controls.Add(this.GvIteminfo);
            this.pnlHome.Controls.Add(this.btnExportExcel);
            this.pnlHome.Controls.Add(this.btnitemDelete);
            this.pnlHome.Controls.Add(this.btnReturnItem);
            this.pnlHome.Controls.Add(this.btnExport);
            this.pnlHome.Controls.Add(this.btnIssedItem);
            this.pnlHome.Controls.Add(this.btnProcess);
            this.pnlHome.Controls.Add(this.pnlAdvancedSearch);
            this.pnlHome.Controls.Add(this.lnklblCloseAdvancedSearch);
            this.pnlHome.Controls.Add(this.lnklblAdvancedSearch);
            this.pnlHome.Controls.Add(this.txtInput);
            this.pnlHome.Controls.Add(this.btnClear);
            this.pnlHome.Controls.Add(this.imgItem);
            this.pnlHome.Controls.Add(this.btnSearch);
            this.pnlHome.Controls.Add(this.lblpitemtype);
            this.pnlHome.Controls.Add(this.grpbxItemDetails);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1111, 665);
            this.pnlHome.TabIndex = 34;
            // 
            // GvIteminfo
            // 
            this.GvIteminfo.AllowUserToAddRows = false;
            this.GvIteminfo.AllowUserToDeleteRows = false;
            this.GvIteminfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.GvIteminfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GvIteminfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIteminfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvIteminfo.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIteminfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.GvIteminfo.EnableHeadersVisualStyles = false;
            this.GvIteminfo.Location = new System.Drawing.Point(6, 85);
            this.GvIteminfo.Margin = new System.Windows.Forms.Padding(4);
            this.GvIteminfo.MultiSelect = false;
            this.GvIteminfo.Name = "GvIteminfo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIteminfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GvIteminfo.RowHeadersVisible = false;
            this.GvIteminfo.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvIteminfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GvIteminfo.RowTemplate.Height = 32;
            this.GvIteminfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvIteminfo.Size = new System.Drawing.Size(858, 505);
            this.GvIteminfo.TabIndex = 59;
            this.GvIteminfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvIteminfo_CellClick);
            this.GvIteminfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvIteminfo_CellDoubleClick);
            
            this.GvIteminfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GvIteminfo_KeyDown);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(917, 22);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 58;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnitemDelete
            // 
            this.btnitemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnitemDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnitemDelete.Location = new System.Drawing.Point(897, 592);
            this.btnitemDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnitemDelete.Name = "btnitemDelete";
            this.btnitemDelete.Size = new System.Drawing.Size(182, 45);
            this.btnitemDelete.TabIndex = 57;
            this.btnitemDelete.Text = "Delete";
            this.btnitemDelete.UseVisualStyleBackColor = false;
            this.btnitemDelete.Visible = false;
            this.btnitemDelete.Click += new System.EventHandler(this.btnitemDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExport.BackgroundImage = global::ToolManagement.Properties.Resources.PDF_Icon;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExport.Location = new System.Drawing.Point(916, 22);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(44, 28);
            this.btnExport.TabIndex = 5;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlAdvancedSearch
            // 
            this.pnlAdvancedSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdvancedSearch.Controls.Add(this.cmbSearchQty);
            this.pnlAdvancedSearch.Controls.Add(this.cmbSearchSupplier);
            this.pnlAdvancedSearch.Controls.Add(this.cmbSearchGroup);
            this.pnlAdvancedSearch.Controls.Add(this.cmbSearchCategory);
            this.pnlAdvancedSearch.Controls.Add(this.txtSearchQuantity);
            this.pnlAdvancedSearch.Controls.Add(this.lblSearchSupplier);
            this.pnlAdvancedSearch.Controls.Add(this.lblSearchGroup);
            this.pnlAdvancedSearch.Controls.Add(this.lblCategory);
            this.pnlAdvancedSearch.Controls.Add(this.lblSearchQty);
            this.pnlAdvancedSearch.Controls.Add(this.txtSearchItemCode);
            this.pnlAdvancedSearch.Controls.Add(this.lblISearchtemCode);
            this.pnlAdvancedSearch.Location = new System.Drawing.Point(13, 10);
            this.pnlAdvancedSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAdvancedSearch.Name = "pnlAdvancedSearch";
            this.pnlAdvancedSearch.Size = new System.Drawing.Size(753, 49);
            this.pnlAdvancedSearch.TabIndex = 0;
            // 
            // cmbSearchQty
            // 
            this.cmbSearchQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchQty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSearchQty.FormattingEnabled = true;
            this.cmbSearchQty.Items.AddRange(new object[] {
            "--Select Qty Type--",
            ">",
            "<",
            "=",
            "!="});
            this.cmbSearchQty.Location = new System.Drawing.Point(560, 21);
            this.cmbSearchQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchQty.Name = "cmbSearchQty";
            this.cmbSearchQty.Size = new System.Drawing.Size(123, 31);
            this.cmbSearchQty.TabIndex = 4;
            this.cmbSearchQty.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchQty_SelectionChangeCommitted);
            // 
            // cmbSearchSupplier
            // 
            this.cmbSearchSupplier.BackColor = System.Drawing.Color.White;
            this.cmbSearchSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSearchSupplier.FormattingEnabled = true;
            this.cmbSearchSupplier.Location = new System.Drawing.Point(428, 21);
            this.cmbSearchSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchSupplier.Name = "cmbSearchSupplier";
            this.cmbSearchSupplier.Size = new System.Drawing.Size(123, 31);
            this.cmbSearchSupplier.TabIndex = 3;
            this.cmbSearchSupplier.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchSupplier_SelectionChangeCommitted);
            // 
            // cmbSearchGroup
            // 
            this.cmbSearchGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSearchGroup.FormattingEnabled = true;
            this.cmbSearchGroup.Location = new System.Drawing.Point(290, 21);
            this.cmbSearchGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchGroup.Name = "cmbSearchGroup";
            this.cmbSearchGroup.Size = new System.Drawing.Size(123, 31);
            this.cmbSearchGroup.TabIndex = 2;
            this.cmbSearchGroup.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchGroup_SelectionChangeCommitted);
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Location = new System.Drawing.Point(146, 21);
            this.cmbSearchCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(123, 31);
            this.cmbSearchCategory.TabIndex = 1;
            this.cmbSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchCategory_SelectionChangeCommitted);
            // 
            // txtSearchQuantity
            // 
            this.txtSearchQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchQuantity.Location = new System.Drawing.Point(690, 21);
            this.txtSearchQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchQuantity.Name = "txtSearchQuantity";
            this.txtSearchQuantity.Size = new System.Drawing.Size(56, 30);
            this.txtSearchQuantity.TabIndex = 5;
            this.txtSearchQuantity.TextChanged += new System.EventHandler(this.txtSearchQuantity_TextChanged);
            this.txtSearchQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchQuantity_KeyPress);
            // 
            // lblSearchSupplier
            // 
            this.lblSearchSupplier.AutoSize = true;
            this.lblSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchSupplier.Location = new System.Drawing.Point(428, 2);
            this.lblSearchSupplier.Name = "lblSearchSupplier";
            this.lblSearchSupplier.Size = new System.Drawing.Size(76, 23);
            this.lblSearchSupplier.TabIndex = 41;
            this.lblSearchSupplier.Text = "Supplier:";
            // 
            // lblSearchGroup
            // 
            this.lblSearchGroup.AutoSize = true;
            this.lblSearchGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchGroup.Location = new System.Drawing.Point(290, 2);
            this.lblSearchGroup.Name = "lblSearchGroup";
            this.lblSearchGroup.Size = new System.Drawing.Size(62, 23);
            this.lblSearchGroup.TabIndex = 41;
            this.lblSearchGroup.Text = "Group:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Location = new System.Drawing.Point(146, 2);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(120, 23);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Item category:";
            // 
            // lblSearchQty
            // 
            this.lblSearchQty.AutoSize = true;
            this.lblSearchQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchQty.Location = new System.Drawing.Point(560, 2);
            this.lblSearchQty.Name = "lblSearchQty";
            this.lblSearchQty.Size = new System.Drawing.Size(120, 23);
            this.lblSearchQty.TabIndex = 40;
            this.lblSearchQty.Text = "Quantity Type:";
            // 
            // txtSearchItemCode
            // 
            this.txtSearchItemCode.BackColor = System.Drawing.Color.White;
            this.txtSearchItemCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchItemCode.Location = new System.Drawing.Point(4, 21);
            this.txtSearchItemCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchItemCode.Name = "txtSearchItemCode";
            this.txtSearchItemCode.Size = new System.Drawing.Size(124, 30);
            this.txtSearchItemCode.TabIndex = 0;
            this.txtSearchItemCode.TextChanged += new System.EventHandler(this.txtSearchItemCode_TextChanged);
            // 
            // lblISearchtemCode
            // 
            this.lblISearchtemCode.AutoSize = true;
            this.lblISearchtemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISearchtemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblISearchtemCode.Location = new System.Drawing.Point(4, 4);
            this.lblISearchtemCode.Name = "lblISearchtemCode";
            this.lblISearchtemCode.Size = new System.Drawing.Size(94, 23);
            this.lblISearchtemCode.TabIndex = 43;
            this.lblISearchtemCode.Text = "Item Code:";
            // 
            // lnklblCloseAdvancedSearch
            // 
            this.lnklblCloseAdvancedSearch.AutoSize = true;
            this.lnklblCloseAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblCloseAdvancedSearch.Location = new System.Drawing.Point(14, 61);
            this.lnklblCloseAdvancedSearch.Name = "lnklblCloseAdvancedSearch";
            this.lnklblCloseAdvancedSearch.Size = new System.Drawing.Size(181, 23);
            this.lnklblCloseAdvancedSearch.TabIndex = 1;
            this.lnklblCloseAdvancedSearch.TabStop = true;
            this.lnklblCloseAdvancedSearch.Text = "Hide Advanced Search";
            this.lnklblCloseAdvancedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCloseAdvancedSearch_LinkClicked);
            // 
            // lnklblAdvancedSearch
            // 
            this.lnklblAdvancedSearch.AutoSize = true;
            this.lnklblAdvancedSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAdvancedSearch.Location = new System.Drawing.Point(14, 61);
            this.lnklblAdvancedSearch.Name = "lnklblAdvancedSearch";
            this.lnklblAdvancedSearch.Size = new System.Drawing.Size(187, 23);
            this.lnklblAdvancedSearch.TabIndex = 56;
            this.lnklblAdvancedSearch.TabStop = true;
            this.lnklblAdvancedSearch.Text = "Show Advanced Search";
            this.lnklblAdvancedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAdvancedSearch_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(847, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imgItem
            // 
            this.imgItem.BackColor = System.Drawing.Color.Transparent;
            this.imgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Location = new System.Drawing.Point(872, 81);
            this.imgItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(219, 192);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgItem.TabIndex = 29;
            this.imgItem.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "DEL";
            this.dataGridViewImageColumn1.Image = global::ToolManagement.Properties.Resources.DEL;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Home
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1111, 665);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pnldown);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Tool Management";
            this.grpbxItemDetails.ResumeLayout(false);
            this.grpbxItemDetails.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvIteminfo)).EndInit();
            this.pnlAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldown;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpbxItemDetails;
        private System.Windows.Forms.TextBox txtCribLocaton;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblIssued;
        private System.Windows.Forms.Label crbLocation;
        private System.Windows.Forms.TextBox txtIssued;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.Button btnIssedItem;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblpitemtype;
        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlAdvancedSearch;
        private System.Windows.Forms.ComboBox cmbSearchQty;
        private System.Windows.Forms.ComboBox cmbSearchSupplier;
        private System.Windows.Forms.ComboBox cmbSearchGroup;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.TextBox txtSearchQuantity;
        private System.Windows.Forms.Label lblSearchSupplier;
        private System.Windows.Forms.Label lblSearchGroup;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearchQty;
        private System.Windows.Forms.TextBox txtSearchItemCode;
        private System.Windows.Forms.Label lblISearchtemCode;
        private System.Windows.Forms.LinkLabel lnklblCloseAdvancedSearch;
        private System.Windows.Forms.LinkLabel lnklblAdvancedSearch;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnitemDelete;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView GvIteminfo;
    }
}