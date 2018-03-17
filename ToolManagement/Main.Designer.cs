namespace ToolManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu_homepage = new System.Windows.Forms.MenuStrip();
            this.pnlMail = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlLogos = new System.Windows.Forms.Panel();
            this.ntfncontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySplitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picbxAfotmat = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.menu_homepage.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlLogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).BeginInit();
            this.mySplitContainer.Panel1.SuspendLayout();
            this.mySplitContainer.Panel2.SuspendLayout();
            this.mySplitContainer.SuspendLayout();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAfotmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_homepage
            // 
            this.menu_homepage.AutoSize = false;
            this.menu_homepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.menu_homepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu_homepage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_homepage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_homepage.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu_homepage.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menu_homepage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.itemManagementToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menu_homepage.Location = new System.Drawing.Point(0, 0);
            this.menu_homepage.Name = "menu_homepage";
            this.menu_homepage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.menu_homepage.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_homepage.Size = new System.Drawing.Size(200, 679);
            this.menu_homepage.TabIndex = 0;
            this.menu_homepage.TabStop = true;
            this.menu_homepage.Text = "menuStrip1";
            // 
            // pnlMail
            // 
            this.pnlMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMail.BackColor = System.Drawing.Color.Transparent;
            this.pnlMail.Location = new System.Drawing.Point(0, 0);
            this.pnlMail.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMail.Name = "pnlMail";
            this.pnlMail.Size = new System.Drawing.Size(1347, 759);
            this.pnlMail.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.picbxAfotmat);
            this.pnlTop.Controls.Add(this.lblUsername);
            this.pnlTop.Controls.Add(this.pnlLogos);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1363, 62);
            this.pnlTop.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(256, 17);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(632, 28);
            this.lblUsername.TabIndex = 5;
            // 
            // pnlLogos
            // 
            this.pnlLogos.Controls.Add(this.picCustomer);
            this.pnlLogos.Controls.Add(this.btnNotification);
            this.pnlLogos.Controls.Add(this.btnUser);
            this.pnlLogos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogos.Location = new System.Drawing.Point(947, 0);
            this.pnlLogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogos.Name = "pnlLogos";
            this.pnlLogos.Size = new System.Drawing.Size(416, 62);
            this.pnlLogos.TabIndex = 4;
            // 
            // ntfncontextMenuStrip
            // 
            this.ntfncontextMenuStrip.Name = "ntfncontextMenuStrip";
            this.ntfncontextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // mySplitContainer
            // 
            this.mySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mySplitContainer.IsSplitterFixed = true;
            this.mySplitContainer.Location = new System.Drawing.Point(0, 62);
            this.mySplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mySplitContainer.Name = "mySplitContainer";
            // 
            // mySplitContainer.Panel1
            // 
            this.mySplitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.mySplitContainer.Panel1.Controls.Add(this.pnlmain);
            this.mySplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mySplitContainer.Panel1MinSize = 120;
            // 
            // mySplitContainer.Panel2
            // 
            this.mySplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mySplitContainer.Panel2.Controls.Add(this.pnlMail);
            this.mySplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mySplitContainer.Size = new System.Drawing.Size(1363, 679);
            this.mySplitContainer.SplitterDistance = 142;
            this.mySplitContainer.SplitterWidth = 5;
            this.mySplitContainer.TabIndex = 9;
            // 
            // pnlmain
            // 
            this.pnlmain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlmain.BackColor = System.Drawing.Color.Transparent;
            this.pnlmain.Controls.Add(this.menu_homepage);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(200, 679);
            this.pnlmain.TabIndex = 7;
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.AutoSize = false;
            this.generalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.generalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generalToolStripMenuItem.Image")));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.generalToolStripMenuItem.Text = "&General";
            this.generalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // itemManagementToolStripMenuItem
            // 
            this.itemManagementToolStripMenuItem.AutoSize = false;
            this.itemManagementToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.itemManagementToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemManagementToolStripMenuItem.Image")));
            this.itemManagementToolStripMenuItem.Name = "itemManagementToolStripMenuItem";
            this.itemManagementToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.itemManagementToolStripMenuItem.Text = "Item &Management";
            this.itemManagementToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemManagementToolStripMenuItem.Click += new System.EventHandler(this.itemManagementToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.AutoSize = false;
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryToolStripMenuItem.Image")));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            this.inventoryToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.AutoSize = false;
            this.jobsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.jobsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jobsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jobsToolStripMenuItem.Image")));
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.jobsToolStripMenuItem.Text = "&Jobs";
            this.jobsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.jobsToolStripMenuItem.Click += new System.EventHandler(this.jobsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.AutoSize = false;
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.reportsToolStripMenuItem.Text = "&Reports";
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.AutoSize = false;
            this.supplierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.supplierToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierToolStripMenuItem.Image")));
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.supplierToolStripMenuItem.Text = "&Supplier";
            this.supplierToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AutoSize = false;
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.settingToolStripMenuItem.Image = global::ToolManagement.Properties.Resources._7data_configuration_xxl;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(199, 52);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.AutoSize = false;
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(250, 75);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // picbxAfotmat
            // 
            this.picbxAfotmat.BackgroundImage = global::ToolManagement.Properties.Resources.new_logo1;
            this.picbxAfotmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbxAfotmat.Location = new System.Drawing.Point(3, 7);
            this.picbxAfotmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbxAfotmat.Name = "picbxAfotmat";
            this.picbxAfotmat.Size = new System.Drawing.Size(251, 49);
            this.picbxAfotmat.TabIndex = 2;
            this.picbxAfotmat.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCustomer.Location = new System.Drawing.Point(12, 7);
            this.picCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(251, 49);
            this.picCustomer.TabIndex = 3;
            this.picCustomer.TabStop = false;
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.White;
            this.btnNotification.BackgroundImage = global::ToolManagement.Properties.Resources.if_bell_blue_68671;
            this.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotification.ContextMenuStrip = this.ntfncontextMenuStrip;
            this.btnNotification.Location = new System.Drawing.Point(299, 7);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(53, 49);
            this.btnNotification.TabIndex = 1;
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.BackgroundImage = global::ToolManagement.Properties.Resources.Pic1;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Location = new System.Drawing.Point(357, 7);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(53, 49);
            this.btnUser.TabIndex = 0;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 741);
            this.Controls.Add(this.mySplitContainer);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1298, 724);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tool Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menu_homepage.ResumeLayout(false);
            this.menu_homepage.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlLogos.ResumeLayout(false);
            this.mySplitContainer.Panel1.ResumeLayout(false);
            this.mySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).EndInit();
            this.mySplitContainer.ResumeLayout(false);
            this.pnlmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxAfotmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_homepage;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMail;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.SplitContainer mySplitContainer;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlLogos;
        private System.Windows.Forms.PictureBox picbxAfotmat;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ContextMenuStrip ntfncontextMenuStrip;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;

    }
}