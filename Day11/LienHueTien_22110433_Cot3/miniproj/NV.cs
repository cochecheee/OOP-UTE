using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miniproj
{
    public partial class NV : Form
    {
        public NV()
        {
            InitializeComponent();
        }

        mini mini = new mini();  //một row trong table mini
        miniprjDataContext db = new miniprjDataContext(); //database

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'miniprojectDataSet.mini' table. You can move, or remove it, as needed.
            
            mini mini = new mini();
            miniprjDataContext db = new miniprjDataContext();

            var list = (from s in db.minis select s).ToList();
            dataGridView1.DataSource = list;

            //txt_id.DataBindings.Clear();
            //txt_luong.DataBindings.Clear();
            //txt_phong.DataBindings.Clear();
            //txt_ten.DataBindings.Clear();
            //txt_tuoi.DataBindings.Clear();

            //txt_id.DataBindings.Add("text", list, "ID");
            //txt_luong.DataBindings.Add("text", list, "Luong");
            //txt_phong.DataBindings.Add("text", list, "Phong");
            //txt_ten.DataBindings.Add("text", list, "Ten");
            //txt_tuoi.DataBindings.Add("text", list, "Tuoi");

            // TODO: This line of code loads data into the 'miniprojectDataSet1.mini' table. You can move, or remove it, as needed.
            this.miniTableAdapter.Fill(this.miniprojectDataSet1.mini);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                mini mini = new mini();  //một row trong table mini
                mini.ID = txt_id.Text;
                mini.Ten = txt_ten.Text;
                mini.Phong = txt_phong.Text;
                mini.Tuoi = txt_tuoi.Text;
                mini.Luong = txt_luong.Text;

                db.minis.InsertOnSubmit(mini);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void miniBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            try
            {
                mini = db.minis.Where(s => s.ID == txt_id.Text).Single();
                mini.Ten = txt_ten.Text;
                mini.Tuoi = txt_tuoi.Text;
                mini.Phong = txt_phong.Text;
                mini.Luong = txt_luong.Text;

                db.SubmitChanges();
                Form1_Load(sender, e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                mini = db.minis.Where(s => s.ID == txt_id.Text).Single();
                db.minis.DeleteOnSubmit(mini);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot edit an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.minis
                        where s.ID.Contains(txt_timkiem.Text)
                        select s).ToList();
            dataGridView1.DataSource = list;
            txt_id.DataBindings.Clear();
            txt_luong.DataBindings.Clear();
            txt_phong.DataBindings.Clear();
            txt_ten.DataBindings.Clear();
            txt_tuoi.DataBindings.Clear();
            txt_id.DataBindings.Add("text", list, "ID");
            txt_ten.DataBindings.Add("text", list, "Ten");
            txt_phong.DataBindings.Add("text", list, "Phong");
            txt_luong.DataBindings.Add("text", list, "Luong");
            txt_tuoi.DataBindings.Add("text", list, "Tuoi");
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            NVnext fr2 = new NVnext();
            fr2.ShowDialog();
        }
    }
}
