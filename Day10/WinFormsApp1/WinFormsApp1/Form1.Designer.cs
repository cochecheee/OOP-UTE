namespace WinFormsApp1
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
            gbInformation = new GroupBox();
            txtDept = new TextBox();
            txtName = new TextBox();
            txtemID = new TextBox();
            lblDept = new Label();
            lblemID = new Label();
            lblName = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblFind = new Label();
            txtFind = new TextBox();
            dataGridView1 = new DataGridView();
            gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbInformation
            // 
            gbInformation.Controls.Add(txtDept);
            gbInformation.Controls.Add(txtName);
            gbInformation.Controls.Add(txtemID);
            gbInformation.Controls.Add(lblDept);
            gbInformation.Controls.Add(lblemID);
            gbInformation.Controls.Add(lblName);
            gbInformation.Location = new Point(38, 42);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new Size(350, 184);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Information";
            // 
            // txtDept
            // 
            txtDept.Location = new Point(105, 134);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(206, 27);
            txtDept.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 27);
            txtName.TabIndex = 2;
            // 
            // txtemID
            // 
            txtemID.Location = new Point(105, 42);
            txtemID.Name = "txtemID";
            txtemID.Size = new Size(206, 27);
            txtemID.TabIndex = 2;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(32, 137);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(42, 20);
            lblDept.TabIndex = 1;
            lblDept.Text = "Dept";
            // 
            // lblemID
            // 
            lblemID.AutoSize = true;
            lblemID.Location = new Point(32, 45);
            lblemID.Name = "lblemID";
            lblemID.Size = new Size(47, 20);
            lblemID.TabIndex = 0;
            lblemID.Text = "Em Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(163, 278);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(294, 278);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(37, 343);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(37, 20);
            lblFind.TabIndex = 2;
            lblFind.Text = "Find";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(108, 344);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(241, 27);
            txtFind.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 410);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(351, 188);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 647);
            Controls.Add(dataGridView1);
            Controls.Add(txtFind);
            Controls.Add(lblFind);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(gbInformation);
            Name = "Form1";
            Text = "Form1";
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbInformation;
        private Label lblDept;
        private Label lblemID;
        private Label lblName;
        private TextBox txtDept;
        private TextBox txtName;
        private TextBox txtemID;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblFind;
        private TextBox txtFind;
        private DataGridView dataGridView1;
    }
}
