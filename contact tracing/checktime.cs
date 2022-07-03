using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class checktime : UserControl
    {
        public checktime()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_checkin_Enter(object sender, EventArgs e)
        {
            if (txt_checkin.Text == "00:00 AM/PM")
            {
                txt_checkin.Text = "";
                txt_checkin.ForeColor = Color.Black;
            }
        }

        private void txt_checkin_Leave(object sender, EventArgs e)
        {
            if (txt_checkin.Text == "")
            {
                txt_checkin.Text = "00:00 AM/PM";
                txt_checkin.ForeColor = Color.Silver;
            }
        }

        private void txt_checkout_Enter(object sender, EventArgs e)
        {
            if (txt_checkout.Text == "00:00 AM/PM")
            {
                txt_checkout.Text = "";
                txt_checkout.ForeColor = Color.Black;
            }
        }

        private void txt_checkout_Leave(object sender, EventArgs e)
        {
            if (txt_checkout.Text == "")
            {
                txt_checkout.Text = "00:00 AM/PM";
                txt_checkout.ForeColor = Color.Silver;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing legit totoo\records\" + date.Text + ".txt", true);
            file.WriteLine("");
            file.WriteLine("Date: " + date.Text);
            file.WriteLine("Time Check In: " + txt_checkin.Text);
            file.WriteLine("Time Check Out: " + txt_checkout.Text);

            file.Close();

            MessageBox.Show("Stay Safe. Ingat!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_checkin.Text = "00:00 AM/PM";
            txt_checkin.ForeColor = Color.Silver;
            txt_checkout.Text = "00:00 AM/PM";
            txt_checkout.ForeColor = Color.Silver;
        }
    }
}
