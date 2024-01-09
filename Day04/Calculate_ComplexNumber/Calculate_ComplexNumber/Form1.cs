using System.Security.Cryptography.X509Certificates;

namespace Calculate_ComplexNumber
{
    public partial class Form1 : Form
    {
        ComplexNumber x = new ComplexNumber();
        ComplexNumber y = new ComplexNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void realTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setno1Button_Click(object sender, EventArgs e)
        {
            //ComplexNumber x = new ComplexNumber();
            x.Real = Int32.Parse(realTextbox.Text);
            x.Imaginary = Int32.Parse(imaginaryTexbox.Text);

            realTextbox.Clear();
            imaginaryTexbox.Clear();

            statusLable.Text = "First Complex No: " + x.ToString();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = x + " + " + y + " = " + (x + y).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = x + " - " + y + " = " + (x - y).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = x + " * " + y + " = " + (x * y).ToString();
        }

        private void setno2Button_Click(object sender, EventArgs e)
        {
            y.Real = Int32.Parse(realTextbox.Text);
            y.Imaginary = Int32.Parse(imaginaryTexbox.Text);

            realTextbox.Clear();
            imaginaryTexbox.Clear();

            statusLable.Text = "Second Complex No: " + y.ToString();
        }

        private void imaginaryTexbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}