namespace ToolTracker
{
    partial class AddNewItem
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
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.cmbItemGroup = new System.Windows.Forms.ComboBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lbltemType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemType
            // 
            this.txtItemType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemType.Location = new System.Drawing.Point(159, 72);
            this.txtItemType.Multiline = true;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(250, 27);
            this.txtItemType.TabIndex = 1;
            // 
            // cmbItemGroup
            // 
            this.cmbItemGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemGroup.FormattingEnabled = true;
            this.cmbItemGroup.Location = new System.Drawing.Point(159, 33);
            this.cmbItemGroup.Name = "cmbItemGroup";
            this.cmbItemGroup.Size = new System.Drawing.Size(250, 31);
            this.cmbItemGroup.TabIndex = 0;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Location = new System.Drawing.Point(65, 33);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(87, 20);
            this.lblItemCode.TabIndex = 14;
            this.lblItemCode.Text = "Item Group:";
            // 
            // lbltemType
            // 
            this.lbltemType.AutoSize = true;
            this.lbltemType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbltemType.Location = new System.Drawing.Point(75, 70);
            this.lbltemType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbltemType.Name = "lbltemType";
            this.lbltemType.Size = new System.Drawing.Size(77, 20);
            this.lbltemType.TabIndex = 13;
            this.lbltemType.Text = "Item Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(319, 110);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(454, 157);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.cmbItemGroup);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lbltemType);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.ComboBox cmbItemGroup;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lbltemType;
        private System.Windows.Forms.Button btnAdd;

    }
}