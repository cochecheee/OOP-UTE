
using Matrix_Calculate;

namespace Bai_Kiem_Tra_Giua_Ki_Matrix
{
    public partial class Form1 : Form
    {
        matran m1 = new matran(2, 2);
        matran m2 = new matran(2, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void setMatrix1Button_Click(object sender, EventArgs e)
        {
            m1.Mt[0,0] = int.Parse(rc11TextBox.Text);
            m1.Mt[0, 1] = int.Parse(rc12TextBox.Text);
            m1.Mt[1, 0] = int.Parse(rc21TextBox.Text);
            m1.Mt[1, 1] = int.Parse(rc22TextBox.Text);

            rc11TextBox.Clear();
            rc12TextBox.Clear();
            rc21TextBox.Clear();
            rc22TextBox.Clear();
        }

        private void setMatrix2Button_Click(object sender, EventArgs e)
        {
            m2.Mt[0, 0] = int.Parse(rc11TextBox.Text);
            m2.Mt[0, 1] = int.Parse(rc12TextBox.Text);
            m2.Mt[1, 0] = int.Parse(rc21TextBox.Text);
            m2.Mt[1, 1] = int.Parse(rc22TextBox.Text);

            rc11TextBox.Clear();
            rc12TextBox.Clear();
            rc21TextBox.Clear();
            rc22TextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            matran c = new matran(2, 2);
            c = matran.Add(m1, m2);
            resultLable.Text = c.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            matran c = new matran(2, 2);
            c = matran.Subtract(m1, m2);
            resultLable.Text = c.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            matran c = new matran(2, 2);
            c = matran.Multiply(m1, m2);
            resultLable.Text = c.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}