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
    public partial class loggedin : Form
    {
        public loggedin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showrecs allrecs = new showrecs();
            allrecs.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            string Date = selectdate.Text;
            int resultdate = 0;
            var txtfiles = Directory.EnumerateFiles(@"C:\Users\angel\source\repos\contact tracing legit totoo\records");
            foreach (string file in txtfiles)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(Date))
                {
                    dates.Add(content);
                    resultdate++;
                    continue;
                }
            }
            if (resultdate == 0)
            {
                MessageBox.Show("No people came on this date.");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing legit totoo\records\dates\specific date.txt");
                foreach (string content in dates)
                {
                   
                    file.WriteLine(content);
                }
                file.Close();
                MessageBox.Show("The system found " + resultdate  + " record(s) on the date selected");
                MessageBox.Show("All record(s) for this date will be shown");
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    selecteddatelist date = new selecteddatelist();
                    date.ShowDialog();
                }
            }

        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
