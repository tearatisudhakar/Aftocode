namespace ToolManagement
{
    partial class WithdrawKit
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
            this.lblJob = new System.Windows.Forms.Label();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.lblToolUser = new System.Windows.Forms.Label();
            this.lblAsOnDate = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.gvWithdrawkit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvWithdrawkit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJob.Location = new System.Drawing.Point(45, 11);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(28, 15);
            this.lblJob.TabIndex = 30;
            this.lblJob.Text = "Job:";
            this.lblJob.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbjob
            // 
            this.cmbjob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(75, 9);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(133, 23);
            this.cmbjob.TabIndex = 29;
            this.cmbjob.SelectedIndexChanged += new System.EventHandler(this.cmbjob_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 23);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(740, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 29);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(632, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 29);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Conform Issue ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAssignTo.Location = new System.Drawing.Point(307, 11);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(121, 15);
            this.lblAssignTo.TabIndex = 18;
            this.lblAssignTo.Text = "Assign to tool user Id:";
            this.lblAssignTo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblToolUser
            // 
            this.lblToolUser.AutoSize = true;
            this.lblToolUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblToolUser.Location = new System.Drawing.Point(17, 54);
            this.lblToolUser.Name = "lblToolUser";
            this.lblToolUser.Size = new System.Drawing.Size(58, 15);
            this.lblToolUser.TabIndex = 17;
            this.lblToolUser.Text = "Tool user:";
            this.lblToolUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAsOnDate
            // 
            this.lblAsOnDate.AutoSize = true;
            this.lblAsOnDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsOnDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsOnDate.Location = new System.Drawing.Point(388, 54);
            this.lblAsOnDate.Name = "lblAsOnDate";
            this.lblAsOnDate.Size = new System.Drawing.Size(40, 15);
            this.lblAsOnDate.TabIndex = 22;
            this.lblAsOnDate.Text = "As on:";
            this.lblAsOnDate.Click += new System.EventHandler(this.lblAsOnDate_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtusername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(75, 53);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(133, 23);
            this.txtusername.TabIndex = 26;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.Location = new System.Drawing.Point(432, 9);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.ReadOnly = true;
            this.txtUserid.Size = new System.Drawing.Size(113, 23);
            this.txtUserid.TabIndex = 25;
            this.txtUserid.TextChanged += new System.EventHandler(this.txtUserid_TextChanged);
            // 
            // gvWithdrawkit
            // 
            this.gvWithdrawkit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWithdrawkit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWithdrawkit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvWithdrawkit.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvWithdrawkit.Location = new System.Drawing.Point(14, 102);
            this.gvWithdrawkit.Name = "gvWithdrawkit";
            this.gvWithdrawkit.Size = new System.Drawing.Size(824, 150);
            this.gvWithdrawkit.TabIndex = 31;
            // 
            // WithdrawKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(866, 307);
            this.Controls.Add(this.gvWithdrawkit);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.cmbjob);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.lblToolUser);
            this.Controls.Add(this.lblAsOnDate);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtUserid);
            this.Name = "WithdrawKit";
            this.Text = "WithdrawKit";
            this.Load += new System.EventHandler(this.WithdrawKit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvWithdrawkit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.Label lblToolUser;
        private System.Windows.Forms.Label lblAsOnDate;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.DataGridView gvWithdrawkit;
    }
}