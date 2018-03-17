namespace ToolManagement
{
    partial class ConfigurationMenu
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
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tbSetting = new System.Windows.Forms.TabPage();
            this.pnlItemList = new System.Windows.Forms.Panel();
            this.tbPersanalsetting = new System.Windows.Forms.TabPage();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.tabConfig.SuspendLayout();
            this.tbSetting.SuspendLayout();
            this.tbPersanalsetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tbSetting);
            this.tabConfig.Controls.Add(this.tbPersanalsetting);
            this.tabConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConfig.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabConfig.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConfig.HotTrack = true;
            this.tabConfig.ItemSize = new System.Drawing.Size(120, 45);
            this.tabConfig.Location = new System.Drawing.Point(0, 0);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Drawing.Point(10, 6);
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(822, 484);
            this.tabConfig.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConfig.TabIndex = 0;
            this.tabConfig.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabConfig_DrawItem);
            // 
            // tbSetting
            // 
            this.tbSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbSetting.Controls.Add(this.pnlItemList);
            this.tbSetting.Location = new System.Drawing.Point(4, 49);
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbSetting.Size = new System.Drawing.Size(814, 431);
            this.tbSetting.TabIndex = 0;
            this.tbSetting.Text = "Settings";
            // 
            // pnlItemList
            // 
            this.pnlItemList.BackColor = System.Drawing.Color.White;
            this.pnlItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemList.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlItemList.Location = new System.Drawing.Point(0, 10);
            this.pnlItemList.Name = "pnlItemList";
            this.pnlItemList.Size = new System.Drawing.Size(814, 421);
            this.pnlItemList.TabIndex = 1;
            // 
            // tbPersanalsetting
            // 
            this.tbPersanalsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbPersanalsetting.Controls.Add(this.pnlConfiguration);
            this.tbPersanalsetting.Location = new System.Drawing.Point(4, 49);
            this.tbPersanalsetting.Name = "tbPersanalsetting";
            this.tbPersanalsetting.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbPersanalsetting.Size = new System.Drawing.Size(814, 431);
            this.tbPersanalsetting.TabIndex = 1;
            this.tbPersanalsetting.Text = "Personnel Setting";
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.BackColor = System.Drawing.Color.White;
            this.pnlConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfiguration.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfiguration.Location = new System.Drawing.Point(0, 10);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(814, 421);
            this.pnlConfiguration.TabIndex = 2;
            // 
            // ConfigurationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.tabConfig);
            this.Name = "ConfigurationMenu";
            this.Text = "ConfigurationMenu";
            this.tabConfig.ResumeLayout(false);
            this.tbSetting.ResumeLayout(false);
            this.tbPersanalsetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tbSetting;
        private System.Windows.Forms.TabPage tbPersanalsetting;
        private System.Windows.Forms.Panel pnlItemList;
        private System.Windows.Forms.Panel pnlConfiguration;
    }
}