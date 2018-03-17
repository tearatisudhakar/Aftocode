namespace ToolManagement
{
    partial class ItemManagement
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
            this.tabItem = new System.Windows.Forms.TabControl();
            this.tbItemList = new System.Windows.Forms.TabPage();
            this.pnlItemList = new System.Windows.Forms.Panel();
            this.tbAddItem = new System.Windows.Forms.TabPage();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.tbIssueList = new System.Windows.Forms.TabPage();
            this.pnlIssueList = new System.Windows.Forms.Panel();
            this.tbReturnItem = new System.Windows.Forms.TabPage();
            this.ReturnItemsPanel = new System.Windows.Forms.Panel();
            this.tbRemoveItem = new System.Windows.Forms.TabPage();
            this.pnlRemoveItem = new System.Windows.Forms.Panel();
            this.tabReturnItemHistory = new System.Windows.Forms.TabPage();
            this.tbExcelItemInfo = new System.Windows.Forms.TabPage();
            this.pnlAddItemFromExcel = new System.Windows.Forms.Panel();
            this.pnlReturnHistory = new System.Windows.Forms.Panel();
            this.tabItem.SuspendLayout();
            this.tbItemList.SuspendLayout();
            this.tbAddItem.SuspendLayout();
            this.tbIssueList.SuspendLayout();
            this.tbReturnItem.SuspendLayout();
            this.tbRemoveItem.SuspendLayout();
            this.tabReturnItemHistory.SuspendLayout();
            this.tbExcelItemInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.tbItemList);
            this.tabItem.Controls.Add(this.tbAddItem);
            this.tabItem.Controls.Add(this.tbIssueList);
            this.tabItem.Controls.Add(this.tbReturnItem);
            this.tabItem.Controls.Add(this.tbRemoveItem);
            this.tabItem.Controls.Add(this.tabReturnItemHistory);
            this.tabItem.Controls.Add(this.tbExcelItemInfo);
            this.tabItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabItem.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabItem.HotTrack = true;
            this.tabItem.ItemSize = new System.Drawing.Size(120, 45);
            this.tabItem.Location = new System.Drawing.Point(0, 0);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Drawing.Point(10, 6);
            this.tabItem.SelectedIndex = 0;
            this.tabItem.Size = new System.Drawing.Size(971, 523);
            this.tabItem.TabIndex = 1;
            this.tabItem.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabItem_DrawItem);
            this.tabItem.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabItem_Selected);
            // 
            // tbItemList
            // 
            this.tbItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbItemList.Controls.Add(this.pnlItemList);
            this.tbItemList.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemList.Location = new System.Drawing.Point(4, 49);
            this.tbItemList.Name = "tbItemList";
            this.tbItemList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbItemList.Size = new System.Drawing.Size(963, 470);
            this.tbItemList.TabIndex = 0;
            this.tbItemList.Text = "Item List            ";
            // 
            // pnlItemList
            // 
            this.pnlItemList.BackColor = System.Drawing.Color.White;
            this.pnlItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemList.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlItemList.Location = new System.Drawing.Point(0, 10);
            this.pnlItemList.Name = "pnlItemList";
            this.pnlItemList.Size = new System.Drawing.Size(963, 460);
            this.pnlItemList.TabIndex = 0;
            // 
            // tbAddItem
            // 
            this.tbAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbAddItem.Controls.Add(this.pnlAddItem);
            this.tbAddItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddItem.Location = new System.Drawing.Point(4, 49);
            this.tbAddItem.Name = "tbAddItem";
            this.tbAddItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbAddItem.Size = new System.Drawing.Size(963, 470);
            this.tbAddItem.TabIndex = 3;
            this.tbAddItem.Text = "Add Item             ";
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddItem.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddItem.Location = new System.Drawing.Point(0, 10);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(963, 460);
            this.pnlAddItem.TabIndex = 0;
            // 
            // tbIssueList
            // 
            this.tbIssueList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbIssueList.Controls.Add(this.pnlIssueList);
            this.tbIssueList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIssueList.Location = new System.Drawing.Point(4, 49);
            this.tbIssueList.Name = "tbIssueList";
            this.tbIssueList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbIssueList.Size = new System.Drawing.Size(963, 470);
            this.tbIssueList.TabIndex = 1;
            this.tbIssueList.Text = "Issued Item List      ";
            // 
            // pnlIssueList
            // 
            this.pnlIssueList.BackColor = System.Drawing.Color.White;
            this.pnlIssueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIssueList.Location = new System.Drawing.Point(0, 10);
            this.pnlIssueList.Name = "pnlIssueList";
            this.pnlIssueList.Size = new System.Drawing.Size(963, 460);
            this.pnlIssueList.TabIndex = 0;
            // 
            // tbReturnItem
            // 
            this.tbReturnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbReturnItem.Controls.Add(this.ReturnItemsPanel);
            this.tbReturnItem.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReturnItem.Location = new System.Drawing.Point(4, 49);
            this.tbReturnItem.Name = "tbReturnItem";
            this.tbReturnItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbReturnItem.Size = new System.Drawing.Size(963, 470);
            this.tbReturnItem.TabIndex = 4;
            this.tbReturnItem.Text = "Returned Items List       ";
            // 
            // ReturnItemsPanel
            // 
            this.ReturnItemsPanel.BackColor = System.Drawing.Color.White;
            this.ReturnItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnItemsPanel.Location = new System.Drawing.Point(0, 10);
            this.ReturnItemsPanel.Name = "ReturnItemsPanel";
            this.ReturnItemsPanel.Size = new System.Drawing.Size(963, 460);
            this.ReturnItemsPanel.TabIndex = 1;
            // 
            // tbRemoveItem
            // 
            this.tbRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbRemoveItem.Controls.Add(this.pnlRemoveItem);
            this.tbRemoveItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemoveItem.Location = new System.Drawing.Point(4, 49);
            this.tbRemoveItem.Name = "tbRemoveItem";
            this.tbRemoveItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbRemoveItem.Size = new System.Drawing.Size(963, 470);
            this.tbRemoveItem.TabIndex = 2;
            this.tbRemoveItem.Text = "Deleted Item List     ";
            // 
            // pnlRemoveItem
            // 
            this.pnlRemoveItem.BackColor = System.Drawing.Color.White;
            this.pnlRemoveItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemoveItem.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRemoveItem.Location = new System.Drawing.Point(0, 10);
            this.pnlRemoveItem.Name = "pnlRemoveItem";
            this.pnlRemoveItem.Size = new System.Drawing.Size(963, 460);
            this.pnlRemoveItem.TabIndex = 0;
            // 
            // tabReturnItemHistory
            // 
            this.tabReturnItemHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tabReturnItemHistory.Controls.Add(this.pnlReturnHistory);
            this.tabReturnItemHistory.Font = new System.Drawing.Font("Calibri", 12F);
            this.tabReturnItemHistory.Location = new System.Drawing.Point(4, 49);
            this.tabReturnItemHistory.Name = "tabReturnItemHistory";
            this.tabReturnItemHistory.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tabReturnItemHistory.Size = new System.Drawing.Size(963, 470);
            this.tabReturnItemHistory.TabIndex = 6;
            this.tabReturnItemHistory.Text = "Returned Item History";
            // 
            // tbExcelItemInfo
            // 
            this.tbExcelItemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.tbExcelItemInfo.Controls.Add(this.pnlAddItemFromExcel);
            this.tbExcelItemInfo.Location = new System.Drawing.Point(4, 49);
            this.tbExcelItemInfo.Name = "tbExcelItemInfo";
            this.tbExcelItemInfo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbExcelItemInfo.Size = new System.Drawing.Size(963, 470);
            this.tbExcelItemInfo.TabIndex = 5;
            this.tbExcelItemInfo.Text = "Import Items ";
            // 
            // pnlAddItemFromExcel
            // 
            this.pnlAddItemFromExcel.BackColor = System.Drawing.Color.White;
            this.pnlAddItemFromExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddItemFromExcel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddItemFromExcel.Location = new System.Drawing.Point(0, 10);
            this.pnlAddItemFromExcel.Name = "pnlAddItemFromExcel";
            this.pnlAddItemFromExcel.Size = new System.Drawing.Size(963, 460);
            this.pnlAddItemFromExcel.TabIndex = 0;
            // 
            // pnlReturnHistory
            // 
            this.pnlReturnHistory.BackColor = System.Drawing.Color.White;
            this.pnlReturnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturnHistory.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReturnHistory.Location = new System.Drawing.Point(0, 10);
            this.pnlReturnHistory.Name = "pnlReturnHistory";
            this.pnlReturnHistory.Size = new System.Drawing.Size(963, 460);
            this.pnlReturnHistory.TabIndex = 0;
            // 
            // ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 523);
            this.Controls.Add(this.tabItem);
            this.DoubleBuffered = true;
            this.Name = "ItemManagement";
            this.Text = "ItemManagement";
            this.tabItem.ResumeLayout(false);
            this.tbItemList.ResumeLayout(false);
            this.tbAddItem.ResumeLayout(false);
            this.tbIssueList.ResumeLayout(false);
            this.tbReturnItem.ResumeLayout(false);
            this.tbRemoveItem.ResumeLayout(false);
            this.tabReturnItemHistory.ResumeLayout(false);
            this.tbExcelItemInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabItem;
        private System.Windows.Forms.TabPage tbIssueList;
        private System.Windows.Forms.TabPage tbRemoveItem;
        private System.Windows.Forms.Panel pnlIssueList;
        private System.Windows.Forms.Panel pnlRemoveItem;
        private System.Windows.Forms.TabPage tbAddItem;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.TabPage tbItemList;
        private System.Windows.Forms.Panel pnlItemList;
        private System.Windows.Forms.TabPage tbReturnItem;
        private System.Windows.Forms.Panel ReturnItemsPanel;
        private System.Windows.Forms.TabPage tbExcelItemInfo;
        private System.Windows.Forms.TabPage tabReturnItemHistory;
        private System.Windows.Forms.Panel pnlAddItemFromExcel;
        private System.Windows.Forms.Panel pnlReturnHistory;

    }
}