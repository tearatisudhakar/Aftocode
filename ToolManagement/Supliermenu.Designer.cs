namespace ToolManagement
{
    partial class Supliermenu
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
            this.tabSupplier = new System.Windows.Forms.TabControl();
            this.tbSupplierList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.GvSuplier = new System.Windows.Forms.DataGridView();
            this.btngvDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbAddsupplier = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addSupplierctrl2 = new ToolManagement.Controls.AddSupplierctrl();
            this.addSupplierctrl1 = new ToolManagement.Controls.AddSupplierctrl();
            this.tabSupplier.SuspendLayout();
            this.tbSupplierList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvSuplier)).BeginInit();
            this.tbAddsupplier.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSupplier
            // 
            this.tabSupplier.Controls.Add(this.tbSupplierList);
            this.tabSupplier.Controls.Add(this.tbAddsupplier);
            this.tabSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSupplier.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSupplier.HotTrack = true;
            this.tabSupplier.ItemSize = new System.Drawing.Size(120, 45);
            this.tabSupplier.Location = new System.Drawing.Point(0, 0);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Drawing.Point(10, 6);
            this.tabSupplier.SelectedIndex = 0;
            this.tabSupplier.Size = new System.Drawing.Size(951, 581);
            this.tabSupplier.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSupplier.TabIndex = 0;
            this.tabSupplier.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabSupplier_DrawItem);
            this.tabSupplier.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSupplier_Selected);
            // 
            // tbSupplierList
            // 
            this.tbSupplierList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbSupplierList.Controls.Add(this.panel1);
            this.tbSupplierList.Location = new System.Drawing.Point(4, 49);
            this.tbSupplierList.Name = "tbSupplierList";
            this.tbSupplierList.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.tbSupplierList.Size = new System.Drawing.Size(943, 528);
            this.tbSupplierList.TabIndex = 0;
            this.tbSupplierList.Text = "Supplier List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.GvSuplier);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 517);
            this.panel1.TabIndex = 42;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(760, 12);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 61;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(688, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtInput.Location = new System.Drawing.Point(22, 13);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(507, 29);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // GvSuplier
            // 
            this.GvSuplier.AllowUserToAddRows = false;
            this.GvSuplier.AllowUserToDeleteRows = false;
            this.GvSuplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.GvSuplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvSuplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvSuplier.ColumnHeadersHeight = 36;
            this.GvSuplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btngvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvSuplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.GvSuplier.EnableHeadersVisualStyles = false;
            this.GvSuplier.Location = new System.Drawing.Point(22, 50);
            this.GvSuplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GvSuplier.MultiSelect = false;
            this.GvSuplier.Name = "GvSuplier";
            this.GvSuplier.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvSuplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GvSuplier.RowHeadersVisible = false;
            this.GvSuplier.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.GvSuplier.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GvSuplier.RowTemplate.Height = 32;
            this.GvSuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvSuplier.Size = new System.Drawing.Size(902, 406);
            this.GvSuplier.TabIndex = 2;
            this.GvSuplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvSuplier_CellClick);
            this.GvSuplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvSuplier_CellDoubleClick);
            // 
            // btngvDelete
            // 
            this.btngvDelete.HeaderText = "";
            this.btngvDelete.Name = "btngvDelete";
            this.btngvDelete.ReadOnly = true;
            this.btngvDelete.Text = "D";
            this.btngvDelete.UseColumnTextForButtonValue = true;
            this.btngvDelete.Visible = false;
            this.btngvDelete.Width = 50;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(615, 13);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(539, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbAddsupplier
            // 
            this.tbAddsupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbAddsupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddsupplier.Controls.Add(this.panel2);
            this.tbAddsupplier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddsupplier.Location = new System.Drawing.Point(4, 49);
            this.tbAddsupplier.Name = "tbAddsupplier";
            this.tbAddsupplier.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.tbAddsupplier.Size = new System.Drawing.Size(943, 528);
            this.tbAddsupplier.TabIndex = 1;
            this.tbAddsupplier.Text = "Add Supplier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addSupplierctrl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 517);
            this.panel2.TabIndex = 1;
            // 
            // addSupplierctrl2
            // 
            this.addSupplierctrl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSupplierctrl2.Location = new System.Drawing.Point(0, 0);
            this.addSupplierctrl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSupplierctrl2.Name = "addSupplierctrl2";
            this.addSupplierctrl2.Size = new System.Drawing.Size(941, 517);
            this.addSupplierctrl2.TabIndex = 0;
            // 
            // addSupplierctrl1
            // 
            this.addSupplierctrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSupplierctrl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplierctrl1.Location = new System.Drawing.Point(0, 10);
            this.addSupplierctrl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSupplierctrl1.Name = "addSupplierctrl1";
            this.addSupplierctrl1.Size = new System.Drawing.Size(941, 527);
            this.addSupplierctrl1.TabIndex = 0;
            // 
            // Supliermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 581);
            this.Controls.Add(this.tabSupplier);
            this.Name = "Supliermenu";
            this.Text = "Supliermenu";
            this.tabSupplier.ResumeLayout(false);
            this.tbSupplierList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvSuplier)).EndInit();
            this.tbAddsupplier.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSupplier;
        private System.Windows.Forms.TabPage tbSupplierList;
        private System.Windows.Forms.TabPage tbAddsupplier;
        private Controls.AddSupplierctrl addSupplierctrl1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView GvSuplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controls.AddSupplierctrl addSupplierctrl2;
        private System.Windows.Forms.DataGridViewButtonColumn btngvDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportExcel;
    }
}