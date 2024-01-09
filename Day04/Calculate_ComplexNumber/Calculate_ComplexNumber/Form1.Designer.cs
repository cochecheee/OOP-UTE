namespace Calculate_ComplexNumber
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
            this.realLable = new System.Windows.Forms.Label();
            this.imaginaryLable = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.statusLable = new System.Windows.Forms.Label();
            this.imaginaryTexbox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.setno2Button = new System.Windows.Forms.Button();
            this.setno1Button = new System.Windows.Forms.Button();
            this.realTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // realLable
            // 
            this.realLable.AutoSize = true;
            this.realLable.Location = new System.Drawing.Point(64, 37);
            this.realLable.Name = "realLable";
            this.realLable.Size = new System.Drawing.Size(38, 20);
            this.realLable.TabIndex = 0;
            this.realLable.Text = "Real";
            // 
            // imaginaryLable
            // 
            this.imaginaryLable.AutoSize = true;
            this.imaginaryLable.Location = new System.Drawing.Point(64, 127);
            this.imaginaryLable.Name = "imaginaryLable";
            this.imaginaryLable.Size = new System.Drawing.Size(75, 20);
            this.imaginaryLable.TabIndex = 0;
            this.imaginaryLable.Text = "Imaginary";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(75, 353);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(49, 20);
            this.resultLable.TabIndex = 0;
            this.resultLable.Text = "Result";
            this.resultLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.Location = new System.Drawing.Point(304, 300);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(83, 20);
            this.statusLable.TabIndex = 0;
            this.statusLable.Text = "statusLable";
            // 
            // imaginaryTexbox
            // 
            this.imaginaryTexbox.Location = new System.Drawing.Point(229, 124);
            this.imaginaryTexbox.Name = "imaginaryTexbox";
            this.imaginaryTexbox.Size = new System.Drawing.Size(125, 27);
            this.imaginaryTexbox.TabIndex = 1;
            this.imaginaryTexbox.TextChanged += new System.EventHandler(this.imaginaryTexbox_TextChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(207, 353);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(377, 27);
            this.resultTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(64, 238);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(238, 238);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(94, 29);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(415, 238);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(94, 29);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // setno2Button
            // 
            this.setno2Button.Location = new System.Drawing.Point(415, 123);
            this.setno2Button.Name = "setno2Button";
            this.setno2Button.Size = new System.Drawing.Size(94, 29);
            this.setno2Button.TabIndex = 2;
            this.setno2Button.Text = "Set No 2";
            this.setno2Button.UseVisualStyleBackColor = true;
            this.setno2Button.Click += new System.EventHandler(this.setno2Button_Click);
            // 
            // setno1Button
            // 
            this.setno1Button.Location = new System.Drawing.Point(415, 37);
            this.setno1Button.Name = "setno1Button";
            this.setno1Button.Size = new System.Drawing.Size(94, 29);
            this.setno1Button.TabIndex = 2;
            this.setno1Button.Text = "Set No 1";
            this.setno1Button.UseVisualStyleBackColor = true;
            this.setno1Button.Click += new System.EventHandler(this.setno1Button_Click);
            // 
            // realTextbox
            // 
            this.realTextbox.Location = new System.Drawing.Point(229, 39);
            this.realTextbox.Name = "realTextbox";
            this.realTextbox.Size = new System.Drawing.Size(125, 27);
            this.realTextbox.TabIndex = 1;
            this.realTextbox.TextChanged += new System.EventHandler(this.realTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setno1Button);
            this.Controls.Add(this.setno2Button);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.imaginaryTexbox);
            this.Controls.Add(this.realTextbox);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.imaginaryLable);
            this.Controls.Add(this.realLable);
            this.Name = "Form1";
            this.Text = "Máy tính số thực";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label realLable;
        private Label imaginaryLable;
        private Label resultLable;
        private Label statusLable;
        private TextBox imaginaryTexbox;
        private TextBox resultTextBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button setno2Button;
        private Button setno1Button;
        private TextBox realTextbox;
    }
}