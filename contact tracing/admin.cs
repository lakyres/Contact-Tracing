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
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            transparent_panel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text=="kylers" && password_txtbox.Text=="kyla1011")
            {
                new successlogin_pg().Show();
                this.Hide();

            }
            
            else
            {
                MessageBox.Show("Unsuccessful login attempt. Wrong username or password.");
                username_txtbox.Clear();
                password_txtbox.Clear();
                username.Focus();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
