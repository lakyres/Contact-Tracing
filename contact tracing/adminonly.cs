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
    public partial class adminonly : UserControl
    {
        public adminonly()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            transparent_panel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "kylers" && txt_password.Text == "kyla1011")
            {
                new loggedin().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Unsuccessful login attempt. Wrong username or password.");
                txt_username.Clear();
                txt_password.Clear();
                lbl_username.Focus();


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(show_pass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }

            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
               
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
