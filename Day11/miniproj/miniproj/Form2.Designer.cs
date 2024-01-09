namespace miniproj
{
    partial class Form2
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
            this.rbtn_hr = new System.Windows.Forms.RadioButton();
            this.rbtn_ba = new System.Windows.Forms.RadioButton();
            this.rbtn_it = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_savefile = new System.Windows.Forms.Button();
            this.miniprojectDataSet2 = new miniproj.miniprojectDataSet2();
            this.miniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniTableAdapter = new miniproj.miniprojectDataSet2TableAdapters.miniTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_hr
            // 
            this.rbtn_hr.AutoSize = true;
            this.rbtn_hr.Location = new System.Drawing.Point(55, 71);
            this.rbtn_hr.Name = "rbtn_hr";
            this.rbtn_hr.Size = new System.Drawing.Size(48, 20);
            this.rbtn_hr.TabIndex = 0;
            this.rbtn_hr.TabStop = true;
            this.rbtn_hr.Text = "HR";
            this.rbtn_hr.UseVisualStyleBackColor = true;
            // 
            // rbtn_ba
            // 
            this.rbtn_ba.AutoSize = true;
            this.rbtn_ba.Location = new System.Drawing.Point(55, 121);
            this.rbtn_ba.Name = "rbtn_ba";
            this.rbtn_ba.Size = new System.Drawing.Size(46, 20);
            this.rbtn_ba.TabIndex = 0;
            this.rbtn_ba.TabStop = true;
            this.rbtn_ba.Text = "BA";
            this.rbtn_ba.UseVisualStyleBackColor = true;
            // 
            // rbtn_it
            // 
            this.rbtn_it.AutoSize = true;
            this.rbtn_it.Location = new System.Drawing.Point(55, 171);
            this.rbtn_it.Name = "rbtn_it";
            this.rbtn_it.Size = new System.Drawing.Size(40, 20);
            this.rbtn_it.TabIndex = 0;
            this.rbtn_it.TabStop = true;
            this.rbtn_it.Text = "IT";
            this.rbtn_it.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(221, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(412, 287);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(529, 287);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(205, 22);
            this.txt_search.TabIndex = 3;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(221, 352);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_savefile
            // 
            this.btn_savefile.Location = new System.Drawing.Point(348, 352);
            this.btn_savefile.Name = "btn_savefile";
            this.btn_savefile.Size = new System.Drawing.Size(75, 23);
            this.btn_savefile.TabIndex = 2;
            this.btn_savefile.Text = "Save file";
            this.btn_savefile.UseVisualStyleBackColor = true;
            this.btn_savefile.Click += new System.EventHandler(this.btn_savefile_Click);
            // 
            // miniprojectDataSet2
            // 
            this.miniprojectDataSet2.DataSetName = "miniprojectDataSet2";
            this.miniprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miniBindingSource
            // 
            this.miniBindingSource.DataMember = "mini";
            this.miniBindingSource.DataSource = this.miniprojectDataSet2;
            // 
            // miniTableAdapter
            // 
            this.miniTableAdapter.ClearBeforeFill = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_savefile);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtn_it);
            this.Controls.Add(this.rbtn_ba);
            this.Controls.Add(this.rbtn_hr);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_hr;
        private System.Windows.Forms.RadioButton rbtn_ba;
        private System.Windows.Forms.RadioButton rbtn_it;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_savefile;
        private miniprojectDataSet2 miniprojectDataSet2;
        private System.Windows.Forms.BindingSource miniBindingSource;
        private miniprojectDataSet2TableAdapters.miniTableAdapter miniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
    }
}