namespace ToolManagement.Controls
{
    partial class ItemsDisplayctrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.GvIteminfo = new System.Windows.Forms.DataGridView();
            this.lblpitemcode = new System.Windows.Forms.Label();
            this.lblpsupplier = new System.Windows.Forms.Label();
            this.lblpitemdesc = new System.Windows.Forms.Label();
            this.lblpitemgroup = new System.Windows.Forms.Label();
            this.lblpcategory = new System.Windows.Forms.Label();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GvIteminfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Items Display";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(3, 25);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1148, 28);
            this.label21.TabIndex = 30;
            this.label21.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______________________________";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(953, 60);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(776, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 36);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.Location = new System.Drawing.Point(15, 58);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(752, 44);
            this.txtInput.TabIndex = 31;
            // 
            // GvIteminfo
            // 
            this.GvIteminfo.AllowUserToAddRows = false;
            this.GvIteminfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvIteminfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvIteminfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvIteminfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvIteminfo.Location = new System.Drawing.Point(5, 107);
            this.GvIteminfo.Margin = new System.Windows.Forms.Padding(4);
            this.GvIteminfo.Name = "GvIteminfo";
            this.GvIteminfo.ReadOnly = true;
            this.GvIteminfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvIteminfo.Size = new System.Drawing.Size(1117, 249);
            this.GvIteminfo.TabIndex = 44;
            // 
            // lblpitemcode
            // 
            this.lblpitemcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpitemcode.Location = new System.Drawing.Point(199, 576);
            this.lblpitemcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpitemcode.Name = "lblpitemcode";
            this.lblpitemcode.Size = new System.Drawing.Size(63, 23);
            this.lblpitemcode.TabIndex = 43;
            // 
            // lblpsupplier
            // 
            this.lblpsupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpsupplier.Location = new System.Drawing.Point(592, 615);
            this.lblpsupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpsupplier.Name = "lblpsupplier";
            this.lblpsupplier.Size = new System.Drawing.Size(52, 23);
            this.lblpsupplier.TabIndex = 35;
            // 
            // lblpitemdesc
            // 
            this.lblpitemdesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpitemdesc.Location = new System.Drawing.Point(199, 606);
            this.lblpitemdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpitemdesc.Name = "lblpitemdesc";
            this.lblpitemdesc.Size = new System.Drawing.Size(63, 23);
            this.lblpitemdesc.TabIndex = 46;
            // 
            // lblpitemgroup
            // 
            this.lblpitemgroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpitemgroup.Location = new System.Drawing.Point(592, 571);
            this.lblpitemgroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpitemgroup.Name = "lblpitemgroup";
            this.lblpitemgroup.Size = new System.Drawing.Size(52, 23);
            this.lblpitemgroup.TabIndex = 48;
            // 
            // lblpcategory
            // 
            this.lblpcategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpcategory.Location = new System.Drawing.Point(199, 635);
            this.lblpcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpcategory.Name = "lblpcategory";
            this.lblpcategory.Size = new System.Drawing.Size(63, 23);
            this.lblpcategory.TabIndex = 45;
            // 
            // imgItem
            // 
            this.imgItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Location = new System.Drawing.Point(751, 389);
            this.imgItem.Margin = new System.Windows.Forms.Padding(4);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(381, 180);
            this.imgItem.TabIndex = 50;
            this.imgItem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgItem);
            this.panel1.Controls.Add(this.lblpcategory);
            this.panel1.Controls.Add(this.lblpitemgroup);
            this.panel1.Controls.Add(this.lblpitemdesc);
            this.panel1.Controls.Add(this.lblpsupplier);
            this.panel1.Controls.Add(this.lblpitemcode);
            this.panel1.Controls.Add(this.GvIteminfo);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 720);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(32, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 34);
            this.label9.TabIndex = 55;
            this.label9.Text = "Item Code:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(32, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "Item Description:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(32, 487);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Category:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(451, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Item Group:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(451, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Supplier:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemsDisplayctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemsDisplayctrl";
            this.Size = new System.Drawing.Size(1152, 720);
            ((System.ComponentModel.ISupportInitialize)(this.GvIteminfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridView GvIteminfo;
        private System.Windows.Forms.Label lblpitemcode;
        private System.Windows.Forms.Label lblpsupplier;
        private System.Windows.Forms.Label lblpitemdesc;
        private System.Windows.Forms.Label lblpitemgroup;
        private System.Windows.Forms.Label lblpcategory;
        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;

    }
}
