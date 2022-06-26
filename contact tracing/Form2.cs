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
    public partial class successlogin_pg : Form
    {
        public successlogin_pg()
        {
            InitializeComponent();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showrecs allrecs = new showrecs();
            allrecs.ShowDialog();
        }
    }
}
