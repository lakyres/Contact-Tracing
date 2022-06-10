using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_tracing
{
    public partial class personal_info: UserControl
    {
        public personal_info()
        {
            InitializeComponent();
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void middlename_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }

        private void txt_middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\personal info.txt", true);
            file.WriteLine("First Name: " + txt_firstname.Text );
            file.WriteLine("Middle Name: " + txt_middlename.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);
            file.WriteLine("Last Name: " + txt_birthdate.Text);
            file.WriteLine("Last Name: " + txt_age.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);

            file.Close();

        }
    }
}
