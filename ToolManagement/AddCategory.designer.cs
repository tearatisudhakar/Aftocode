namespace ToolTracker
{
    partial class AddCategory
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
            this.txtItemCategory = new System.Windows.Forms.TextBox();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemCategory
            // 
            this.txtItemCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtItemCategory.Location = new System.Drawing.Point(120, 33);
            this.txtItemCategory.Margin = new System.Windows.Forms.Padding(7);
            this.txtItemCategory.Name = "txtItemCategory";
            this.txtItemCategory.Size = new System.Drawing.Size(234, 30);
            this.txtItemCategory.TabIndex = 0;
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemGroup.Location = new System.Drawing.Point(12, 36);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(106, 20);
            this.lblItemGroup.TabIndex = 21;
            this.lblItemGroup.Text = "Item Category:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(264, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCategory
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(382, 146);
            this.Controls.Add(this.txtItemCategory);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemCategory;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Button btnAdd;

    }
}