namespace miniproj
{
    partial class Sach
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniprojectDataSet5 = new miniproj.miniprojectDataSet5();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ban = new System.Windows.Forms.TextBox();
            this.btn_ban = new System.Windows.Forms.Button();
            this.bookTableAdapter = new miniproj.miniprojectDataSet5TableAdapters.bookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.tensachDataGridViewTextBoxColumn,
            this.tacgiaDataGridViewTextBoxColumn,
            this.nhaxuatbanDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 327);
            this.dataGridView1.TabIndex = 38;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "Tensach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "Tensach";
            this.tensachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            this.tensachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tacgiaDataGridViewTextBoxColumn
            // 
            this.tacgiaDataGridViewTextBoxColumn.DataPropertyName = "Tacgia";
            this.tacgiaDataGridViewTextBoxColumn.HeaderText = "Tacgia";
            this.tacgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tacgiaDataGridViewTextBoxColumn.Name = "tacgiaDataGridViewTextBoxColumn";
            this.tacgiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhaxuatbanDataGridViewTextBoxColumn
            // 
            this.nhaxuatbanDataGridViewTextBoxColumn.DataPropertyName = "Nhaxuatban";
            this.nhaxuatbanDataGridViewTextBoxColumn.HeaderText = "Nhaxuatban";
            this.nhaxuatbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaxuatbanDataGridViewTextBoxColumn.Name = "nhaxuatbanDataGridViewTextBoxColumn";
            this.nhaxuatbanDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.miniprojectDataSet5;
            // 
            // miniprojectDataSet5
            // 
            this.miniprojectDataSet5.DataSetName = "miniprojectDataSet5";
            this.miniprojectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "ISBN";
            // 
            // txt_ban
            // 
            this.txt_ban.Location = new System.Drawing.Point(246, 30);
            this.txt_ban.Name = "txt_ban";
            this.txt_ban.Size = new System.Drawing.Size(218, 22);
            this.txt_ban.TabIndex = 40;
            // 
            // btn_ban
            // 
            this.btn_ban.Location = new System.Drawing.Point(490, 29);
            this.btn_ban.Name = "btn_ban";
            this.btn_ban.Size = new System.Drawing.Size(82, 25);
            this.btn_ban.TabIndex = 37;
            this.btn_ban.Text = "Bán";
            this.btn_ban.UseVisualStyleBackColor = true;
            this.btn_ban.Click += new System.EventHandler(this.btn_ban_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ban);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ban;
        private System.Windows.Forms.Button btn_ban;
        private miniprojectDataSet5 miniprojectDataSet5;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private miniprojectDataSet5TableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}