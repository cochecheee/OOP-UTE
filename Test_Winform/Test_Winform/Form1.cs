namespace Test_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showResult(Label lb, Panel pnl)
        {
            RadioButton rdb = null; 

            foreach(RadioButton item in pnl.Controls)
            {
                if(item.Checked) { }
                if(item.Checked)
                {
                    rdb = item;
                    break;
                }
            }

            if(rdb != null)
            {
                lb.Text = rdb.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult(label1, panel1);
            showResult(label2, panel2);
            showResult(label3, panel3);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb.Checked != null)  
                label1.Text = rb.Text;

        }
    }
}