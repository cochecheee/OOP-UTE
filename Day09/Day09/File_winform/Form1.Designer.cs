namespace File_winform
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
            label1 = new Label();
            rdbt = new RadioButton();
            rdbt_createDisk = new RadioButton();
            rtShow = new RichTextBox();
            btn_Hienthi = new Button();
            btn_Xoa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Lựa chọn";
            // 
            // rdbt
            // 
            rdbt.AutoSize = true;
            rdbt.Location = new Point(39, 96);
            rdbt.Name = "rdbt";
            rdbt.Size = new Size(118, 24);
            rdbt.TabIndex = 1;
            rdbt.TabStop = true;
            rdbt.Text = "Thông tin file";
            rdbt.UseVisualStyleBackColor = true;
            // 
            // rdbt_createDisk
            // 
            rdbt_createDisk.AutoSize = true;
            rdbt_createDisk.Location = new Point(39, 144);
            rdbt_createDisk.Name = "rdbt_createDisk";
            rdbt_createDisk.Size = new Size(113, 24);
            rdbt_createDisk.TabIndex = 1;
            rdbt_createDisk.TabStop = true;
            rdbt_createDisk.Text = "Tạo thư mục";
            rdbt_createDisk.UseVisualStyleBackColor = true;
            // 
            // rtShow
            // 
            rtShow.Location = new Point(308, 96);
            rtShow.Name = "rtShow";
            rtShow.Size = new Size(453, 268);
            rtShow.TabIndex = 2;
            rtShow.Text = "";
            // 
            // btn_Hienthi
            // 
            btn_Hienthi.Location = new Point(308, 387);
            btn_Hienthi.Name = "btn_Hienthi";
            btn_Hienthi.Size = new Size(94, 29);
            btn_Hienthi.TabIndex = 3;
            btn_Hienthi.Text = "Hiển thị";
            btn_Hienthi.UseVisualStyleBackColor = true;
            btn_Hienthi.Click += btn_Hienthi_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(442, 387);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 3;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Hienthi);
            Controls.Add(rtShow);
            Controls.Add(rdbt_createDisk);
            Controls.Add(rdbt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdbt;
        private RadioButton rdbt_createDisk;
        private RichTextBox rtShow;
        private Button btn_Hienthi;
        private Button btn_Xoa;
    }
}