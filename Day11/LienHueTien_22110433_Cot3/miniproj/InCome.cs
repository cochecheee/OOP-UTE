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
    public partial class InCome : Form
    {
        public InCome()
        {
            InitializeComponent();
        }

        bookstoreDataContext bs = new bookstoreDataContext();
        phonestoreDataContext ps = new phonestoreDataContext();

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniprojectDataSet7.bookstore' table. You can move, or remove it, as needed.
            this.bookstoreTableAdapter.Fill(this.miniprojectDataSet7.bookstore);
            // TODO: This line of code loads data into the 'miniprojectDataSet6.phonestore' table. You can move, or remove it, as needed.
            this.phonestoreTableAdapter.Fill(this.miniprojectDataSet6.phonestore);

        }

        private void txt_thang_TextChanged(object sender, EventArgs e)
        {
            
            //phone store datagv2
            var list = (from s in ps.phonestores where s.Thangban.Contains(txt_thang.Text) select s).ToList();
            dataGridView2.DataSource = list;

            var list1 = (from s in bs.bookstores where s.Thangban.Contains(txt_thang.Text) select s).ToList();
            dataGridView1.DataSource = list1;

        }

        private void brn_xuatfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị SaveFileDialog để chọn vị trí và tên tệp tin
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    Title = "Income"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mở tệp tin để ghi
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        var list = (from s in bs.bookstores select s).ToList();
                        int sum = 0;
                        int sum1 = 0;

                        if (list != null)
                        {
                            // Ghi tiêu đề cột từ DataGridView
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                writer.Write(column.HeaderText + "\t\t\t");
                            }
                            writer.WriteLine();

                            // Ghi dữ liệu từ DataGridView
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    writer.Write(cell.Value + "\t\t\t");
                                }
                                writer.WriteLine();
                            }

                            sum = bs.bookstores.Where(s => s.Gia != null).Sum(s => Convert.ToInt32(s.Gia));

                            writer.WriteLine("Tổng thu nhập của book store là: " + sum.ToString());
                            writer.WriteLine("=================================================================");
                        }

                        var list1 = (from s in ps.phonestores select s).ToList();

                        if (list1 != null)
                        {
                            foreach (DataGridViewColumn column in dataGridView2.Columns)
                            {
                                writer.Write(column.HeaderText + "\t\t\t");
                            }
                            writer.WriteLine();

                            // Ghi dữ liệu từ DataGridView
                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    writer.Write(cell.Value + "\t\t\t");
                                }
                                writer.WriteLine();
                            }

                            if (ps?.phonestores != null)
                            {
                                sum1 = ps.phonestores.Sum(s => Convert.ToInt32(s.Gia));
                            }

                            writer.WriteLine("Tổng thu nhập của phone store là: " + sum1.ToString());
                            writer.WriteLine("=================================================================");
                        }

                        int tong = sum1 + sum;
                        writer.WriteLine("Tổng thu nhập là: " + tong.ToString());
                        writer.WriteLine("=================================================================");
                    }

                    MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
