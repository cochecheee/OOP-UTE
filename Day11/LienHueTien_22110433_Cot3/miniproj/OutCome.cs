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
    public partial class OutCome : Form
    {
        public OutCome()
        {
            InitializeComponent();
        }

        miniprjDataContext db = new miniprjDataContext();

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniprojectDataSet8.mini' table. You can move, or remove it, as needed.
            this.miniTableAdapter.Fill(this.miniprojectDataSet8.mini);

        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
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
                        var list = (from s in db.minis select s).ToList();
                        int sum = 0;

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

                            sum = db.minis.Where(s => s.Luong != null).Sum(s => Convert.ToInt32(s.Luong));

                            writer.WriteLine("Tổng lương trả là: " + (sum * 23000).ToString());
                            writer.WriteLine("=================================================================");
                        }



                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
