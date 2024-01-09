namespace Bai_Kiem_Tra_Giua_Ki_Matrix
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
            this.row1Lable = new System.Windows.Forms.Label();
            this.row2Lable = new System.Windows.Forms.Label();
            this.setMatrix1Button = new System.Windows.Forms.Button();
            this.setMatrix2Button = new System.Windows.Forms.Button();
            this.col1Lable = new System.Windows.Forms.Label();
            this.col2Lable = new System.Windows.Forms.Label();
            this.rc11TextBox = new System.Windows.Forms.TextBox();
            this.rc12TextBox = new System.Windows.Forms.TextBox();
            this.rc21TextBox = new System.Windows.Forms.TextBox();
            this.rc22TextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // row1Lable
            // 
            this.row1Lable.AutoSize = true;
            this.row1Lable.Location = new System.Drawing.Point(63, 94);
            this.row1Lable.Name = "row1Lable";
            this.row1Lable.Size = new System.Drawing.Size(50, 20);
            this.row1Lable.TabIndex = 0;
            this.row1Lable.Text = "Row 1";
            // 
            // row2Lable
            // 
            this.row2Lable.AutoSize = true;
            this.row2Lable.Location = new System.Drawing.Point(63, 165);
            this.row2Lable.Name = "row2Lable";
            this.row2Lable.Size = new System.Drawing.Size(50, 20);
            this.row2Lable.TabIndex = 0;
            this.row2Lable.Text = "Row 2";
            // 
            // setMatrix1Button
            // 
            this.setMatrix1Button.Location = new System.Drawing.Point(354, 94);
            this.setMatrix1Button.Name = "setMatrix1Button";
            this.setMatrix1Button.Size = new System.Drawing.Size(119, 29);
            this.setMatrix1Button.TabIndex = 1;
            this.setMatrix1Button.Text = "Set Matrix 1";
            this.setMatrix1Button.UseVisualStyleBackColor = true;
            this.setMatrix1Button.Click += new System.EventHandler(this.setMatrix1Button_Click);
            // 
            // setMatrix2Button
            // 
            this.setMatrix2Button.Location = new System.Drawing.Point(354, 165);
            this.setMatrix2Button.Name = "setMatrix2Button";
            this.setMatrix2Button.Size = new System.Drawing.Size(119, 29);
            this.setMatrix2Button.TabIndex = 1;
            this.setMatrix2Button.Text = "Set Matrix 2";
            this.setMatrix2Button.UseVisualStyleBackColor = true;
            this.setMatrix2Button.Click += new System.EventHandler(this.setMatrix2Button_Click);
            // 
            // col1Lable
            // 
            this.col1Lable.AutoSize = true;
            this.col1Lable.Location = new System.Drawing.Point(157, 53);
            this.col1Lable.Name = "col1Lable";
            this.col1Lable.Size = new System.Drawing.Size(43, 20);
            this.col1Lable.TabIndex = 0;
            this.col1Lable.Text = "Col 1";
            // 
            // col2Lable
            // 
            this.col2Lable.AutoSize = true;
            this.col2Lable.Location = new System.Drawing.Point(267, 53);
            this.col2Lable.Name = "col2Lable";
            this.col2Lable.Size = new System.Drawing.Size(43, 20);
            this.col2Lable.TabIndex = 0;
            this.col2Lable.Text = "Col 2";
            // 
            // rc11TextBox
            // 
            this.rc11TextBox.Location = new System.Drawing.Point(141, 94);
            this.rc11TextBox.Name = "rc11TextBox";
            this.rc11TextBox.Size = new System.Drawing.Size(71, 27);
            this.rc11TextBox.TabIndex = 2;
            // 
            // rc12TextBox
            // 
            this.rc12TextBox.Location = new System.Drawing.Point(255, 94);
            this.rc12TextBox.Name = "rc12TextBox";
            this.rc12TextBox.Size = new System.Drawing.Size(71, 27);
            this.rc12TextBox.TabIndex = 2;
            // 
            // rc21TextBox
            // 
            this.rc21TextBox.Location = new System.Drawing.Point(141, 163);
            this.rc21TextBox.Name = "rc21TextBox";
            this.rc21TextBox.Size = new System.Drawing.Size(71, 27);
            this.rc21TextBox.TabIndex = 2;
            // 
            // rc22TextBox
            // 
            this.rc22TextBox.Location = new System.Drawing.Point(255, 163);
            this.rc22TextBox.Name = "rc22TextBox";
            this.rc22TextBox.Size = new System.Drawing.Size(71, 27);
            this.rc22TextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(73, 248);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(255, 248);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(94, 29);
            this.subtractButton.TabIndex = 3;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(448, 248);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(94, 29);
            this.multiplyButton.TabIndex = 3;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(314, 340);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(58, 20);
            this.resultLable.TabIndex = 4;
            this.resultLable.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.rc22TextBox);
            this.Controls.Add(this.rc21TextBox);
            this.Controls.Add(this.rc12TextBox);
            this.Controls.Add(this.rc11TextBox);
            this.Controls.Add(this.setMatrix2Button);
            this.Controls.Add(this.setMatrix1Button);
            this.Controls.Add(this.row2Lable);
            this.Controls.Add(this.col2Lable);
            this.Controls.Add(this.col1Lable);
            this.Controls.Add(this.row1Lable);
            this.Name = "Form1";
            this.Text = "Quai dan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label row1Lable;
        private Label row2Lable;
        private Button setMatrix1Button;
        private Button setMatrix2Button;
        private Label col1Lable;
        private Label col2Lable;
        private TextBox rc11TextBox;
        private TextBox rc12TextBox;
        private TextBox rc21TextBox;
        private TextBox rc22TextBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Label resultLable;
    }
}