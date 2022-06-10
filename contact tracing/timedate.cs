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
    public partial class timedate: UserControl
    {
        public timedate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\personal info.txt", true);
            file.WriteLine("");
            file.WriteLine("Date: " + txt_date.Text);
            file.WriteLine("Check In: " + txt_checkin.Text);
            file.WriteLine("Check Out: " + txt_checkout.Text);

            file.Close();
        }
    }
}
