namespace ToolManagement
{
    partial class JobDetails
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
            this.lblJob = new System.Windows.Forms.Label();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.gvJobdetails = new System.Windows.Forms.DataGridView();
            this.pnlJobManagement = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobdetails)).BeginInit();
            this.pnlJobManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJob.Location = new System.Drawing.Point(126, 29);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(28, 15);
            this.lblJob.TabIndex = 15;
            this.lblJob.Text = "Job:";
            // 
            // cmbjob
            // 
            this.cmbjob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(172, 25);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(238, 23);
            this.cmbjob.TabIndex = 14;
            this.cmbjob.SelectedIndexChanged += new System.EventHandler(this.cmbjob_SelectedIndexChanged);
            // 
            // gvJobdetails
            // 
            this.gvJobdetails.AllowUserToAddRows = false;
            this.gvJobdetails.AllowUserToDeleteRows = false;
            this.gvJobdetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.gvJobdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvJobdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvJobdetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvJobdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvJobdetails.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvJobdetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvJobdetails.EnableHeadersVisualStyles = false;
            this.gvJobdetails.Location = new System.Drawing.Point(31, 71);
            this.gvJobdetails.MultiSelect = false;
            this.gvJobdetails.Name = "gvJobdetails";
            this.gvJobdetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvJobdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvJobdetails.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gvJobdetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvJobdetails.RowTemplate.Height = 32;
            this.gvJobdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvJobdetails.Size = new System.Drawing.Size(535, 291);
            this.gvJobdetails.TabIndex = 16;
            // 
            // pnlJobManagement
            // 
            this.pnlJobManagement.Controls.Add(this.btnExportExcel);
            this.pnlJobManagement.Controls.Add(this.lblJob);
            this.pnlJobManagement.Controls.Add(this.gvJobdetails);
            this.pnlJobManagement.Controls.Add(this.cmbjob);
            this.pnlJobManagement.Location = new System.Drawing.Point(12, 12);
            this.pnlJobManagement.Name = "pnlJobManagement";
            this.pnlJobManagement.Size = new System.Drawing.Size(948, 519);
            this.pnlJobManagement.TabIndex = 17;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(434, 21);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // JobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(972, 560);
            this.Controls.Add(this.pnlJobManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobDetails";
            this.Text = "Job Management";
            ((System.ComponentModel.ISupportInitialize)(this.gvJobdetails)).EndInit();
            this.pnlJobManagement.ResumeLayout(false);
            this.pnlJobManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.DataGridView gvJobdetails;
        private System.Windows.Forms.Panel pnlJobManagement;
        private System.Windows.Forms.Button btnExportExcel;
    }
}