using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class contraceform : Form
    {
        
        public contraceform()
        {
            InitializeComponent();
        }
        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menu_btn1_Click(object sender, EventArgs e)
        {
            timedate1.Hide();
            about1.Hide();
            symptoms1.Hide();
            personal_info1.Show();
            personal_info1.BringToFront();
        }

        private void personal_info2_Load(object sender, EventArgs e)
        {

        }

        private void menu_btn2_Click(object sender, EventArgs e)
        {
            personal_info1.Hide();
            timedate1.Hide();
            about1.Hide();
            symptoms1.Show();
            symptoms1.BringToFront();

        }

        private void menu_btn3_Click(object sender, EventArgs e)
        {
            personal_info1.Hide();
            symptoms1.Hide();
            about1.Hide();
            timedate1.Show();
            timedate1.BringToFront();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            symptoms1.Hide();
            personal_info1.Hide();
            symptoms1.Hide();
            about1.Show();
            about1.BringToFront();
        }

        private void admin_btn5_Click(object sender, EventArgs e)
        {

        }
    }
}
