using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_winforms
{
    public partial class Form1 : Form
    {
        Employee nhanvien = new Employee();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameButton_Click(object sender, EventArgs e)
        {
            nhanvien.FirstName = firstNameTextbox.Text;
            //nhanvien.LastName = lastNameTextbox.Text;

            //firstNameTextbox.Clear();
            //lastNameTextbox.Clear();
        }

        private void lastNameButton_Click(object sender, EventArgs e)
        {
            nhanvien.LastName = lastNameTextbox.Text;
            //lastNameTextbox.Clear();
        }

        private void resultTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void setHiredButton_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(monthTextbox.Text);
            int day = Int32.Parse(dayTextbox.Text);
            int year = Int32.Parse(yearTextbox.Text);

            nhanvien.BirthDate = new Date(month, day, year);

            monthTextbox.Clear();
            dayTextbox.Clear();
            yearTextbox.Clear();
        }

        private void setBirthButton_Click(object sender, EventArgs e)
        {
            
            int month = Int32.Parse(monthTextbox.Text);
            int day = Int32.Parse(dayTextbox.Text);
            int year = Int32.Parse(yearTextbox.Text);

            nhanvien.HireDate = new Date(month, day, year);

            monthTextbox.Clear();
            dayTextbox.Clear();
            yearTextbox.Clear();
            
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            resultTextbox.Text = nhanvien.ToEmployeeString();
        }
    }
}
