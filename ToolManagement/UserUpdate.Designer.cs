namespace ToolManagement
{
    partial class UserUpdate
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
            this.components = new System.ComponentModel.Container();
            this.lbluserrole1 = new System.Windows.Forms.Label();
            this.Cboxusertype = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnuserUpdate = new System.Windows.Forms.Button();
            this.chkConfiguration = new System.Windows.Forms.CheckBox();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.chkItemManagement = new System.Windows.Forms.CheckBox();
            this.chkJobs = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkGeneral = new System.Windows.Forms.CheckBox();
            this.grpbxAccessLevel = new System.Windows.Forms.GroupBox();
            this.chkLevel3 = new System.Windows.Forms.CheckBox();
            this.chkLevel2 = new System.Windows.Forms.CheckBox();
            this.chkLevel1 = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtJobTittle = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblJobTittle = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbxAccessLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserrole1
            // 
            this.lbluserrole1.AutoSize = true;
            this.lbluserrole1.BackColor = System.Drawing.Color.Transparent;
            this.lbluserrole1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserrole1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbluserrole1.Location = new System.Drawing.Point(462, 277);
            this.lbluserrole1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluserrole1.Name = "lbluserrole1";
            this.lbluserrole1.Size = new System.Drawing.Size(59, 15);
            this.lbluserrole1.TabIndex = 192;
            this.lbluserrole1.Text = "User Role:";
            // 
            // Cboxusertype
            // 
            this.Cboxusertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboxusertype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cboxusertype.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cboxusertype.FormattingEnabled = true;
            this.Cboxusertype.Items.AddRange(new object[] {
            "Admin",
            "Operator"});
            this.Cboxusertype.Location = new System.Drawing.Point(521, 274);
            this.Cboxusertype.Name = "Cboxusertype";
            this.Cboxusertype.Size = new System.Drawing.Size(157, 23);
            this.Cboxusertype.TabIndex = 174;
            this.Cboxusertype.SelectionChangeCommitted += new System.EventHandler(this.Cboxusertype_SelectionChangeCommitted);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(866, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 39);
            this.btnReset.TabIndex = 184;
            this.btnReset.Text = "&Cancel";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnuserUpdate
            // 
            this.btnuserUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnuserUpdate.FlatAppearance.BorderSize = 2;
            this.btnuserUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnuserUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnuserUpdate.Location = new System.Drawing.Point(771, 319);
            this.btnuserUpdate.Name = "btnuserUpdate";
            this.btnuserUpdate.Size = new System.Drawing.Size(89, 39);
            this.btnuserUpdate.TabIndex = 182;
            this.btnuserUpdate.Text = "&Update";
            this.btnuserUpdate.UseVisualStyleBackColor = false;
            this.btnuserUpdate.Click += new System.EventHandler(this.btnuserUpdate_Click);
            // 
            // chkConfiguration
            // 
            this.chkConfiguration.AutoSize = true;
            this.chkConfiguration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfiguration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkConfiguration.Location = new System.Drawing.Point(869, 209);
            this.chkConfiguration.Name = "chkConfiguration";
            this.chkConfiguration.Size = new System.Drawing.Size(100, 19);
            this.chkConfiguration.TabIndex = 181;
            this.chkConfiguration.Text = "Configuration";
            this.chkConfiguration.UseVisualStyleBackColor = true;
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupplier.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkSupplier.Location = new System.Drawing.Point(869, 180);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(69, 19);
            this.chkSupplier.TabIndex = 180;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            // 
            // chkItemManagement
            // 
            this.chkItemManagement.AutoSize = true;
            this.chkItemManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItemManagement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkItemManagement.Location = new System.Drawing.Point(869, 93);
            this.chkItemManagement.Name = "chkItemManagement";
            this.chkItemManagement.Size = new System.Drawing.Size(124, 19);
            this.chkItemManagement.TabIndex = 177;
            this.chkItemManagement.Text = "Item Management";
            this.chkItemManagement.UseVisualStyleBackColor = true;
            // 
            // chkJobs
            // 
            this.chkJobs.AutoSize = true;
            this.chkJobs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJobs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkJobs.Location = new System.Drawing.Point(870, 122);
            this.chkJobs.Name = "chkJobs";
            this.chkJobs.Size = new System.Drawing.Size(49, 19);
            this.chkJobs.TabIndex = 178;
            this.chkJobs.Text = "Jobs";
            this.chkJobs.UseVisualStyleBackColor = true;
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReports.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkReports.Location = new System.Drawing.Point(869, 151);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(66, 19);
            this.chkReports.TabIndex = 179;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // chkGeneral
            // 
            this.chkGeneral.AutoSize = true;
            this.chkGeneral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGeneral.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkGeneral.Location = new System.Drawing.Point(869, 63);
            this.chkGeneral.Name = "chkGeneral";
            this.chkGeneral.Size = new System.Drawing.Size(66, 19);
            this.chkGeneral.TabIndex = 176;
            this.chkGeneral.Text = "General";
            this.chkGeneral.UseVisualStyleBackColor = true;
            // 
            // grpbxAccessLevel
            // 
            this.grpbxAccessLevel.Controls.Add(this.chkLevel3);
            this.grpbxAccessLevel.Controls.Add(this.chkLevel2);
            this.grpbxAccessLevel.Controls.Add(this.chkLevel1);
            this.grpbxAccessLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAccessLevel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpbxAccessLevel.Location = new System.Drawing.Point(522, 309);
            this.grpbxAccessLevel.Name = "grpbxAccessLevel";
            this.grpbxAccessLevel.Size = new System.Drawing.Size(217, 54);
            this.grpbxAccessLevel.TabIndex = 175;
            this.grpbxAccessLevel.TabStop = false;
            this.grpbxAccessLevel.Text = "Access level";
            // 
            // chkLevel3
            // 
            this.chkLevel3.AutoSize = true;
            this.chkLevel3.Location = new System.Drawing.Point(150, 22);
            this.chkLevel3.Name = "chkLevel3";
            this.chkLevel3.Size = new System.Drawing.Size(62, 19);
            this.chkLevel3.TabIndex = 2;
            this.chkLevel3.Text = "Level 3";
            this.chkLevel3.UseVisualStyleBackColor = true;
            this.chkLevel3.Enter += new System.EventHandler(this.chkLevel3_Enter);
            // 
            // chkLevel2
            // 
            this.chkLevel2.AutoSize = true;
            this.chkLevel2.Location = new System.Drawing.Point(76, 22);
            this.chkLevel2.Name = "chkLevel2";
            this.chkLevel2.Size = new System.Drawing.Size(62, 19);
            this.chkLevel2.TabIndex = 1;
            this.chkLevel2.Text = "Level 2";
            this.chkLevel2.UseVisualStyleBackColor = true;
            this.chkLevel2.Enter += new System.EventHandler(this.chkLevel2_Enter);
            // 
            // chkLevel1
            // 
            this.chkLevel1.AutoSize = true;
            this.chkLevel1.Location = new System.Drawing.Point(6, 22);
            this.chkLevel1.Name = "chkLevel1";
            this.chkLevel1.Size = new System.Drawing.Size(62, 19);
            this.chkLevel1.TabIndex = 0;
            this.chkLevel1.Text = "Level 1";
            this.chkLevel1.UseVisualStyleBackColor = true;
            this.chkLevel1.Enter += new System.EventHandler(this.chkLevel1_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserName.Location = new System.Drawing.Point(105, 189);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(289, 25);
            this.txtUserName.TabIndex = 157;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFirstName.Location = new System.Drawing.Point(40, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 15);
            this.lblFirstName.TabIndex = 185;
            this.lblFirstName.Text = "First name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(105, 310);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(289, 23);
            this.cmbDepartment.TabIndex = 161;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(63, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 158;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserName.Location = new System.Drawing.Point(39, 190);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 15);
            this.lblUserName.TabIndex = 155;
            this.lblUserName.Text = "User name:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLastName.Location = new System.Drawing.Point(41, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 15);
            this.lblLastName.TabIndex = 156;
            this.lblLastName.Text = "Last name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFirstName.Location = new System.Drawing.Point(105, 59);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(289, 25);
            this.txtFirstName.TabIndex = 152;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCompany.Location = new System.Drawing.Point(523, 59);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(313, 25);
            this.txtCompany.TabIndex = 163;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(105, 146);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 25);
            this.txtEmail.TabIndex = 154;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLastName.Location = new System.Drawing.Point(105, 102);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(289, 25);
            this.txtLastName.TabIndex = 153;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNotes.Location = new System.Drawing.Point(521, 238);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(313, 30);
            this.txtNotes.TabIndex = 173;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCompany.Location = new System.Drawing.Point(464, 63);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(62, 15);
            this.lblCompany.TabIndex = 186;
            this.lblCompany.Text = "Company:";
            // 
            // txtJobTittle
            // 
            this.txtJobTittle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTittle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtJobTittle.Location = new System.Drawing.Point(523, 94);
            this.txtJobTittle.Multiline = true;
            this.txtJobTittle.Name = "txtJobTittle";
            this.txtJobTittle.Size = new System.Drawing.Size(313, 25);
            this.txtJobTittle.TabIndex = 164;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMobile.Location = new System.Drawing.Point(102, 348);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(292, 25);
            this.txtMobile.TabIndex = 162;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddress.Location = new System.Drawing.Point(471, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 187;
            this.lblAddress.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhone.Location = new System.Drawing.Point(713, 174);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 25);
            this.txtPhone.TabIndex = 168;
            this.txtPhone.Text = "Phone";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.Location = new System.Drawing.Point(523, 125);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(313, 38);
            this.txtAddress.TabIndex = 166;
            this.txtAddress.Text = "Street";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCity.Location = new System.Drawing.Point(521, 174);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(148, 25);
            this.txtCity.TabIndex = 167;
            this.txtCity.Text = "City/Town";
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.BackColor = System.Drawing.Color.Transparent;
            this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMobile.Location = new System.Drawing.Point(56, 351);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(47, 15);
            this.lblMobile.TabIndex = 190;
            this.lblMobile.Text = "Mobile:";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtState.Location = new System.Drawing.Point(737, 209);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(99, 21);
            this.txtState.TabIndex = 172;
            this.txtState.Text = "State";
            this.txtState.Enter += new System.EventHandler(this.txtState_Enter);
            this.txtState.Leave += new System.EventHandler(this.txtState_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNotes.Location = new System.Drawing.Point(479, 238);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 15);
            this.lblNotes.TabIndex = 170;
            this.lblNotes.Text = "Notes:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPostalCode.Location = new System.Drawing.Point(521, 208);
            this.txtPostalCode.Multiline = true;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(98, 24);
            this.txtPostalCode.TabIndex = 169;
            this.txtPostalCode.Text = "Postal Code";
            this.txtPostalCode.Enter += new System.EventHandler(this.txtPostalCode_Enter);
            this.txtPostalCode.Leave += new System.EventHandler(this.txtPostalCode_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDepartment.Location = new System.Drawing.Point(31, 309);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 15);
            this.lblDepartment.TabIndex = 191;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCountry.Location = new System.Drawing.Point(628, 208);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(103, 24);
            this.txtCountry.TabIndex = 171;
            this.txtCountry.Text = "Country";
            this.txtCountry.Enter += new System.EventHandler(this.txtCountry_Enter);
            this.txtCountry.Leave += new System.EventHandler(this.txtCountry_Leave);
            // 
            // lblJobTittle
            // 
            this.lblJobTittle.AutoSize = true;
            this.lblJobTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblJobTittle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTittle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJobTittle.Location = new System.Drawing.Point(471, 97);
            this.lblJobTittle.Name = "lblJobTittle";
            this.lblJobTittle.Size = new System.Drawing.Size(51, 15);
            this.lblJobTittle.TabIndex = 165;
            this.lblJobTittle.Text = "Job title:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConfirmPassword.Location = new System.Drawing.Point(105, 267);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(289, 25);
            this.txtConfirmPassword.TabIndex = 160;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Location = new System.Drawing.Point(105, 232);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 25);
            this.txtPassword.TabIndex = 159;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfirmPassword.Location = new System.Drawing.Point(1, 267);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPassword.TabIndex = 189;
            this.lblConfirmPassword.Text = "Confirm password:";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(45, 232);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 188;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 466);
            this.Controls.Add(this.lbluserrole1);
            this.Controls.Add(this.Cboxusertype);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnuserUpdate);
            this.Controls.Add(this.chkConfiguration);
            this.Controls.Add(this.chkSupplier);
            this.Controls.Add(this.chkItemManagement);
            this.Controls.Add(this.chkJobs);
            this.Controls.Add(this.chkReports);
            this.Controls.Add(this.chkGeneral);
            this.Controls.Add(this.grpbxAccessLevel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtJobTittle);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblJobTittle);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserUpdate";
            this.Text = "User Update";
            this.grpbxAccessLevel.ResumeLayout(false);
            this.grpbxAccessLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserrole1;
        private System.Windows.Forms.ComboBox Cboxusertype;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnuserUpdate;
        private System.Windows.Forms.CheckBox chkConfiguration;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.CheckBox chkItemManagement;
        private System.Windows.Forms.CheckBox chkJobs;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkGeneral;
        private System.Windows.Forms.GroupBox grpbxAccessLevel;
        private System.Windows.Forms.CheckBox chkLevel3;
        private System.Windows.Forms.CheckBox chkLevel2;
        private System.Windows.Forms.CheckBox chkLevel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtJobTittle;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblJobTittle;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}