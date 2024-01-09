namespace miniproj
{
    partial class NV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniprojectDataSet1 = new miniproj.miniprojectDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.miniprojectDataSet = new miniproj.miniprojectDataSet();
            this.miniprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniTableAdapter = new miniproj.miniprojectDataSet1TableAdapters.miniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lương ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tuổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.phongDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.miniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongDataGridViewTextBoxColumn
            // 
            this.phongDataGridViewTextBoxColumn.DataPropertyName = "Phong";
            this.phongDataGridViewTextBoxColumn.HeaderText = "Phong";
            this.phongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
            this.phongDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            this.tuoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // miniBindingSource
            // 
            this.miniBindingSource.DataMember = "mini";
            this.miniBindingSource.DataSource = this.miniprojectDataSet1;
            // 
            // miniprojectDataSet1
            // 
            this.miniprojectDataSet1.DataSetName = "miniprojectDataSet1";
            this.miniprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kết quả";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(446, 56);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(446, 108);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(446, 168);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(446, 225);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(214, 22);
            this.txt_id.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(137, 79);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(214, 22);
            this.txt_ten.TabIndex = 3;
            // 
            // txt_phong
            // 
            this.txt_phong.Location = new System.Drawing.Point(137, 122);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(214, 22);
            this.txt_phong.TabIndex = 3;
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(137, 168);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(214, 22);
            this.txt_luong.TabIndex = 3;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(137, 222);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(214, 22);
            this.txt_tuoi.TabIndex = 3;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(137, 271);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(214, 22);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyUp);
            // 
            // miniprojectDataSet
            // 
            this.miniprojectDataSet.DataSetName = "miniprojectDataSet";
            this.miniprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miniprojectDataSetBindingSource
            // 
            this.miniprojectDataSetBindingSource.DataSource = this.miniprojectDataSet;
            this.miniprojectDataSetBindingSource.Position = 0;
            // 
            // miniTableAdapter
            // 
            this.miniTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 605);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(this.txt_phong);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.BindingSource miniprojectDataSetBindingSource;
        private miniprojectDataSet miniprojectDataSet;
        private miniprojectDataSet1 miniprojectDataSet1;
        private System.Windows.Forms.BindingSource miniBindingSource;
        private miniprojectDataSet1TableAdapters.miniTableAdapter miniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
    }
}

