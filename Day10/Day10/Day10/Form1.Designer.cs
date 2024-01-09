namespace Day10
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
            this.components = new System.ComponentModel.Container();
            this.dgInformation = new System.Windows.Forms.GroupBox();
            this.lblEmId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtemID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btbSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sQLexpressDataSet = new Day10.SQLexpressDataSet();
            this.qlyVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlyVienTableAdapter = new Day10.SQLexpressDataSetTableAdapters.qlyVienTableAdapter();
            this.emIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLexpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInformation
            // 
            this.dgInformation.Controls.Add(this.txtDept);
            this.dgInformation.Controls.Add(this.txtName);
            this.dgInformation.Controls.Add(this.txtemID);
            this.dgInformation.Controls.Add(this.lblDept);
            this.dgInformation.Controls.Add(this.lblName);
            this.dgInformation.Controls.Add(this.lblEmId);
            this.dgInformation.Location = new System.Drawing.Point(54, 43);
            this.dgInformation.Name = "dgInformation";
            this.dgInformation.Size = new System.Drawing.Size(341, 157);
            this.dgInformation.TabIndex = 0;
            this.dgInformation.TabStop = false;
            this.dgInformation.Text = "Information";
            // 
            // lblEmId
            // 
            this.lblEmId.AutoSize = true;
            this.lblEmId.Location = new System.Drawing.Point(16, 35);
            this.lblEmId.Name = "lblEmId";
            this.lblEmId.Size = new System.Drawing.Size(41, 16);
            this.lblEmId.TabIndex = 0;
            this.lblEmId.Text = "Em Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(16, 113);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(36, 16);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Dept";
            // 
            // txtemID
            // 
            this.txtemID.Location = new System.Drawing.Point(96, 35);
            this.txtemID.Name = "txtemID";
            this.txtemID.Size = new System.Drawing.Size(195, 22);
            this.txtemID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(96, 113);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(195, 22);
            this.txtDept.TabIndex = 1;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(54, 238);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(33, 16);
            this.lblFind.TabIndex = 1;
            this.lblFind.Text = "Find";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(115, 235);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(230, 22);
            this.txtFind.TabIndex = 2;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // btbSave
            // 
            this.btbSave.Location = new System.Drawing.Point(54, 310);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(75, 23);
            this.btbSave.TabIndex = 3;
            this.btbSave.Text = "Save";
            this.btbSave.UseVisualStyleBackColor = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 310);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qlyVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 159);
            this.dataGridView1.TabIndex = 4;
            // 
            // sQLexpressDataSet
            // 
            this.sQLexpressDataSet.DataSetName = "SQLexpressDataSet";
            this.sQLexpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlyVienBindingSource
            // 
            this.qlyVienBindingSource.DataMember = "qlyVien";
            this.qlyVienBindingSource.DataSource = this.sQLexpressDataSet;
            // 
            // qlyVienTableAdapter
            // 
            this.qlyVienTableAdapter.ClearBeforeFill = true;
            // 
            // emIDDataGridViewTextBoxColumn
            // 
            this.emIDDataGridViewTextBoxColumn.DataPropertyName = "emID";
            this.emIDDataGridViewTextBoxColumn.HeaderText = "emID";
            this.emIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emIDDataGridViewTextBoxColumn.Name = "emIDDataGridViewTextBoxColumn";
            this.emIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.deptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btbSave);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.dgInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dgInformation.ResumeLayout(false);
            this.dgInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLexpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dgInformation;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtemID;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmId;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btbSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SQLexpressDataSet sQLexpressDataSet;
        private System.Windows.Forms.BindingSource qlyVienBindingSource;
        private SQLexpressDataSetTableAdapters.qlyVienTableAdapter qlyVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
    }
}

