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
    public partial class Thang : Form
    {
        public Thang()
        {
            InitializeComponent();
        }

        bookstoreDataContext bs = new bookstoreDataContext();
        phonestoreDataContext ps = new phonestoreDataContext();
        miniprjDataContext nv = new miniprjDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var obj1 = (from s in bs.bookstores where s.Thangban.Contains(textBox1.Text) select s).ToList();
            var obj2 = (from s in ps.phonestores where s.Thangban.Contains(textBox1.Text) select s).ToList();

            int luong = nv.minis.Where(s => s.Luong != null).Sum(s => Convert.ToInt32(s.Luong)) * 23000;
            int sumObj1 = obj1.Sum(s => Convert.ToInt32(s.Gia));
            int sumObj2 = obj2.Sum(s => Convert.ToInt32(s.Gia));



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
                    int sum = bs.bookstores.Where(s => s.Gia != null).Sum(s => Convert.ToInt32(s.Gia));
                    int sum1 = ps.phonestores.Sum(s => Convert.ToInt32(s.Gia));


                    int tong = sum1 + sum - luong;

                    writer.WriteLine("Thu nhập từ phone store la: " + sum1.ToString());
                    writer.WriteLine("Thu nhập từ book store la: " + sum1.ToString());
                    writer.WriteLine("Lương trả cho nhân viên la: " + luong.ToString());

                    writer.WriteLine("Tổng thu nhập là: " + tong.ToString());
                    writer.WriteLine("=================================================================");
                }
            }
        }
    }
}
