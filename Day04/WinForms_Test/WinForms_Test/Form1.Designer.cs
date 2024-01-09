namespace WinForms_Test
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
            this.lb_label01 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_label03 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_button01 = new System.Windows.Forms.Button();
            this.bt_button02 = new System.Windows.Forms.Button();
            this.bt_button03 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_label01
            // 
            this.lb_label01.AutoSize = true;
            this.lb_label01.Location = new System.Drawing.Point(93, 69);
            this.lb_label01.Name = "lb_label01";
            this.lb_label01.Size = new System.Drawing.Size(38, 20);
            this.lb_label01.TabIndex = 0;
            this.lb_label01.Text = "Real";
            this.lb_label01.Click += new System.EventHandler(this.lb_label01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_label03
            // 
            this.lb_label03.AutoSize = true;
            this.lb_label03.Location = new System.Drawing.Point(93, 147);
            this.lb_label03.Name = "lb_label03";
            this.lb_label03.Size = new System.Drawing.Size(75, 20);
            this.lb_label03.TabIndex = 0;
            this.lb_label03.Text = "Imaginary";
            this.lb_label03.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 27);
            this.textBox2.TabIndex = 1;
            // 
            // bt_button01
            // 
            this.bt_button01.Location = new System.Drawing.Point(81, 224);
            this.bt_button01.Name = "bt_button01";
            this.bt_button01.Size = new System.Drawing.Size(94, 29);
            this.bt_button01.TabIndex = 2;
            this.bt_button01.Text = "Add";
            this.bt_button01.UseVisualStyleBackColor = true;
            // 
            // bt_button02
            // 
            this.bt_button02.Location = new System.Drawing.Point(259, 224);
            this.bt_button02.Name = "bt_button02";
            this.bt_button02.Size = new System.Drawing.Size(94, 29);
            this.bt_button02.TabIndex = 2;
            this.bt_button02.Text = "Subtract";
            this.bt_button02.UseVisualStyleBackColor = true;
            // 
            // bt_button03
            // 
            this.bt_button03.Location = new System.Drawing.Point(428, 224);
            this.bt_button03.Name = "bt_button03";
            this.bt_button03.Size = new System.Drawing.Size(94, 29);
            this.bt_button03.TabIndex = 2;
            this.bt_button03.Text = "Modify";
            this.bt_button03.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Set No 2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Set No 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_button03);
            this.Controls.Add(this.bt_button02);
            this.Controls.Add(this.bt_button01);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_label03);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_label01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_label01;
        private Label label2;
        private Label lb_label03;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button bt_button01;
        private Button bt_button02;
        private Button bt_button03;
        private Button button4;
        private Button button5;
    }
}