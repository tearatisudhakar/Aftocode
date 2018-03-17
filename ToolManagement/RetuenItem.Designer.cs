namespace ToolManagement
{
    partial class ReturnItem
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIssueQty = new System.Windows.Forms.Label();
            this.lblAsOnDate = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTooluserid = new System.Windows.Forms.Label();
            this.lblToolusername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.rdbUsed = new System.Windows.Forms.RadioButton();
            this.rdbUnused = new System.Windows.Forms.RadioButton();
            this.lblitemType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItemcatagiry = new System.Windows.Forms.Label();
            this.lblItemLocation = new System.Windows.Forms.Label();
            this.lblItemDecription = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.grpboximage = new System.Windows.Forms.GroupBox();
            this.picBxforIssue = new System.Windows.Forms.PictureBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpboximage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2017, 9, 23, 15, 8, 40, 0);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown1.Location = new System.Drawing.Point(240, 194);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(214, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(365, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(280, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIssueQty
            // 
            this.lblIssueQty.AutoSize = true;
            this.lblIssueQty.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIssueQty.Location = new System.Drawing.Point(127, 194);
            this.lblIssueQty.Name = "lblIssueQty";
            this.lblIssueQty.Size = new System.Drawing.Size(107, 15);
            this.lblIssueQty.TabIndex = 19;
            this.lblIssueQty.Text = "Quantity Returned:";
            // 
            // lblAsOnDate
            // 
            this.lblAsOnDate.AutoSize = true;
            this.lblAsOnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAsOnDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsOnDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsOnDate.Location = new System.Drawing.Point(188, 224);
            this.lblAsOnDate.Name = "lblAsOnDate";
            this.lblAsOnDate.Size = new System.Drawing.Size(42, 15);
            this.lblAsOnDate.TabIndex = 22;
            this.lblAsOnDate.Text = "As On:";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLocation.Location = new System.Drawing.Point(240, 159);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(215, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // txtItemcode
            // 
            this.txtItemcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemcode.Location = new System.Drawing.Point(240, 84);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.ReadOnly = true;
            this.txtItemcode.Size = new System.Drawing.Size(215, 20);
            this.txtItemcode.TabIndex = 1;
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtdesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtdesc.Location = new System.Drawing.Point(240, 121);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(215, 20);
            this.txtdesc.TabIndex = 2;
            // 
            // txtIndex
            // 
            this.txtIndex.BackColor = System.Drawing.SystemColors.Window;
            this.txtIndex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIndex.Location = new System.Drawing.Point(240, 50);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(215, 20);
            this.txtIndex.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTooluserid);
            this.groupBox1.Controls.Add(this.lblToolusername);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtUserid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(98, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // lblTooluserid
            // 
            this.lblTooluserid.AutoSize = true;
            this.lblTooluserid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooluserid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTooluserid.Location = new System.Drawing.Point(54, 29);
            this.lblTooluserid.Name = "lblTooluserid";
            this.lblTooluserid.Size = new System.Drawing.Size(73, 15);
            this.lblTooluserid.TabIndex = 27;
            this.lblTooluserid.Text = "Tool User ID:";
            // 
            // lblToolusername
            // 
            this.lblToolusername.AutoSize = true;
            this.lblToolusername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolusername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblToolusername.Location = new System.Drawing.Point(26, 63);
            this.lblToolusername.Name = "lblToolusername";
            this.lblToolusername.Size = new System.Drawing.Size(97, 15);
            this.lblToolusername.TabIndex = 26;
            this.lblToolusername.Text = "Tool  User Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.Location = new System.Drawing.Point(142, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(215, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserid.Location = new System.Drawing.Point(142, 22);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.ReadOnly = true;
            this.txtUserid.Size = new System.Drawing.Size(215, 23);
            this.txtUserid.TabIndex = 0;
            // 
            // rdbUsed
            // 
            this.rdbUsed.AutoSize = true;
            this.rdbUsed.Checked = true;
            this.rdbUsed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUsed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdbUsed.Location = new System.Drawing.Point(30, 17);
            this.rdbUsed.Name = "rdbUsed";
            this.rdbUsed.Size = new System.Drawing.Size(51, 19);
            this.rdbUsed.TabIndex = 0;
            this.rdbUsed.TabStop = true;
            this.rdbUsed.Text = "Used";
            this.rdbUsed.UseVisualStyleBackColor = true;
            // 
            // rdbUnused
            // 
            this.rdbUnused.AutoSize = true;
            this.rdbUnused.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUnused.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdbUnused.Location = new System.Drawing.Point(91, 17);
            this.rdbUnused.Name = "rdbUnused";
            this.rdbUnused.Size = new System.Drawing.Size(65, 19);
            this.rdbUnused.TabIndex = 1;
            this.rdbUnused.Text = "Unused";
            this.rdbUnused.UseVisualStyleBackColor = true;
            // 
            // lblitemType
            // 
            this.lblitemType.AutoSize = true;
            this.lblitemType.BackColor = System.Drawing.Color.Transparent;
            this.lblitemType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblitemType.Location = new System.Drawing.Point(169, 266);
            this.lblitemType.Name = "lblitemType";
            this.lblitemType.Size = new System.Drawing.Size(62, 15);
            this.lblitemType.TabIndex = 34;
            this.lblitemType.Text = "Item Type:";
            this.lblitemType.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbUnused);
            this.groupBox2.Controls.Add(this.rdbUsed);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(238, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblItemcatagiry
            // 
            this.lblItemcatagiry.AutoSize = true;
            this.lblItemcatagiry.BackColor = System.Drawing.Color.Transparent;
            this.lblItemcatagiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemcatagiry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemcatagiry.Location = new System.Drawing.Point(147, 48);
            this.lblItemcatagiry.Name = "lblItemcatagiry";
            this.lblItemcatagiry.Size = new System.Drawing.Size(85, 15);
            this.lblItemcatagiry.TabIndex = 40;
            this.lblItemcatagiry.Text = "Item Category:";
            this.lblItemcatagiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemLocation
            // 
            this.lblItemLocation.AutoSize = true;
            this.lblItemLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblItemLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemLocation.Location = new System.Drawing.Point(149, 157);
            this.lblItemLocation.Name = "lblItemLocation";
            this.lblItemLocation.Size = new System.Drawing.Size(83, 15);
            this.lblItemLocation.TabIndex = 39;
            this.lblItemLocation.Text = "Item Location:";
            this.lblItemLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemDecription
            // 
            this.lblItemDecription.AutoSize = true;
            this.lblItemDecription.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDecription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDecription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemDecription.Location = new System.Drawing.Point(135, 121);
            this.lblItemDecription.Name = "lblItemDecription";
            this.lblItemDecription.Size = new System.Drawing.Size(97, 15);
            this.lblItemDecription.TabIndex = 38;
            this.lblItemDecription.Text = "Item Description:";
            this.lblItemDecription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Location = new System.Drawing.Point(166, 84);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(65, 15);
            this.lblItemCode.TabIndex = 37;
            this.lblItemCode.Text = "Item Code:";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpboximage
            // 
            this.grpboximage.BackColor = System.Drawing.Color.Transparent;
            this.grpboximage.Controls.Add(this.picBxforIssue);
            this.grpboximage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboximage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpboximage.Location = new System.Drawing.Point(489, 52);
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
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJob.Location = new System.Drawing.Point(200, 306);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(31, 15);
            this.lblJob.TabIndex = 52;
            this.lblJob.Text = "Job :";
            // 
            // cmbjob
            // 
            this.cmbjob.BackColor = System.Drawing.Color.White;
            this.cmbjob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(238, 306);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(176, 23);
            this.cmbjob.TabIndex = 51;
            // 
            // ReturnItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 537);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.cmbjob);
            this.Controls.Add(this.grpboximage);
            this.Controls.Add(this.lblItemcatagiry);
            this.Controls.Add(this.lblItemLocation);
            this.Controls.Add(this.lblItemDecription);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblitemType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblIssueQty);
            this.Controls.Add(this.lblAsOnDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtItemcode);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpboximage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIssueQty;
        private System.Windows.Forms.Label lblAsOnDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTooluserid;
        private System.Windows.Forms.Label lblToolusername;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.RadioButton rdbUsed;
        private System.Windows.Forms.RadioButton rdbUnused;
        private System.Windows.Forms.Label lblitemType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemcatagiry;
        private System.Windows.Forms.Label lblItemLocation;
        private System.Windows.Forms.Label lblItemDecription;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.GroupBox grpboximage;
        private System.Windows.Forms.PictureBox picBxforIssue;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cmbjob;
    }
}