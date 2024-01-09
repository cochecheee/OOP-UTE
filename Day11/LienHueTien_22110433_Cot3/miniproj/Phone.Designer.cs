namespace miniproj
{
    partial class Phone
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
            this.soseriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthietbiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsanxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniprojectDataSet4 = new miniproj.miniprojectDataSet4();
            this.btn_ban = new System.Windows.Forms.Button();
            this.devicesTableAdapter = new miniproj.miniprojectDataSet4TableAdapters.devicesTableAdapter();
            this.txt_ban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soseriDataGridViewTextBoxColumn,
            this.tenthietbiDataGridViewTextBoxColumn,
            this.mausachDataGridViewTextBoxColumn,
            this.namsanxuatDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 311);
            this.dataGridView1.TabIndex = 24;
            // 
            // soseriDataGridViewTextBoxColumn
            // 
            this.soseriDataGridViewTextBoxColumn.DataPropertyName = "Soseri";
            this.soseriDataGridViewTextBoxColumn.HeaderText = "Soseri";
            this.soseriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soseriDataGridViewTextBoxColumn.Name = "soseriDataGridViewTextBoxColumn";
            this.soseriDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenthietbiDataGridViewTextBoxColumn
            // 
            this.tenthietbiDataGridViewTextBoxColumn.DataPropertyName = "Tenthietbi";
            this.tenthietbiDataGridViewTextBoxColumn.HeaderText = "Tenthietbi";
            this.tenthietbiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenthietbiDataGridViewTextBoxColumn.Name = "tenthietbiDataGridViewTextBoxColumn";
            this.tenthietbiDataGridViewTextBoxColumn.Width = 125;
            // 
            // mausachDataGridViewTextBoxColumn
            // 
            this.mausachDataGridViewTextBoxColumn.DataPropertyName = "Mausach";
            this.mausachDataGridViewTextBoxColumn.HeaderText = "Mausach";
            this.mausachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mausachDataGridViewTextBoxColumn.Name = "mausachDataGridViewTextBoxColumn";
            this.mausachDataGridViewTextBoxColumn.Width = 125;
            // 
            // namsanxuatDataGridViewTextBoxColumn
            // 
            this.namsanxuatDataGridViewTextBoxColumn.DataPropertyName = "Namsanxuat";
            this.namsanxuatDataGridViewTextBoxColumn.HeaderText = "Namsanxuat";
            this.namsanxuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namsanxuatDataGridViewTextBoxColumn.Name = "namsanxuatDataGridViewTextBoxColumn";
            this.namsanxuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "devices";
            this.devicesBindingSource.DataSource = this.miniprojectDataSet4;
            // 
            // miniprojectDataSet4
            // 
            this.miniprojectDataSet4.DataSetName = "miniprojectDataSet4";
            this.miniprojectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ban
            // 
            this.btn_ban.Location = new System.Drawing.Point(458, 31);
            this.btn_ban.Name = "btn_ban";
            this.btn_ban.Size = new System.Drawing.Size(103, 37);
            this.btn_ban.TabIndex = 23;
            this.btn_ban.Text = "Bán";
            this.btn_ban.UseVisualStyleBackColor = true;
            this.btn_ban.Click += new System.EventHandler(this.btn_ban_Click);
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // txt_ban
            // 
            this.txt_ban.Location = new System.Drawing.Point(271, 42);
            this.txt_ban.Name = "txt_ban";
            this.txt_ban.Size = new System.Drawing.Size(167, 22);
            this.txt_ban.TabIndex = 25;
            this.txt_ban.TextChanged += new System.EventHandler(this.txt_ban_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Seri";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ban);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ban);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ban;
        private miniprojectDataSet4 miniprojectDataSet4;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private miniprojectDataSet4TableAdapters.devicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soseriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsanxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_ban;
        private System.Windows.Forms.Label label8;
    }
}