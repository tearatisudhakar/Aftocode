namespace ToolManagement
{
    partial class Job
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
            this.tbJobList = new System.Windows.Forms.TabPage();
            this.pnlJobDetails = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblJobDropDown = new System.Windows.Forms.Label();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.gvJobdetails = new System.Windows.Forms.DataGridView();
            this.tbCreateJob = new System.Windows.Forms.TabPage();
            this.pnlJopinfo = new System.Windows.Forms.Panel();
            this.tab_jobinfo = new System.Windows.Forms.TabControl();
            this.tabjobinfo = new System.Windows.Forms.TabPage();
            this.txtjobDesc = new System.Windows.Forms.TextBox();
            this.txtjobname = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lbljobname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabJobs = new System.Windows.Forms.TabControl();
            this.tbJobList.SuspendLayout();
            this.pnlJobDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobdetails)).BeginInit();
            this.tbCreateJob.SuspendLayout();
            this.pnlJopinfo.SuspendLayout();
            this.tab_jobinfo.SuspendLayout();
            this.tabjobinfo.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbJobList
            // 
            this.tbJobList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbJobList.Controls.Add(this.pnlJobDetails);
            this.tbJobList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F);
            this.tbJobList.Location = new System.Drawing.Point(4, 49);
            this.tbJobList.Name = "tbJobList";
            this.tbJobList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbJobList.Size = new System.Drawing.Size(943, 410);
            this.tbJobList.TabIndex = 1;
            this.tbJobList.Text = "Job List";
            // 
            // pnlJobDetails
            // 
            this.pnlJobDetails.BackColor = System.Drawing.Color.White;
            this.pnlJobDetails.Controls.Add(this.btnExportExcel);
            this.pnlJobDetails.Controls.Add(this.lblJobDropDown);
            this.pnlJobDetails.Controls.Add(this.cmbjob);
            this.pnlJobDetails.Controls.Add(this.gvJobdetails);
            this.pnlJobDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJobDetails.Location = new System.Drawing.Point(0, 10);
            this.pnlJobDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlJobDetails.Name = "pnlJobDetails";
            this.pnlJobDetails.Size = new System.Drawing.Size(943, 400);
            this.pnlJobDetails.TabIndex = 20;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnExportExcel.BackgroundImage = global::ToolManagement.Properties.Resources.Excel_2013_logo;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportExcel.Location = new System.Drawing.Point(314, 20);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(44, 28);
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lblJobDropDown
            // 
            this.lblJobDropDown.AutoSize = true;
            this.lblJobDropDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDropDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJobDropDown.Location = new System.Drawing.Point(14, 20);
            this.lblJobDropDown.Name = "lblJobDropDown";
            this.lblJobDropDown.Size = new System.Drawing.Size(28, 15);
            this.lblJobDropDown.TabIndex = 18;
            this.lblJobDropDown.Text = "Job:";
            // 
            // cmbjob
            // 
            this.cmbjob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(47, 20);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(238, 23);
            this.cmbjob.TabIndex = 0;
            this.cmbjob.SelectedIndexChanged += new System.EventHandler(this.cmbjob_SelectedIndexChanged);
            // 
            // gvJobdetails
            // 
            this.gvJobdetails.AllowUserToAddRows = false;
            this.gvJobdetails.AllowUserToDeleteRows = false;
            this.gvJobdetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gvJobdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvJobdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvJobdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvJobdetails.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvJobdetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvJobdetails.EnableHeadersVisualStyles = false;
            this.gvJobdetails.Location = new System.Drawing.Point(8, 63);
            this.gvJobdetails.MultiSelect = false;
            this.gvJobdetails.Name = "gvJobdetails";
            this.gvJobdetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvJobdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvJobdetails.RowHeadersVisible = false;
            this.gvJobdetails.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gvJobdetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvJobdetails.RowTemplate.Height = 32;
            this.gvJobdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvJobdetails.Size = new System.Drawing.Size(928, 297);
            this.gvJobdetails.TabIndex = 1;
            // 
            // tbCreateJob
            // 
            this.tbCreateJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbCreateJob.Controls.Add(this.pnlJopinfo);
            this.tbCreateJob.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F);
            this.tbCreateJob.Location = new System.Drawing.Point(4, 49);
            this.tbCreateJob.Name = "tbCreateJob";
            this.tbCreateJob.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbCreateJob.Size = new System.Drawing.Size(943, 410);
            this.tbCreateJob.TabIndex = 0;
            this.tbCreateJob.Text = "Create Job";
            // 
            // pnlJopinfo
            // 
            this.pnlJopinfo.BackColor = System.Drawing.Color.White;
            this.pnlJopinfo.Controls.Add(this.tab_jobinfo);
            this.pnlJopinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJopinfo.Location = new System.Drawing.Point(0, 10);
            this.pnlJopinfo.Name = "pnlJopinfo";
            this.pnlJopinfo.Size = new System.Drawing.Size(943, 400);
            this.pnlJopinfo.TabIndex = 37;
            // 
            // tab_jobinfo
            // 
            this.tab_jobinfo.Controls.Add(this.tabjobinfo);
            this.tab_jobinfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_jobinfo.ItemSize = new System.Drawing.Size(84, 25);
            this.tab_jobinfo.Location = new System.Drawing.Point(23, 22);
            this.tab_jobinfo.Name = "tab_jobinfo";
            this.tab_jobinfo.SelectedIndex = 0;
            this.tab_jobinfo.Size = new System.Drawing.Size(513, 254);
            this.tab_jobinfo.TabIndex = 27;
            // 
            // tabjobinfo
            // 
            this.tabjobinfo.Controls.Add(this.txtjobDesc);
            this.tabjobinfo.Controls.Add(this.txtjobname);
            this.tabjobinfo.Controls.Add(this.lblNotes);
            this.tabjobinfo.Controls.Add(this.lbljobname);
            this.tabjobinfo.Controls.Add(this.btnAdd);
            this.tabjobinfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabjobinfo.Location = new System.Drawing.Point(4, 29);
            this.tabjobinfo.Name = "tabjobinfo";
            this.tabjobinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabjobinfo.Size = new System.Drawing.Size(505, 221);
            this.tabjobinfo.TabIndex = 0;
            this.tabjobinfo.Text = "Job Information";
            this.tabjobinfo.UseVisualStyleBackColor = true;
            // 
            // txtjobDesc
            // 
            this.txtjobDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjobDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtjobDesc.Location = new System.Drawing.Point(116, 60);
            this.txtjobDesc.Margin = new System.Windows.Forms.Padding(7);
            this.txtjobDesc.Multiline = true;
            this.txtjobDesc.Name = "txtjobDesc";
            this.txtjobDesc.Size = new System.Drawing.Size(272, 115);
            this.txtjobDesc.TabIndex = 1;
            // 
            // txtjobname
            // 
            this.txtjobname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjobname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtjobname.Location = new System.Drawing.Point(116, 19);
            this.txtjobname.Margin = new System.Windows.Forms.Padding(7);
            this.txtjobname.Name = "txtjobname";
            this.txtjobname.Size = new System.Drawing.Size(272, 23);
            this.txtjobname.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNotes.Location = new System.Drawing.Point(76, 63);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 15);
            this.lblNotes.TabIndex = 36;
            this.lblNotes.Text = "&Notes:";
            // 
            // lbljobname
            // 
            this.lbljobname.AutoSize = true;
            this.lbljobname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljobname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbljobname.Location = new System.Drawing.Point(56, 22);
            this.lbljobname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbljobname.Name = "lbljobname";
            this.lbljobname.Size = new System.Drawing.Size(63, 15);
            this.lbljobname.TabIndex = 35;
            this.lbljobname.Text = "&Job Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(212, 184);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Create";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabJobs
            // 
            this.tabJobs.Controls.Add(this.tbCreateJob);
            this.tabJobs.Controls.Add(this.tbJobList);
            this.tabJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJobs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabJobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabJobs.HotTrack = true;
            this.tabJobs.ItemSize = new System.Drawing.Size(120, 45);
            this.tabJobs.Location = new System.Drawing.Point(0, 0);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Drawing.Point(10, 6);
            this.tabJobs.SelectedIndex = 0;
            this.tabJobs.Size = new System.Drawing.Size(951, 463);
            this.tabJobs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabJobs.TabIndex = 4;
            this.tabJobs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabJobs_DrawItem);
            this.tabJobs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabJobs_Selected);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 463);
            this.Controls.Add(this.tabJobs);
            this.Name = "Job";
            this.Text = "Job";
            this.tbJobList.ResumeLayout(false);
            this.pnlJobDetails.ResumeLayout(false);
            this.pnlJobDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobdetails)).EndInit();
            this.tbCreateJob.ResumeLayout(false);
            this.pnlJopinfo.ResumeLayout(false);
            this.tab_jobinfo.ResumeLayout(false);
            this.tabjobinfo.ResumeLayout(false);
            this.tabjobinfo.PerformLayout();
            this.tabJobs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbJobList;
        private System.Windows.Forms.TabPage tbCreateJob;
        private System.Windows.Forms.TabControl tabJobs;
        private System.Windows.Forms.TabControl tab_jobinfo;
        private System.Windows.Forms.TabPage tabjobinfo;
        private System.Windows.Forms.TextBox txtjobDesc;
        private System.Windows.Forms.TextBox txtjobname;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lbljobname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblJobDropDown;
        private System.Windows.Forms.DataGridView gvJobdetails;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.Panel pnlJobDetails;
        private System.Windows.Forms.Panel pnlJopinfo;
        private System.Windows.Forms.Button btnExportExcel;


    }
}