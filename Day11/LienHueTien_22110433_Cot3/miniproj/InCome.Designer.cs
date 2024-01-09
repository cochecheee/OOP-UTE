namespace miniproj
{
    partial class InCome
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
            this.giaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangbanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniprojectDataSet7 = new miniproj.miniprojectDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tenthietbiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsanxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soseriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonestoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniprojectDataSet6 = new miniproj.miniprojectDataSet6();
            this.brn_xuatfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phonestoreTableAdapter = new miniproj.miniprojectDataSet6TableAdapters.phonestoreTableAdapter();
            this.bookstoreTableAdapter = new miniproj.miniprojectDataSet7TableAdapters.bookstoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonestoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet6)).BeginInit();
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
            this.giaDataGridViewTextBoxColumn1,
            this.thangbanDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bookstoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 249);
            this.dataGridView1.TabIndex = 0;
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
            // giaDataGridViewTextBoxColumn1
            // 
            this.giaDataGridViewTextBoxColumn1.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn1.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn1.Name = "giaDataGridViewTextBoxColumn1";
            this.giaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // thangbanDataGridViewTextBoxColumn1
            // 
            this.thangbanDataGridViewTextBoxColumn1.DataPropertyName = "Thangban";
            this.thangbanDataGridViewTextBoxColumn1.HeaderText = "Thangban";
            this.thangbanDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.thangbanDataGridViewTextBoxColumn1.Name = "thangbanDataGridViewTextBoxColumn1";
            this.thangbanDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookstoreBindingSource
            // 
            this.bookstoreBindingSource.DataMember = "bookstore";
            this.bookstoreBindingSource.DataSource = this.miniprojectDataSet7;
            // 
            // miniprojectDataSet7
            // 
            this.miniprojectDataSet7.DataSetName = "miniprojectDataSet7";
            this.miniprojectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh thu tháng";
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(520, 321);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(285, 22);
            this.txt_thang.TabIndex = 2;
            this.txt_thang.TextChanged += new System.EventHandler(this.txt_thang_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenthietbiDataGridViewTextBoxColumn,
            this.namsanxuatDataGridViewTextBoxColumn,
            this.mausacDataGridViewTextBoxColumn,
            this.soseriDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.thangbanDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.phonestoreBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(63, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(848, 237);
            this.dataGridView2.TabIndex = 0;
            // 
            // tenthietbiDataGridViewTextBoxColumn
            // 
            this.tenthietbiDataGridViewTextBoxColumn.DataPropertyName = "Tenthietbi";
            this.tenthietbiDataGridViewTextBoxColumn.HeaderText = "Tenthietbi";
            this.tenthietbiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenthietbiDataGridViewTextBoxColumn.Name = "tenthietbiDataGridViewTextBoxColumn";
            this.tenthietbiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namsanxuatDataGridViewTextBoxColumn
            // 
            this.namsanxuatDataGridViewTextBoxColumn.DataPropertyName = "Namsanxuat";
            this.namsanxuatDataGridViewTextBoxColumn.HeaderText = "Namsanxuat";
            this.namsanxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namsanxuatDataGridViewTextBoxColumn.Name = "namsanxuatDataGridViewTextBoxColumn";
            this.namsanxuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // mausacDataGridViewTextBoxColumn
            // 
            this.mausacDataGridViewTextBoxColumn.DataPropertyName = "Mausac";
            this.mausacDataGridViewTextBoxColumn.HeaderText = "Mausac";
            this.mausacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mausacDataGridViewTextBoxColumn.Name = "mausacDataGridViewTextBoxColumn";
            this.mausacDataGridViewTextBoxColumn.Width = 125;
            // 
            // soseriDataGridViewTextBoxColumn
            // 
            this.soseriDataGridViewTextBoxColumn.DataPropertyName = "Soseri";
            this.soseriDataGridViewTextBoxColumn.HeaderText = "Soseri";
            this.soseriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soseriDataGridViewTextBoxColumn.Name = "soseriDataGridViewTextBoxColumn";
            this.soseriDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangbanDataGridViewTextBoxColumn
            // 
            this.thangbanDataGridViewTextBoxColumn.DataPropertyName = "Thangban";
            this.thangbanDataGridViewTextBoxColumn.HeaderText = "Thangban";
            this.thangbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangbanDataGridViewTextBoxColumn.Name = "thangbanDataGridViewTextBoxColumn";
            this.thangbanDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonestoreBindingSource
            // 
            this.phonestoreBindingSource.DataMember = "phonestore";
            this.phonestoreBindingSource.DataSource = this.miniprojectDataSet6;
            // 
            // miniprojectDataSet6
            // 
            this.miniprojectDataSet6.DataSetName = "miniprojectDataSet6";
            this.miniprojectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brn_xuatfile
            // 
            this.brn_xuatfile.Location = new System.Drawing.Point(706, 12);
            this.brn_xuatfile.Name = "brn_xuatfile";
            this.brn_xuatfile.Size = new System.Drawing.Size(192, 32);
            this.brn_xuatfile.TabIndex = 3;
            this.brn_xuatfile.Text = "Xuất file";
            this.brn_xuatfile.UseVisualStyleBackColor = true;
            this.brn_xuatfile.Click += new System.EventHandler(this.brn_xuatfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book store";
            // 
            // phonestoreTableAdapter
            // 
            this.phonestoreTableAdapter.ClearBeforeFill = true;
            // 
            // bookstoreTableAdapter
            // 
            this.bookstoreTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 626);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brn_xuatfile);
            this.Controls.Add(this.txt_thang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonestoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button brn_xuatfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private miniprojectDataSet6 miniprojectDataSet6;
        private System.Windows.Forms.BindingSource phonestoreBindingSource;
        private miniprojectDataSet6TableAdapters.phonestoreTableAdapter phonestoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsanxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soseriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangbanDataGridViewTextBoxColumn;
        private miniprojectDataSet7 miniprojectDataSet7;
        private System.Windows.Forms.BindingSource bookstoreBindingSource;
        private miniprojectDataSet7TableAdapters.bookstoreTableAdapter bookstoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangbanDataGridViewTextBoxColumn1;
    }
}