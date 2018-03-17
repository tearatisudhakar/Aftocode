namespace ToolManagement
{
    partial class IssueItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.lblAsOnDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblItemLocation = new System.Windows.Forms.Label();
            this.lblItemDescprion = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.pnlIssueItem = new System.Windows.Forms.Panel();
            this.btnIssueNext = new System.Windows.Forms.Button();
            this.gvIssueItems = new System.Windows.Forms.DataGridView();
            this.btnjobadd = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.grbItemType = new System.Windows.Forms.GroupBox();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.lblUsed = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtAvailableQnty = new System.Windows.Forms.TextBox();
            this.lblAvailableqnty = new System.Windows.Forms.Label();
            this.grpIssuedBy = new System.Windows.Forms.GroupBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.grpboximage = new System.Windows.Forms.GroupBox();
            this.picBxforIssue = new System.Windows.Forms.PictureBox();
            this.touchScreen1 = new ToolManagement.Controls.TouchScreen();
            this.pnlIssueItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIssueItems)).BeginInit();
            this.grbItemType.SuspendLayout();
            this.grpIssuedBy.SuspendLayout();
            this.grpboximage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIndex.Location = new System.Drawing.Point(251, 14);
            this.txtIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(233, 27);
            this.txtIndex.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDesc.Location = new System.Drawing.Point(251, 110);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 27);
            this.txtDesc.TabIndex = 2;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemCode.Location = new System.Drawing.Point(251, 62);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(233, 27);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtItemCode_MouseDown);
            // 
            // txtlocation
            // 
            this.txtlocation.BackColor = System.Drawing.Color.White;
            this.txtlocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtlocation.Location = new System.Drawing.Point(251, 158);
            this.txtlocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.ReadOnly = true;
            this.txtlocation.Size = new System.Drawing.Size(233, 27);
            this.txtlocation.TabIndex = 3;
            // 
            // lblAsOnDate
            // 
            this.lblAsOnDate.AutoSize = true;
            this.lblAsOnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAsOnDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsOnDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsOnDate.Location = new System.Drawing.Point(167, 207);
            this.lblAsOnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsOnDate.Name = "lblAsOnDate";
            this.lblAsOnDate.Size = new System.Drawing.Size(72, 20);
            this.lblAsOnDate.TabIndex = 5;
            this.lblAsOnDate.Text = "Issed On :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(987, 44);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Issue ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1105, 44);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 204);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 32);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbjob
            // 
            this.cmbjob.BackColor = System.Drawing.Color.White;
            this.cmbjob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(251, 257);
            this.cmbjob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(233, 27);
            this.cmbjob.TabIndex = 6;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJob.Location = new System.Drawing.Point(203, 257);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(39, 20);
            this.lblJob.TabIndex = 13;
            this.lblJob.Text = "Job :";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGroup.Location = new System.Drawing.Point(151, 14);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(87, 20);
            this.lblGroup.TabIndex = 48;
            this.lblGroup.Text = "Item Group:";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemLocation
            // 
            this.lblItemLocation.AutoSize = true;
            this.lblItemLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblItemLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemLocation.Location = new System.Drawing.Point(133, 158);
            this.lblItemLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemLocation.Name = "lblItemLocation";
            this.lblItemLocation.Size = new System.Drawing.Size(103, 20);
            this.lblItemLocation.TabIndex = 47;
            this.lblItemLocation.Text = "Item Location:";
            this.lblItemLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemDescprion
            // 
            this.lblItemDescprion.AutoSize = true;
            this.lblItemDescprion.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDescprion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescprion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemDescprion.Location = new System.Drawing.Point(115, 110);
            this.lblItemDescprion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDescprion.Name = "lblItemDescprion";
            this.lblItemDescprion.Size = new System.Drawing.Size(122, 20);
            this.lblItemDescprion.TabIndex = 46;
            this.lblItemDescprion.Text = "Item Description:";
            this.lblItemDescprion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Location = new System.Drawing.Point(157, 62);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(81, 20);
            this.lblItemCode.TabIndex = 45;
            this.lblItemCode.Text = "Item Code:";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlIssueItem
            // 
            this.pnlIssueItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIssueItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIssueItem.Controls.Add(this.btnIssueNext);
            this.pnlIssueItem.Controls.Add(this.gvIssueItems);
            this.pnlIssueItem.Controls.Add(this.btnjobadd);
            this.pnlIssueItem.Controls.Add(this.txtReturn);
            this.pnlIssueItem.Controls.Add(this.lblReturn);
            this.pnlIssueItem.Controls.Add(this.grbItemType);
            this.pnlIssueItem.Controls.Add(this.txtAvailableQnty);
            this.pnlIssueItem.Controls.Add(this.lblAvailableqnty);
            this.pnlIssueItem.Controls.Add(this.grpIssuedBy);
            this.pnlIssueItem.Controls.Add(this.grpboximage);
            this.pnlIssueItem.Controls.Add(this.txtIndex);
            this.pnlIssueItem.Controls.Add(this.lblGroup);
            this.pnlIssueItem.Controls.Add(this.txtDesc);
            this.pnlIssueItem.Controls.Add(this.lblItemLocation);
            this.pnlIssueItem.Controls.Add(this.txtItemCode);
            this.pnlIssueItem.Controls.Add(this.lblItemDescprion);
            this.pnlIssueItem.Controls.Add(this.txtlocation);
            this.pnlIssueItem.Controls.Add(this.lblItemCode);
            this.pnlIssueItem.Controls.Add(this.lblJob);
            this.pnlIssueItem.Controls.Add(this.cmbjob);
            this.pnlIssueItem.Controls.Add(this.lblAsOnDate);
            this.pnlIssueItem.Controls.Add(this.dateTimePicker1);
            this.pnlIssueItem.Controls.Add(this.btnCancel);
            this.pnlIssueItem.Controls.Add(this.btnSave);
            this.pnlIssueItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIssueItem.Location = new System.Drawing.Point(0, 0);
            this.pnlIssueItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIssueItem.Name = "pnlIssueItem";
            this.pnlIssueItem.Size = new System.Drawing.Size(1283, 743);
            this.pnlIssueItem.TabIndex = 49;
            // 
            // btnIssueNext
            // 
            this.btnIssueNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnIssueNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueNext.ForeColor = System.Drawing.Color.White;
            this.btnIssueNext.Location = new System.Drawing.Point(961, 44);
            this.btnIssueNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIssueNext.Name = "btnIssueNext";
            this.btnIssueNext.Size = new System.Drawing.Size(136, 36);
            this.btnIssueNext.TabIndex = 59;
            this.btnIssueNext.Text = "Issue && Next";
            this.btnIssueNext.UseVisualStyleBackColor = false;
            this.btnIssueNext.Visible = false;
            this.btnIssueNext.Click += new System.EventHandler(this.btnIssueNext_Click);
            // 
            // gvIssueItems
            // 
            this.gvIssueItems.AllowUserToAddRows = false;
            this.gvIssueItems.AllowUserToDeleteRows = false;
            this.gvIssueItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.gvIssueItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvIssueItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvIssueItems.ColumnHeadersHeight = 36;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvIssueItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvIssueItems.EnableHeadersVisualStyles = false;
            this.gvIssueItems.Location = new System.Drawing.Point(57, 468);
            this.gvIssueItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gvIssueItems.MultiSelect = false;
            this.gvIssueItems.Name = "gvIssueItems";
            this.gvIssueItems.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvIssueItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvIssueItems.RowHeadersVisible = false;
            this.gvIssueItems.RowHeadersWidth = 30;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.gvIssueItems.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvIssueItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvIssueItems.RowTemplate.Height = 32;
            this.gvIssueItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIssueItems.Size = new System.Drawing.Size(1207, 245);
            this.gvIssueItems.TabIndex = 58;
            this.gvIssueItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIssueItems_CellClick);
            // 
            // btnjobadd
            // 
            this.btnjobadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnjobadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjobadd.ForeColor = System.Drawing.Color.White;
            this.btnjobadd.Location = new System.Drawing.Point(493, 253);
            this.btnjobadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnjobadd.Name = "btnjobadd";
            this.btnjobadd.Size = new System.Drawing.Size(55, 33);
            this.btnjobadd.TabIndex = 57;
            this.btnjobadd.Text = "...";
            this.btnjobadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnjobadd.UseVisualStyleBackColor = false;
            this.btnjobadd.Visible = false;
            this.btnjobadd.Click += new System.EventHandler(this.btnjobadd_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.BackColor = System.Drawing.Color.White;
            this.txtReturn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReturn.Location = new System.Drawing.Point(249, 332);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.ReadOnly = true;
            this.txtReturn.Size = new System.Drawing.Size(233, 27);
            this.txtReturn.TabIndex = 8;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReturn.Location = new System.Drawing.Point(111, 337);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(136, 20);
            this.lblReturn.TabIndex = 56;
            this.lblReturn.Text = "Returned Quantity :";
            // 
            // grbItemType
            // 
            this.grbItemType.Controls.Add(this.txtUsed);
            this.grbItemType.Controls.Add(this.lblUsed);
            this.grbItemType.Controls.Add(this.txtNew);
            this.grbItemType.Controls.Add(this.lblNew);
            this.grbItemType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbItemType.Location = new System.Drawing.Point(91, 362);
            this.grbItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbItemType.Name = "grbItemType";
            this.grbItemType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbItemType.Size = new System.Drawing.Size(395, 79);
            this.grbItemType.TabIndex = 9;
            this.grbItemType.TabStop = false;
            this.grbItemType.Text = "Issue type:";
            // 
            // txtUsed
            // 
            this.txtUsed.BackColor = System.Drawing.Color.White;
            this.txtUsed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsed.Location = new System.Drawing.Point(159, 49);
            this.txtUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.Size = new System.Drawing.Size(233, 27);
            this.txtUsed.TabIndex = 1;
            this.txtUsed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsed_KeyPress);
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Location = new System.Drawing.Point(100, 57);
            this.lblUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(49, 17);
            this.lblUsed.TabIndex = 57;
            this.lblUsed.Text = "Used :";
            // 
            // txtNew
            // 
            this.txtNew.BackColor = System.Drawing.Color.White;
            this.txtNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNew.Location = new System.Drawing.Point(157, 11);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(233, 27);
            this.txtNew.TabIndex = 0;
            this.txtNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNew_KeyPress);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(99, 22);
            this.lblNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(43, 17);
            this.lblNew.TabIndex = 55;
            this.lblNew.Text = "New :";
            // 
            // txtAvailableQnty
            // 
            this.txtAvailableQnty.BackColor = System.Drawing.Color.White;
            this.txtAvailableQnty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQnty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAvailableQnty.Location = new System.Drawing.Point(251, 297);
            this.txtAvailableQnty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAvailableQnty.Name = "txtAvailableQnty";
            this.txtAvailableQnty.ReadOnly = true;
            this.txtAvailableQnty.Size = new System.Drawing.Size(233, 27);
            this.txtAvailableQnty.TabIndex = 7;
            // 
            // lblAvailableqnty
            // 
            this.lblAvailableqnty.AutoSize = true;
            this.lblAvailableqnty.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableqnty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableqnty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvailableqnty.Location = new System.Drawing.Point(97, 302);
            this.lblAvailableqnty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableqnty.Name = "lblAvailableqnty";
            this.lblAvailableqnty.Size = new System.Drawing.Size(138, 20);
            this.lblAvailableqnty.TabIndex = 53;
            this.lblAvailableqnty.Text = "Available Quantity :";
            // 
            // grpIssuedBy
            // 
            this.grpIssuedBy.Controls.Add(this.txtUserid);
            this.grpIssuedBy.Controls.Add(this.txtusername);
            this.grpIssuedBy.Controls.Add(this.lblUsername);
            this.grpIssuedBy.Controls.Add(this.lblUserid);
            this.grpIssuedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpIssuedBy.Location = new System.Drawing.Point(563, 314);
            this.grpIssuedBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIssuedBy.Name = "grpIssuedBy";
            this.grpIssuedBy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIssuedBy.Size = new System.Drawing.Size(395, 121);
            this.grpIssuedBy.TabIndex = 51;
            this.grpIssuedBy.TabStop = false;
            this.grpIssuedBy.Text = "Issued By";
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.Color.White;
            this.txtUserid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserid.Location = new System.Drawing.Point(159, 28);
            this.txtUserid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.ReadOnly = true;
            this.txtUserid.Size = new System.Drawing.Size(233, 27);
            this.txtUserid.TabIndex = 11;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtusername.Location = new System.Drawing.Point(159, 76);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(233, 27);
            this.txtusername.TabIndex = 12;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsername.Location = new System.Drawing.Point(19, 76);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 20);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Tool User Name :";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.BackColor = System.Drawing.Color.Transparent;
            this.lblUserid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserid.Location = new System.Drawing.Point(47, 28);
            this.lblUserid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(97, 20);
            this.lblUserid.TabIndex = 10;
            this.lblUserid.Text = "Tool User ID :";
            // 
            // grpboximage
            // 
            this.grpboximage.BackColor = System.Drawing.Color.Transparent;
            this.grpboximage.Controls.Add(this.picBxforIssue);
            this.grpboximage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboximage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpboximage.Location = new System.Drawing.Point(563, 5);
            this.grpboximage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboximage.Name = "grpboximage";
            this.grpboximage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboximage.Size = new System.Drawing.Size(392, 303);
            this.grpboximage.TabIndex = 49;
            this.grpboximage.TabStop = false;
            this.grpboximage.Text = "ToolImage";
            // 
            // picBxforIssue
            // 
            this.picBxforIssue.Location = new System.Drawing.Point(13, 26);
            this.picBxforIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBxforIssue.Name = "picBxforIssue";
            this.picBxforIssue.Size = new System.Drawing.Size(368, 265);
            this.picBxforIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxforIssue.TabIndex = 50;
            this.picBxforIssue.TabStop = false;
            // 
            // touchScreen1
            // 
            this.touchScreen1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.touchScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.touchScreen1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.touchScreen1.Location = new System.Drawing.Point(515, 39);
            this.touchScreen1.Margin = new System.Windows.Forms.Padding(5);
            this.touchScreen1.Name = "touchScreen1";
            this.touchScreen1.Size = new System.Drawing.Size(189, 283);
            this.touchScreen1.TabIndex = 57;
            // 
            // IssueItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1283, 743);
            this.Controls.Add(this.pnlIssueItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Item";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.pnlIssueItem.ResumeLayout(false);
            this.pnlIssueItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIssueItems)).EndInit();
            this.grbItemType.ResumeLayout(false);
            this.grbItemType.PerformLayout();
            this.grpIssuedBy.ResumeLayout(false);
            this.grpIssuedBy.PerformLayout();
            this.grpboximage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxforIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label lblAsOnDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblItemLocation;
        private System.Windows.Forms.Label lblItemDescprion;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Panel pnlIssueItem;
        private System.Windows.Forms.GroupBox grpboximage;
        private System.Windows.Forms.PictureBox picBxforIssue;
        private System.Windows.Forms.TextBox txtAvailableQnty;
        private System.Windows.Forms.Label lblAvailableqnty;
        private System.Windows.Forms.GroupBox grpIssuedBy;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.GroupBox grbItemType;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label lblReturn;
        private Controls.TouchScreen touchScreen1;
        private System.Windows.Forms.Button btnjobadd;
        private System.Windows.Forms.DataGridView gvIssueItems;
        private System.Windows.Forms.Button btnIssueNext;
    }
}