using System.Linq;

namespace PhoneStore
{

    public partial class Form1 : Form
    {
        List<StorePhone> listphones = new List<StorePhone>();

        int soluong = 0;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox_setYearorPrice.Items.Add("Year");
            comboBox_setYearorPrice.Items.Add("Price");

        }
        #region Event
        private void btn_Input_Click(object sender, EventArgs e)
        {
            //if (textBox_producer.Text == "LG")
            //{
            string tentb = textBox_deviceName.Text;
            int nam = int.Parse(textBox_year.Text);
            string mau = textBox_Color.Text;
            string seri = textBox_seriesNum.Text;
            string producer = textBox_producer.Text;
            float gia = float.Parse(textBox_price.Text);
            string diachi = textBox_diachi.Text;
            int contact = int.Parse(textBox_lienhe.Text);

            // Add a new StorePhone based on the producer
            listphones.Add(new StorePhone(tentb, nam, mau, seri, producer, gia, diachi, contact));

            // Clear the text boxes
            textBox_deviceName.Clear();
            textBox_year.Clear();
            textBox_Color.Clear();
            textBox_seriesNum.Clear();
            textBox_producer.Clear();
            textBox_price.Clear();
            textBox_diachi.Clear();
            textBox_lienhe.Clear();
            //}
            //else if (textBox_producer.Text == "Iphone")
            //{
            //    string tentb = textBox_deviceName.Text;
            //    int nam = int.Parse(textBox_year.Text);
            //    string mau = textBox_Color.Text;
            //    string seri = textBox_seriesNum.Text;
            //    string producer = textBox_producer.Text;
            //    float gia = float.Parse(textBox_price.Text);
            //    string diachi = textBox_diachi.Text;
            //    int contact = int.Parse(textBox_lienhe.Text);
            //    listphones.Add(new StorePhone(tentb, nam, mau, seri, producer, gia, diachi, contact));
            //    textBox_deviceName.Clear();
            //    textBox_seriesNum.Clear();
            //    textBox_Color.Clear();
            //    textBox_seriesNum.Clear();
            //    textBox_producer.Clear();
            //    textBox_price.Clear();
            //    textBox_diachi.Clear();
            //    textBox_lienhe.Clear();
            //}
            //else if (textBox_producer.Text == "Samsung")
            //{
            //    string tentb = textBox_deviceName.Text;
            //    int nam = int.Parse(textBox_year.Text);
            //    string mau = textBox_Color.Text;
            //    string seri = textBox_seriesNum.Text;
            //    string producer = textBox_producer.Text;
            //    float gia = float.Parse(textBox_price.Text);
            //    string diachi = textBox_diachi.Text;
            //    int contact = int.Parse(textBox_lienhe.Text);
            //    listphones.Add(new StorePhone(tentb, nam, mau, seri, producer, gia, diachi, contact));
            //    textBox_deviceName.Clear();
            //    textBox_seriesNum.Clear();
            //    textBox_Color.Clear();
            //    textBox_seriesNum.Clear();
            //    textBox_producer.Clear();
            //    textBox_price.Clear();
            //    textBox_diachi.Clear();
            //    textBox_lienhe.Clear();
            //}


        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            if (i >= soluong)
            {
                btn_display.Enabled = false;
                btn_Input.Enabled = false;
            }

            if (i < soluong)
            {
                string diachi = "Dia chi: " + textBox_diachi.Text;
                lb_View.Items.Add(diachi);
                string contact = "Lien he: " + textBox_lienhe.Text;
                lb_View.Items.Add(contact);
                string tentb = "Ten thiet bi: " + textBox_deviceName.Text;
                lb_View.Items.Add(tentb);
                string nam = "Nam san xuat: " + textBox_year.Text;
                lb_View.Items.Add(nam);
                string mau = "Mau sac: " + textBox_Color.Text;
                lb_View.Items.Add(mau);
                string seri = "So seri: " + textBox_seriesNum.Text;
                lb_View.Items.Add(seri);
                string producer = "Hang san xuat: " + textBox_producer.Text;
                lb_View.Items.Add(producer);
                string gia = "Gia: " + textBox_price.Text;
                lb_View.Items.Add(gia);

                string s = "=======================================================";
                lb_View.Items.Add(s);
                i++;
            }

        }

        //private void comboBox_setYearorPrice_TextChanged(object sender, EventArgs e)
        //{
        //    string text = comboBox_setYearorPrice.Text;
        //    if (text == "Year")
        //    {
        //        sortedByYear(listphones);
        //    }
        //    else if (text == "Price")
        //    {
        //        sortedByPrice(listphones);
        //    }
        //}

