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
            var txtfiles = Directory.EnumerateFiles(@"C:\Users\angel\source\repos\Contact-Tracing (LEGIT)\records");
            foreach (string file in txtfiles)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(Date))
                {
                    var date = content.Substring(content.IndexOf("=") + 1);
                    resultdate++;
                    dates.Add(content);
                    continue;
                }
            }
            if (resultdate == 0)
            {
                MessageBox.Show("No people came on this date.");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\Contact-Tracing (LEGIT)\records\dates\specific date.txt");
                foreach (string content in dates)
                {
                    _ = dates.LastOrDefault();
                    file.WriteLine(content);
                }
                file.Close();
                MessageBox.Show("Found record(s) on the selected date");
                MessageBox.Show("All the records are in one text file. Scroll through the list and find it by looking at the date.");
                selecteddatelist date = new selecteddatelist();
                date.ShowDialog();
            }

        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
