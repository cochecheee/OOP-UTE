namespace Employee_winforms
{
    partial class Form1
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
            this.firstNameLable = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameButton = new System.Windows.Forms.Button();
            this.lastNameButton = new System.Windows.Forms.Button();
            this.dayLable = new System.Windows.Forms.Label();
            this.monthLable = new System.Windows.Forms.Label();
            this.yearLable = new System.Windows.Forms.Label();
            this.dayTextbox = new System.Windows.Forms.TextBox();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.setHiredButton = new System.Windows.Forms.Button();
            this.setBirthButton = new System.Windows.Forms.Button();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Location = new System.Drawing.Point(56, 42);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(80, 20);
            this.firstNameLable.TabIndex = 0;
            this.firstNameLable.Text = "First Name";
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(56, 99);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(79, 20);
            this.lastNameLable.TabIndex = 1;
            this.lastNameLable.Text = "Last Name";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(223, 39);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(125, 27);
            this.firstNameTextbox.TabIndex = 2;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(223, 96);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(125, 27);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // firstNameButton
            // 
            this.firstNameButton.Location = new System.Drawing.Point(446, 38);
            this.firstNameButton.Name = "firstNameButton";
            this.firstNameButton.Size = new System.Drawing.Size(128, 29);
            this.firstNameButton.TabIndex = 3;
            this.firstNameButton.Text = "Set First Name";
            this.firstNameButton.UseVisualStyleBackColor = true;
            this.firstNameButton.Click += new System.EventHandler(this.firstNameButton_Click);
            // 
            // lastNameButton
            // 
            this.lastNameButton.Location = new System.Drawing.Point(446, 96);
            this.lastNameButton.Name = "lastNameButton";
            this.lastNameButton.Size = new System.Drawing.Size(128, 29);
            this.lastNameButton.TabIndex = 4;
            this.lastNameButton.Text = "Set Last Name";
            this.lastNameButton.UseVisualStyleBackColor = true;
            this.lastNameButton.Click += new System.EventHandler(this.lastNameButton_Click);
            // 
            // dayLable
            // 
            this.dayLable.AutoSize = true;
            this.dayLable.Location = new System.Drawing.Point(67, 194);
            this.dayLable.Name = "dayLable";
            this.dayLable.Size = new System.Drawing.Size(35, 20);
            this.dayLable.TabIndex = 5;
            this.dayLable.Text = "Day";
            this.dayLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthLable
            // 
            this.monthLable.AutoSize = true;
            this.monthLable.Location = new System.Drawing.Point(67, 249);
            this.monthLable.Name = "monthLable";
            this.monthLable.Size = new System.Drawing.Size(52, 20);
            this.monthLable.TabIndex = 6;
            this.monthLable.Text = "Month";
            // 
            // yearLable
            // 
            this.yearLable.AutoSize = true;
            this.yearLable.Location = new System.Drawing.Point(67, 304);
            this.yearLable.Name = "yearLable";
            this.yearLable.Size = new System.Drawing.Size(37, 20);
            this.yearLable.TabIndex = 7;
            this.yearLable.Text = "Year";
            // 
            // dayTextbox
            // 
            this.dayTextbox.Location = new System.Drawing.Point(223, 191);
            this.dayTextbox.Name = "dayTextbox";
            this.dayTextbox.Size = new System.Drawing.Size(125, 27);
            this.dayTextbox.TabIndex = 8;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Location = new System.Drawing.Point(223, 242);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(125, 27);
            this.monthTextbox.TabIndex = 8;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(223, 297);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(125, 27);
            this.yearTextbox.TabIndex = 8;
            // 
            // setHiredButton
            // 
            this.setHiredButton.Location = new System.Drawing.Point(446, 216);
            this.setHiredButton.Name = "setHiredButton";
            this.setHiredButton.Size = new System.Drawing.Size(128, 29);
            this.setHiredButton.TabIndex = 9;
            this.setHiredButton.Text = "Hired Date";
            this.setHiredButton.UseVisualStyleBackColor = true;
            this.setHiredButton.Click += new System.EventHandler(this.setHiredButton_Click);
            // 
            // setBirthButton
            // 
            this.setBirthButton.Location = new System.Drawing.Point(446, 272);
            this.setBirthButton.Name = "setBirthButton";
            this.setBirthButton.Size = new System.Drawing.Size(128, 29);
            this.setBirthButton.TabIndex = 10;
            this.setBirthButton.Text = "Birth Date";
            this.setBirthButton.UseVisualStyleBackColor = true;
            this.setBirthButton.Click += new System.EventHandler(this.setBirthButton_Click);
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(119, 371);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(510, 27);
            this.resultTextbox.TabIndex = 11;
            this.resultTextbox.TextChanged += new System.EventHandler(this.resultTextbox_TextChanged);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(675, 369);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(94, 29);
            this.resultButton.TabIndex = 12;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.setBirthButton);
            this.Controls.Add(this.setHiredButton);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.dayTextbox);
            this.Controls.Add(this.yearLable);
            this.Controls.Add(this.monthLable);
            this.Controls.Add(this.dayLable);
            this.Controls.Add(this.lastNameButton);
            this.Controls.Add(this.firstNameButton);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.firstNameLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLable;
        private Label lastNameLable;
        private TextBox firstNameTextbox;
        private TextBox lastNameTextbox;
        private Button firstNameButton;
        private Button lastNameButton;
        private Label dayLable;
        private Label monthLable;
        private Label yearLable;
        private TextBox dayTextbox;
        private TextBox monthTextbox;
        private TextBox yearTextbox;
        private Button setHiredButton;
        private Button setBirthButton;
        private TextBox resultTextbox;
        private Button resultButton;
    }
}