        private void btn_Set_Click(object sender, EventArgs e)
        {
            soluong = int.Parse(textBox_soLuong.Text);

        }
        private void btn_encrease_Click(object sender, EventArgs e)
        {
            if (comboBox_setYearorPrice.Text == null) MessageBox.Show("Nhap sai roi ban oi!");
            else
            {
                if (comboBox_setYearorPrice.Text == "Year")
                {
                    sortedByYearAscending(listphones);
                }
                else if (comboBox_setYearorPrice.Text == "Price")
                {
                    sortedByPriceAscending(listphones);
                }
            }
        }
        private void btn_decrease_Click(object sender, EventArgs e)
        {
            if (comboBox_setYearorPrice.Text == null) MessageBox.Show("Nhap sai roi ban oi!");
            else
            {
                if (comboBox_setYearorPrice.Text == "Year")
                {
                    sortedByYearDescending(listphones);
                }
                else if (comboBox_setYearorPrice.Text == "Price")
                {
                    sortedByPriceDescending(listphones);
                }
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            string tenmay = textBox_search.Text;
            List<StorePhone> filter = SearchPhones(tenmay);
            ShowList(filter);

        }
        private void button_searchhang_Click(object sender, EventArgs e)
        {
            string tenhang = textBox_search.Text;
            List<StorePhone> filter = SearchHang(tenhang);
            ShowList(filter);
        }
        private void button_searchgia_Click(object sender, EventArgs e)
        {
            float gia = float.Parse(textBox_search.Text);
            List<StorePhone> filter = SearchPrice(gia);
            ShowList(filter);
        }
        #endregion

        #region Method
        private List<StorePhone> SearchPhones(string tenmay)
        {
            List<StorePhone> searchResults = listphones.Where(phone => phone.Tenthietbi.Contains(tenmay)).ToList();
            return searchResults;
        }
        private List<StorePhone> SearchHang(string tenhang)
        {
            List<StorePhone> searchResults = listphones.Where(phone => phone.Producer.Contains(tenhang)).ToList();
            return searchResults;
        }
        private List<StorePhone> SearchPrice(float gia)
        {
            List<StorePhone> searchResults = listphones.Where(phone => phone.Price == gia).ToList();
            return searchResults;
        }
        //public void sortedByYear(List<StorePhone> listphones)
        //{
        //    listphones.Sort((phone1, phone2) => phone1.Year.CompareTo(phone2.Year));
        //    //for (int i = 0; i < listphones.Count; i++)
        //    //{
        //    //    Show(listphones[i]);
        //    //}
        //}
        //public void sortedByPrice(List<StorePhone> listphones)
        //{
        //    listphones.Sort((phone1, phone2) => phone1.Price.CompareTo(phone2.Price));
        //    //for (int i = 0; i < listphones.Count; i++)
        //    //{
        //    //    Show(listphones[i]);
        //    //}
        //}

        public void sortedByYearAscending(List<StorePhone> listphones)
        {
            listphones.Sort((phone1, phone2) => phone1.Year.CompareTo(phone2.Year));
            lb_View.Items.Clear();
            ShowList(listphones);
        }

        public void sortedByYearDescending(List<StorePhone> listphones)
        {
            listphones.Sort((phone1, phone2) => phone2.Year.CompareTo(phone1.Year));
            lb_View.Items.Clear();
            ShowList(listphones);
        }

        public void sortedByPriceAscending(List<StorePhone> listphones)
        {
            listphones.Sort((phone1, phone2) => phone1.Price.CompareTo(phone2.Price));
            lb_View.Items.Clear();
            ShowList(listphones);
        }

        public void sortedByPriceDescending(List<StorePhone> listphones)
        {
            listphones.Sort((phone1, phone2) => phone2.Price.CompareTo(phone1.Price));
            lb_View.Items.Clear();
            ShowList(listphones);
        }

        void ShowList(List<StorePhone> phones)
        {
            lb_View.Items.Clear(); // Clear the ListBox before displaying the sorted list

            foreach (StorePhone phone in phones)
            {
                Show(phone);
            }
        }

        void Show(StorePhone sp)
        {
            string diachi = "Dia chi: " + sp.Address;
            lb_View.Items.Add(diachi);
            string contact = "Lien he: " + sp.ContactNumber;
            lb_View.Items.Add(contact);
            string tentb = "Ten thiet bi: " + sp.Tenthietbi;
            lb_View.Items.Add(tentb);
            string nam = "Nam san xuat: " + sp.Year;
            lb_View.Items.Add(nam);
            string mau = "Mau sac: " + sp.Mausac;
            lb_View.Items.Add(mau);
            string seri = "So seri: " + sp.Seriesnum;
            lb_View.Items.Add(seri);
            string producer = "Hang san xuat: " + sp.Producer;
            lb_View.Items.Add(producer);
            string gia = "Gia: " + sp.Price;
            lb_View.Items.Add(gia);

            string s = "=======================================================";
            lb_View.Items.Add(s);
        }
        #endregion



    }
}
