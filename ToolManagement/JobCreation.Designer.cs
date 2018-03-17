namespace ToolManagement
{
    partial class JobCreation
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
            this.tabjobinfo = new System.Windows.Forms.TabPage();
            this.txtjobDesc = new System.Windows.Forms.TextBox();
            this.txtjobname = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lbljobname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tab_jobinfo = new System.Windows.Forms.TabControl();
            this.tabjobinfo.SuspendLayout();
            this.tab_jobinfo.SuspendLayout();
            this.SuspendLayout();
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
            this.tabjobinfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabjobinfo.Size = new System.Drawing.Size(505, 221);
            this.tabjobinfo.TabIndex = 0;
            this.tabjobinfo.Text = "Job Information";
            this.tabjobinfo.UseVisualStyleBackColor = true;
            // 
            // txtjobDesc
            // 
            this.txtjobDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjobDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtjobDesc.Location = new System.Drawing.Point(116, 60);
            this.txtjobDesc.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtjobDesc.Multiline = true;
            this.txtjobDesc.Name = "txtjobDesc";
            this.txtjobDesc.Size = new System.Drawing.Size(272, 115);
            this.txtjobDesc.TabIndex = 1;
            // 
            // txtjobname
            // 
            this.txtjobname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjobname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtjobname.Location = new System.Drawing.Point(116, 19);
            this.txtjobname.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtjobname.Name = "txtjobname";
            this.txtjobname.Size = new System.Drawing.Size(272, 27);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Create";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tab_jobinfo
            // 
            this.tab_jobinfo.Controls.Add(this.tabjobinfo);
            this.tab_jobinfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_jobinfo.ItemSize = new System.Drawing.Size(84, 25);
            this.tab_jobinfo.Location = new System.Drawing.Point(12, 12);
            this.tab_jobinfo.Name = "tab_jobinfo";
            this.tab_jobinfo.SelectedIndex = 0;
            this.tab_jobinfo.Size = new System.Drawing.Size(513, 254);
            this.tab_jobinfo.TabIndex = 26;
            // 
            // JobCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(537, 278);
            this.Controls.Add(this.tab_jobinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobCreation";
            this.Text = "Job Creation";
            this.tabjobinfo.ResumeLayout(false);
            this.tabjobinfo.PerformLayout();
            this.tab_jobinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabjobinfo;
        private System.Windows.Forms.TextBox txtjobDesc;
        private System.Windows.Forms.TextBox txtjobname;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lbljobname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tab_jobinfo;


    }
}