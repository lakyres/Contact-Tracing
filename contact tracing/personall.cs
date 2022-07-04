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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace contact_tracing
{
    public partial class personall : UserControl
    {
        public personall()
        {
            InitializeComponent();
        }


        
        

        private void personall_Load(object sender, EventArgs e)
        {
            
        }

      
        private void button1_Click_3(object sender, EventArgs e)
        {
            contacttracing show = new contacttracing();
            show.ShowDialog();
        }
    }
}
