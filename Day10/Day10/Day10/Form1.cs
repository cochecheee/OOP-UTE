using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        qlyVien nv = new qlyVien();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLexpressDataSet.qlyVien' table. You can move, or remove it, as needed.
            //this.qlyVienTableAdapter.Fill(this.sQLexpressDataSet.qlyVien);
            DataClasses1DataContext db = new DataClasses1DataContext();

            var list = (from s in db.qlyViens select s).ToList();
            dataGridView1.DataSource = list;
            txtemID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtDept.DataBindings.Clear();

            txtemID.DataBindings.Add("text", list, "emID");
            txtName.DataBindings.Add("text", list, "Name");
            txtDept.DataBindings.Add("text", list, "Dept");

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            nv.emID = txtemID.Text;
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;

            db.qlyViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            nv = db.qlyViens.Where(s => s.emID == txtemID.Text).Single();
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;

            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            nv = db.qlyViens.Where(s => s.emID == txtemID.Text).Single();
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;

            db.qlyViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var list = (from s in db.qlyViens where s.emID.Contains(txtFind.Text) select s).ToList();
            dataGridView1.DataSource = list;
            txtemID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtDept.DataBindings.Clear();

            txtemID.DataBindings.Add("text", list, "emID");
            txtName.DataBindings.Add("text", list, "Name");
            txtDept.DataBindings.Add("text", list, "Dept");
        }
    }
}
