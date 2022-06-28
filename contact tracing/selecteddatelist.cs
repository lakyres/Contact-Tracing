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
    public partial class selecteddatelist : Form
    {
        public selecteddatelist()
        {
            InitializeComponent();
            var datefiles = Directory.GetFiles(@"C:\Users\angel\source\repos\Contact-Tracing (LEGIT)\records\dates");
            foreach (string file in datefiles)
            {
                string dates = File.ReadAllText(file);
                lbl_selectedrecord.Text = lbl_selectedrecord.Text + dates + "\n";
            }


        }

        private void selecteddatelist_Load(object sender, EventArgs e)
        {

        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
