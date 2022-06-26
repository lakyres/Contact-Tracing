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
    public partial class symptoms: UserControl
    {
        public symptoms()
        {
            InitializeComponent();
        }

        private void symptoms_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Cough: Yes");

            file.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Fatigue: Yes");

            file.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Sore throat: Yes");

            file.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Fever: Yes" );

            file.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Lose of taste/smell: Yes");

            file.Close();
        }

        private void nosymp_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("No symptoms: Yes");

            file.Close();
        }

        private void runnynose_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Runny nose: Yes");

            file.Close();
        }

        private void shortness_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing\records\all.txt", true);
            file.WriteLine("");
            file.WriteLine("Shortness of breath: Yes");

            file.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
