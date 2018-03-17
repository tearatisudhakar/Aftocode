namespace ToolManagement
{
    partial class ReturnItemHistroy
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
            this.pnlRitemHistoryform = new System.Windows.Forms.Panel();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStartPage = new System.Windows.Forms.Button();
            this.cmbNoOfRecords = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gvReturnItemsInfo = new System.Windows.Forms.DataGridView();
            this.pnlRitemHistoryform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturnItemsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRitemHistoryform
            // 
            this.pnlRitemHistoryform.Controls.Add(this.lblTotalRecords);
            this.pnlRitemHistoryform.Controls.Add(this.btnLastPage);
            this.pnlRitemHistoryform.Controls.Add(this.btnNext);
            this.pnlRitemHistoryform.Controls.Add(this.btnPreview);
            this.pnlRitemHistoryform.Controls.Add(this.btnStartPage);
            this.pnlRitemHistoryform.Controls.Add(this.cmbNoOfRecords);
            this.pnlRitemHistoryform.Controls.Add(this.btnExportExcel);
            this.pnlRitemHistoryform.Controls.Add(this.btnClear);
            this.pnlRitemHistoryform.Controls.Add(this.btnSearch);
            this.pnlRitemHistoryform.Controls.Add(this.txtInput);
            this.pnlRitemHistoryform.Controls.Add(this.gvReturnItemsInfo);
            this.pnlRitemHistoryform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRitemHistoryform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRitemHistoryform.Location = new System.Drawing.Point(0, 0);
            this.pnlRitemHistoryform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRitemHistoryform.Name = "pnlRitemHistoryform";
            this.pnlRitemHistoryform.Size = new System.Drawing.Size(1425, 826);
            this.pnlRitemHistoryform.TabIndex = 0;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(1139, 5);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(83, 18);
            this.lblTotalRecords.TabIndex = 73;
            this.lblTotalRecords.Text = "No records";
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.DimGray;
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLastPage.Location = new System.Drawing.Point(1280, 28);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(44, 30);
            this.btnLastPage.TabIndex = 71;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(1236, 28);
            this.btnNext.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 30);
            this.btnNext.TabIndex = 72;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.DimGray;
            this.btnPreview.BackgroundImage = global::ToolManagement.Properties.Resources._1conference_call_xxl;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreview.Location = new System.Drawing.Point(1184, 28);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(44, 30);
            this.btnPreview.TabIndex = 69;
            this.btnPreview.Text = "<";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStartPage
            // 
            this.btnStartPage.BackColor = System.Drawing.Color.DimGray;
            this.btnStartPage.BackgroundImage = global::ToolManagement.Properties.Resources._1conference_call_xxl;
            this.btnStartPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartPage.Location = new System.Drawing.Point(1140, 28);
            this.btnStartPage.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnStartPage.Name = "btnStartPage";
            this.btnStartPage.Size = new System.Drawing.Size(44, 30);
            this.btnStartPage.TabIndex = 70;
            this.btnStartPage.Text = "<<";
            this.btnStartPage.UseVisualStyleBackColor = false;
            this.btnStartPage.Click += new System.EventHandler(this.btnStartPage_Click);
            // 
            // cmbNoOfRecords
            // 
            this.cmbNoOfRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoOfRecords.FormattingEnabled = true;
            this.cmbNoOfRecords.Location = new System.Drawing.Point(1327, 27);
            this.cmbNoOfRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNoOfRecords.Name = "cmbNoOfRecords";
            this.cmbNoOfRecords.Size = new System.Drawing.Size(75, 26);
            this.cmbNoOfRecords.TabIndex = 68;
            this.cmbNoOfRecords.SelectionChangeCommitted += new System.EventHandler(this.cmbNoOfRecords_SelectionChangeCommitted);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(1073, 25);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(59, 34);
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(976, 26);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(887, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.Location = new System.Drawing.Point(41, 25);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(829, 35);
            this.txtInput.TabIndex = 45;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // gvReturnItemsInfo
            // 
            this.gvReturnItemsInfo.AllowUserToAddRows = false;
            this.gvReturnItemsInfo.AllowUserToDeleteRows = false;
            this.gvReturnItemsInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.gvReturnItemsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvReturnItemsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReturnItemsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvReturnItemsInfo.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReturnItemsInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvReturnItemsInfo.EnableHeadersVisualStyles = false;
            this.gvReturnItemsInfo.Location = new System.Drawing.Point(39, 68);
            this.gvReturnItemsInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvReturnItemsInfo.MultiSelect = false;
            this.gvReturnItemsInfo.Name = "gvReturnItemsInfo";
            this.gvReturnItemsInfo.ReadOnly = true;
            this.gvReturnItemsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReturnItemsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvReturnItemsInfo.RowHeadersVisible = false;
            this.gvReturnItemsInfo.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gvReturnItemsInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvReturnItemsInfo.RowTemplate.Height = 32;
            this.gvReturnItemsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReturnItemsInfo.Size = new System.Drawing.Size(1372, 442);
            this.gvReturnItemsInfo.TabIndex = 44;
            // 
            // ReturnItemHistroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1425, 826);
            this.Controls.Add(this.pnlRitemHistoryform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReturnItemHistroy";
            this.Text = "ReturnItemHistroy";
            this.pnlRitemHistoryform.ResumeLayout(false);
            this.pnlRitemHistoryform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturnItemsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRitemHistoryform;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView gvReturnItemsInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnStartPage;
        private System.Windows.Forms.ComboBox cmbNoOfRecords;

    }
}