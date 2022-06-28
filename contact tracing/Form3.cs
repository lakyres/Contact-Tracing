using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_tracing
{
    public partial class showrecs : Form
    {
        public showrecs()
        {
            InitializeComponent();
            var allrecords = Directory.GetFiles(@"C:\Users\angel\source\repos\contact tracing legit totoo\records");
            foreach (var record in allrecords)
            {
                string records = File.ReadAllText(record);
                contracerecords.Text = contracerecords.Text + "\n" + records + "\n";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
