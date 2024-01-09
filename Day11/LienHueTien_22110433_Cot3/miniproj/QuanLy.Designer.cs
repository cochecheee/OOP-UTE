namespace miniproj
{
    partial class QuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaHàng01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaHàng02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inComeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outComeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lợiNhuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.cácCửaHàngToolStripMenuItem,
            this.quảnLýDoanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.tínhLươngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // tínhLươngToolStripMenuItem
            // 
            this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
            this.tínhLươngToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.tínhLươngToolStripMenuItem.Text = "Tính lương";
            // 
            // cácCửaHàngToolStripMenuItem
            // 
            this.cácCửaHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cửaHàng01ToolStripMenuItem,
            this.cửaHàng02ToolStripMenuItem});
            this.cácCửaHàngToolStripMenuItem.Name = "cácCửaHàngToolStripMenuItem";
            this.cácCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.cácCửaHàngToolStripMenuItem.Text = "Các cửa hàng";
            // 
            // cửaHàng01ToolStripMenuItem
            // 
            this.cửaHàng01ToolStripMenuItem.Name = "cửaHàng01ToolStripMenuItem";
            this.cửaHàng01ToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.cửaHàng01ToolStripMenuItem.Text = "Cửa hàng 01";
            this.cửaHàng01ToolStripMenuItem.Click += new System.EventHandler(this.cửaHàng01ToolStripMenuItem_Click);
            // 
            // cửaHàng02ToolStripMenuItem
            // 
            this.cửaHàng02ToolStripMenuItem.Name = "cửaHàng02ToolStripMenuItem";
            this.cửaHàng02ToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.cửaHàng02ToolStripMenuItem.Text = "Cửa hàng 02";
            this.cửaHàng02ToolStripMenuItem.Click += new System.EventHandler(this.cửaHàng02ToolStripMenuItem_Click);
            // 
            // quảnLýDoanhThuToolStripMenuItem
            // 
            this.quảnLýDoanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inComeToolStripMenuItem,
            this.outComeToolStripMenuItem,
            this.lợiNhuậnToolStripMenuItem});
            this.quảnLýDoanhThuToolStripMenuItem.Name = "quảnLýDoanhThuToolStripMenuItem";
            this.quảnLýDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quảnLýDoanhThuToolStripMenuItem.Text = "Quản lý doanh thu";
            // 
            // inComeToolStripMenuItem
            // 
            this.inComeToolStripMenuItem.Name = "inComeToolStripMenuItem";
            this.inComeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inComeToolStripMenuItem.Text = "InCome";
            this.inComeToolStripMenuItem.Click += new System.EventHandler(this.inComeToolStripMenuItem_Click);
            // 
            // outComeToolStripMenuItem
            // 
            this.outComeToolStripMenuItem.Name = "outComeToolStripMenuItem";
            this.outComeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outComeToolStripMenuItem.Text = "OutCome";
            this.outComeToolStripMenuItem.Click += new System.EventHandler(this.outComeToolStripMenuItem_Click);
            // 
            // lợiNhuậnToolStripMenuItem
            // 
            this.lợiNhuậnToolStripMenuItem.Name = "lợiNhuậnToolStripMenuItem";
            this.lợiNhuậnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lợiNhuậnToolStripMenuItem.Text = "Lợi nhuận";
            this.lợiNhuậnToolStripMenuItem.Click += new System.EventHandler(this.lợiNhuậnToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácCửaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cửaHàng01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cửaHàng02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inComeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outComeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lợiNhuậnToolStripMenuItem;
    }
}