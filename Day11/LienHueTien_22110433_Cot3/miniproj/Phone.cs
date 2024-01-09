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
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }
        deviceDataContext db = new deviceDataContext();
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miniprojectDataSet4.devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.miniprojectDataSet4.devices);

            var list = (from s in db.devices select s).ToList();
            dataGridView1.DataSource = list;

        }
        private void btn_ban_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_ban.Text))
            {
                MessageBox.Show("Không có điện thoại này trong hãng.");
                return;
            }
            
            try
            {
                var list = db.devices.Where(s => s.Soseri == txt_ban.Text).FirstOrDefault();

                if (list != null)
                {
                    phonestore phone = new phonestore();
                    phone.Tenthietbi = list.Tenthietbi;
                    phone.Namsanxuat = list.Namsanxuat;
                    phone.Mausac = list.Mausach;
                    phone.Soseri = list.Soseri;
                    phone.Gia = list.Gia;
                    phone.Thangban = DateTime.Now.Month.ToString();

                    phonestoreDataContext ps = new phonestoreDataContext();
                    ps.phonestores.InsertOnSubmit(phone);
                    db.devices.DeleteOnSubmit(list);

                    ps.SubmitChanges();
                    db.SubmitChanges();

                    Form5_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có điện thoại này trong hãng.");
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_ban_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
