﻿namespace ToolManagement
{
    partial class IssuedDetals
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
            this.GvIssuedItemDetails = new System.Windows.Forms.DataGridView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlIssuedDetails = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvIssuedItemDetails)).BeginInit();
            this.pnlIssuedDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // GvIssuedItemDetails
            // 
            this.GvIssuedItemDetails.AllowUserToAddRows = false;
            this.GvIssuedItemDetails.AllowUserToDeleteRows = false;
            this.GvIssuedItemDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.GvIssuedItemDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GvIssuedItemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIssuedItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvIssuedItemDetails.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvIssuedItemDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.GvIssuedItemDetails.EnableHeadersVisualStyles = false;
            this.GvIssuedItemDetails.Location = new System.Drawing.Point(26, 57);
            this.GvIssuedItemDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GvIssuedItemDetails.MultiSelect = false;
            this.GvIssuedItemDetails.Name = "GvIssuedItemDetails";
            this.GvIssuedItemDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIssuedItemDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GvIssuedItemDetails.RowHeadersVisible = false;
            this.GvIssuedItemDetails.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.GvIssuedItemDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GvIssuedItemDetails.RowTemplate.Height = 32;
            this.GvIssuedItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvIssuedItemDetails.Size = new System.Drawing.Size(1022, 528);
            this.GvIssuedItemDetails.TabIndex = 2;
            this.GvIssuedItemDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvIssuedItemDetails_CellClick);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.Location = new System.Drawing.Point(26, 18);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(728, 29);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(764, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(833, 18);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Location = new System.Drawing.Point(900, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 28);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlIssuedDetails
            // 
            this.pnlIssuedDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIssuedDetails.Controls.Add(this.btnExportExcel);
            this.pnlIssuedDetails.Controls.Add(this.txtInput);
            this.pnlIssuedDetails.Controls.Add(this.GvIssuedItemDetails);
            this.pnlIssuedDetails.Controls.Add(this.btnClear);
            this.pnlIssuedDetails.Controls.Add(this.btnReturn);
            this.pnlIssuedDetails.Controls.Add(this.btnSearch);
            this.pnlIssuedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIssuedDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlIssuedDetails.Name = "pnlIssuedDetails";
            this.pnlIssuedDetails.Size = new System.Drawing.Size(1059, 624);
            this.pnlIssuedDetails.TabIndex = 8;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(966, 18);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // IssuedDetals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1059, 624);
            this.Controls.Add(this.pnlIssuedDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssuedDetals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issued Detals";
            ((System.ComponentModel.ISupportInitialize)(this.GvIssuedItemDetails)).EndInit();
            this.pnlIssuedDetails.ResumeLayout(false);
            this.pnlIssuedDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvIssuedItemDetails;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlIssuedDetails;
        private System.Windows.Forms.Button btnExportExcel;
    }
}