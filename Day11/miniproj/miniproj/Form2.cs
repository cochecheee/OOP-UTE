using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        mini mini = new mini();
        miniprjDataContext db = new miniprjDataContext();

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniprojectDataSet2.mini' table. You can move, or remove it, as needed.
            this.miniTableAdapter.Fill(this.miniprojectDataSet2.mini);
            mini mini = new mini();
            miniprjDataContext db = new miniprjDataContext();

            var list = (from s in db.minis select s).ToList();
            dataGridView1.DataSource = list;

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbtn_ba.Checked)
                {
                    var list = (from s in db.minis
                                where s.Phong.Contains("BA")
                                select s).ToList();
                    dataGridView1.DataSource = list;
                }
                else if(rbtn_it.Checked) 
                {
                    var list = (from s in db.minis
                                where s.Phong.Contains("IT")
                                select s).ToList();
                    dataGridView1.DataSource = list;
                }
                else if(rbtn_hr.Checked)
                {
                    var list = (from s in db.minis
                                where s.Phong.Contains("HR")
                                select s).ToList();
                    dataGridView1.DataSource = list;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //tìm kiếm lương có giá trị lớn hơn txt_search
            try
            {
                var list = (from s in db.minis where (Convert.ToInt32(s.Luong) >= Convert.ToInt32(txt_search.Text)) select s).ToList();
                dataGridView1.DataSource = list;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_savefile_Click(object sender, EventArgs e)
        {
            try
            {


                string path = @"D:\file.txt";
                using (TextWriter text = new StreamWriter(path))
                {
                    text.WriteLine("ID\t\t Name\t Department\t");

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                        {
                            text.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                        }
                        text.WriteLine(); // Add a newline after each row
                    }

                    text.WriteLine("==========================================================");
                }
                MessageBox.Show("Save file thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
