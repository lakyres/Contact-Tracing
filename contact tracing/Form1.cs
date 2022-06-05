using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace contact_tracing
{
    public partial class contraceform : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public contraceform()
        {
            InitializeComponent();
            player.URL = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
