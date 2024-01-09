namespace miniproj
{
    partial class Form3
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
            this.cácCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaHàng01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaHàng02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.cácCửaHàngToolStripMenuItem});
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
            // cácCửaHàngToolStripMenuItem
            // 
            this.cácCửaHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cửaHàng01ToolStripMenuItem,
            this.cửaHàng02ToolStripMenuItem});
            this.cácCửaHàngToolStripMenuItem.Name = "cácCửaHàngToolStripMenuItem";
            this.cácCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.cácCửaHàngToolStripMenuItem.Text = "Các cửa hàng";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // tínhLươngToolStripMenuItem
            // 
            this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
            this.tínhLươngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tínhLươngToolStripMenuItem.Text = "Tính lương";
            // 
            // cửaHàng01ToolStripMenuItem
            // 
            this.cửaHàng01ToolStripMenuItem.Name = "cửaHàng01ToolStripMenuItem";
            this.cửaHàng01ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cửaHàng01ToolStripMenuItem.Text = "Cửa hàng 01";
            // 
            // cửaHàng02ToolStripMenuItem
            // 
            this.cửaHàng02ToolStripMenuItem.Name = "cửaHàng02ToolStripMenuItem";
            this.cửaHàng02ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cửaHàng02ToolStripMenuItem.Text = "Cửa hàng 02";
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
    }
}