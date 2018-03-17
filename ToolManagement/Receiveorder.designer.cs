namespace ToolManagement
{
    partial class Receiveorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtInex = new System.Windows.Forms.TextBox();
            this.gvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.btnSelectForReceive = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(309, 186);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(332, 24);
            this.txtLocation.TabIndex = 16;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(309, 100);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Multiline = true;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(172, 24);
            this.txtItemCode.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(309, 142);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(444, 24);
            this.txtDescription.TabIndex = 15;
            // 
            // txtInex
            // 
            this.txtInex.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInex.Location = new System.Drawing.Point(309, 58);
            this.txtInex.Margin = new System.Windows.Forms.Padding(4);
            this.txtInex.Multiline = true;
            this.txtInex.Name = "txtInex";
            this.txtInex.Size = new System.Drawing.Size(585, 24);
            this.txtInex.TabIndex = 13;
            // 
            // gvTransactionDetails
            // 
            this.gvTransactionDetails.AllowUserToAddRows = false;
            this.gvTransactionDetails.AllowUserToDeleteRows = false;
            this.gvTransactionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTransactionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTransactionDetails.Location = new System.Drawing.Point(89, 256);
            this.gvTransactionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gvTransactionDetails.Name = "gvTransactionDetails";
            this.gvTransactionDetails.ReadOnly = true;
            this.gvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTransactionDetails.Size = new System.Drawing.Size(632, 213);
            this.gvTransactionDetails.TabIndex = 17;
            // 
            // btnSelectForReceive
            // 
            this.btnSelectForReceive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectForReceive.Location = new System.Drawing.Point(297, 491);
            this.btnSelectForReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectForReceive.Name = "btnSelectForReceive";
            this.btnSelectForReceive.Size = new System.Drawing.Size(200, 31);
            this.btnSelectForReceive.TabIndex = 5;
            this.btnSelectForReceive.Text = "Select for Receive :  ";
            this.btnSelectForReceive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Item Category  :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Item Location :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Item Description :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(190, 103);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(111, 24);
            this.lblItemCode.TabIndex = 41;
            this.lblItemCode.Text = "Item Code  :";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Receiveorder
            // 
            this.AcceptButton = this.btnSelectForReceive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(947, 572);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.btnSelectForReceive);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtInex);
            this.Controls.Add(this.gvTransactionDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receiveorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Order";
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtInex;
        private System.Windows.Forms.DataGridView gvTransactionDetails;
        private System.Windows.Forms.Button btnSelectForReceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblItemCode;
    }
}