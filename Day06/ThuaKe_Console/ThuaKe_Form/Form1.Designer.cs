namespace ThuaKe_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tamGiac_btn = new System.Windows.Forms.Button();
            this.doanThang_btn = new System.Windows.Forms.Button();
            this.tuGiac_btn = new System.Windows.Forms.Button();
            this.circleShape_btn = new System.Windows.Forms.Button();
            this.hinhVuong_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tamGiac_btn
            // 
            this.tamGiac_btn.Location = new System.Drawing.Point(64, 72);
            this.tamGiac_btn.Name = "tamGiac_btn";
            this.tamGiac_btn.Size = new System.Drawing.Size(94, 29);
            this.tamGiac_btn.TabIndex = 0;
            this.tamGiac_btn.Text = "Tam giác";
            this.tamGiac_btn.UseVisualStyleBackColor = true;
            this.tamGiac_btn.Click += new System.EventHandler(this.tamGiac_btn_Click);
            // 
            // doanThang_btn
            // 
            this.doanThang_btn.Location = new System.Drawing.Point(213, 72);
            this.doanThang_btn.Name = "doanThang_btn";
            this.doanThang_btn.Size = new System.Drawing.Size(99, 29);
            this.doanThang_btn.TabIndex = 0;
            this.doanThang_btn.Text = "Đoạn thẳng";
            this.doanThang_btn.UseVisualStyleBackColor = true;
            this.doanThang_btn.Click += new System.EventHandler(this.doanThang_btn_Click);
            // 
            // tuGiac_btn
            // 
            this.tuGiac_btn.Location = new System.Drawing.Point(353, 72);
            this.tuGiac_btn.Name = "tuGiac_btn";
            this.tuGiac_btn.Size = new System.Drawing.Size(94, 29);
            this.tuGiac_btn.TabIndex = 0;
            this.tuGiac_btn.Text = "Tứ giác";
            this.tuGiac_btn.UseVisualStyleBackColor = true;
            this.tuGiac_btn.Click += new System.EventHandler(this.tuGiac_btn_Click);
            // 
            // circleShape_btn
            // 
            this.circleShape_btn.Location = new System.Drawing.Point(641, 72);
            this.circleShape_btn.Name = "circleShape_btn";
            this.circleShape_btn.Size = new System.Drawing.Size(94, 29);
            this.circleShape_btn.TabIndex = 0;
            this.circleShape_btn.Text = "Hình Tròn";
            this.circleShape_btn.UseVisualStyleBackColor = true;
            this.circleShape_btn.Click += new System.EventHandler(this.circleShape_btn_Click);
            // 
            // hinhVuong_btn
            // 
            this.hinhVuong_btn.Location = new System.Drawing.Point(498, 72);
            this.hinhVuong_btn.Name = "hinhVuong_btn";
            this.hinhVuong_btn.Size = new System.Drawing.Size(99, 29);
            this.hinhVuong_btn.TabIndex = 0;
            this.hinhVuong_btn.Text = "Hình Vuông";
            this.hinhVuong_btn.UseVisualStyleBackColor = true;
            this.hinhVuong_btn.Click += new System.EventHandler(this.hinhVuong_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 236);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Picture Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hinhVuong_btn);
            this.Controls.Add(this.circleShape_btn);
            this.Controls.Add(this.tuGiac_btn);
            this.Controls.Add(this.doanThang_btn);
            this.Controls.Add(this.tamGiac_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tamGiac_btn;
        private Button doanThang_btn;
        private Button tuGiac_btn;
        private Button circleShape_btn;
        private Button hinhVuong_btn;
        private PictureBox pictureBox1;
        private Label label1;
    }
}