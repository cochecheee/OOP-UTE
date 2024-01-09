using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproj
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        bookDataContext db = new bookDataContext();
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniprojectDataSet5.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.miniprojectDataSet5.book);

            var list = (from s in db.books select s).ToList();
            dataGridView1.DataSource = list;
        }

        
       

        private void btn_ban_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ban.Text))
            {
                MessageBox.Show("Không có điện thoại này trong hãng.");
                return;
            }

            try
            {
                var list = db.books.Where(s => s.isbn == txt_ban.Text).FirstOrDefault();

                if (list != null)
                {
                    bookstore book = new bookstore();
                    book.Tensach = list.Tensach;
                    book.Tacgia = list.Tacgia;
                    book.isbn = list.isbn;
                    book.Nhaxuatban = list.Nhaxuatban;
                    book.Gia = list.Gia;
                    book.Thangban = DateTime.Now.Month.ToString();

                    bookstoreDataContext bs = new bookstoreDataContext();
                    bs.bookstores.InsertOnSubmit(book);
                    db.books.DeleteOnSubmit(list);

                    bs.SubmitChanges();
                    db.SubmitChanges();

                    Form6_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có điện thoại này trong hãng.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
