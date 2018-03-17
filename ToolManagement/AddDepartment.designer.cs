namespace ToolManagement
{
    partial class AddDepartment
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblEnterDepartment = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(147, 23);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(267, 28);
            this.txtDepartment.TabIndex = 0;
            // 
            // lblEnterDepartment
            // 
            this.lblEnterDepartment.AutoSize = true;
            this.lblEnterDepartment.Location = new System.Drawing.Point(26, 26);
            this.lblEnterDepartment.Name = "lblEnterDepartment";
            this.lblEnterDepartment.Size = new System.Drawing.Size(90, 13);
            this.lblEnterDepartment.TabIndex = 1;
            this.lblEnterDepartment.Text = "Enter Department";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.button1.Location = new System.Drawing.Point(324, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEnterDepartment);
            this.Controls.Add(this.txtDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblEnterDepartment;
        private System.Windows.Forms.Button button1;
    }
}