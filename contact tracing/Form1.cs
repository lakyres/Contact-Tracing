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
            
            about1.Hide();
            
            adminonly1.Hide();
            personall1.Show();
            personall1.BringToFront();
        }

        private void personal_info2_Load(object sender, EventArgs e)
        {

        }

      

       

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            personall1.Hide();
           
            adminonly1.Hide();
            about1.Show();
            about1.BringToFront();
        }

        private void admin_btn5_Click(object sender, EventArgs e)
        {
            
            personall1.Hide();
            
            about1.Hide();
            adminonly1.Show();
            adminonly1.BringToFront();
        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }
    }
}
