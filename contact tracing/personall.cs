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


        private void txt_firstname_Enter(object sender, EventArgs e)
        {
            if (txt_firstname.Text == "First Name")
            {
                txt_firstname.Text = "";
                txt_firstname.ForeColor = Color.Black;
            }
        }

        private void txt_firstname_Leave(object sender, EventArgs e)
        {
            if (txt_firstname.Text == "")
            {
                txt_firstname.Text = "First Name";
                txt_firstname.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_middlename_Enter(object sender, EventArgs e)
        {
            if (txt_middlename.Text == "Put NA if none")
            {
                txt_middlename.Text = "";
                txt_middlename.ForeColor = Color.Black;
            }
        }

        private void txt_middlename_Leave(object sender, EventArgs e)
        {
            if (txt_middlename.Text == "")
            {
                txt_middlename.Text = "Put NA if none";
                txt_middlename.ForeColor = Color.Silver;
            }
        }

        private void txt_lastname_Enter(object sender, EventArgs e)
        {
            if (txt_lastname.Text == "Last Name")
            {
                txt_lastname.Text = "";
                txt_lastname.ForeColor = Color.Black;
            }
        }

        private void txt_lastname_Leave(object sender, EventArgs e)
        {
            if (txt_lastname.Text == "")
            {
                txt_lastname.Text = "Last Name";
                txt_lastname.ForeColor = Color.Silver;
            }
        }

        private void txt_birthdate_Enter(object sender, EventArgs e)
        {
            if (txt_birthdate.Text == "mm/dd/yyyy")
            {
                txt_birthdate.Text = "";
                txt_birthdate.ForeColor = Color.Black;
            }
        }

        private void txt_birthdate_Leave(object sender, EventArgs e)
        {
            if (txt_birthdate.Text == "")
            {
                txt_birthdate.Text = "mm/dd/yyyy";
                txt_birthdate.ForeColor = Color.Silver;
            }
        }

        private void txt_age_Enter(object sender, EventArgs e)
        {
            if (txt_age.Text == "Age")
            {
                txt_age.Text = "";
                txt_age.ForeColor = Color.Black;
            }
        }

        private void txt_age_Leave(object sender, EventArgs e)
        {
            if (txt_age.Text == "")
            {
                txt_age.Text = "Age";
                txt_age.ForeColor = Color.Silver;
            }
        }

        private void txt_sex_Enter(object sender, EventArgs e)
        {
            if (txt_sex.Text == "Sex")
            {
                txt_sex.Text = "";
                txt_sex.ForeColor = Color.Black;
            }
        }

        private void txt_sex_Leave(object sender, EventArgs e)
        {
            if (txt_sex.Text == "")
            {
                txt_sex.Text = "Sex";
                txt_sex.ForeColor = Color.Silver;
            }
        }

        private void txt_address_Enter(object sender, EventArgs e)
        {
            if (txt_address.Text == "House no./Street/Barangay/Town/City/Province/Country/Zip Code")
            {
                txt_address.Text = "";
                txt_address.ForeColor = Color.Black;
            }
        }

        private void txt_address_Leave(object sender, EventArgs e)
        {
            if (txt_address.Text == "")
            {
                txt_address.Text = "House no./Street/Barangay/Town/City/Province/Country/Zip Code";
                txt_address.ForeColor = Color.Silver;
            }
        }

        private void txt_contactnum_Enter(object sender, EventArgs e)
        {
            if (txt_contactnum.Text == "Contact Number")
            {
                txt_contactnum.Text = "";
                txt_contactnum.ForeColor = Color.Black;
            }
        }

        private void txt_contactnum_Leave(object sender, EventArgs e)
        {
            if (txt_contactnum.Text == "")
            {
                txt_contactnum.Text = "Contact Number";
                txt_contactnum.ForeColor = Color.Silver;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "you@email.com")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "you@email.com";
                txt_email.ForeColor = Color.Silver;
            }
        }
        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_contactnum_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing legit totoo\records\" + txt_firstname.Text + ", " + txt_middlename.Text + ", " + txt_lastname.Text + ".txt", true);
            file.WriteLine("");
            file.WriteLine("Personal Information");
            file.WriteLine("First Name: " + txt_firstname.Text);
            file.WriteLine("Middle Name: " + txt_middlename.Text);
            file.WriteLine("Last Name: " + txt_lastname.Text);
            file.WriteLine("Date of Birth: " + txt_birthdate.Text);
            file.WriteLine("Age: " + txt_age.Text);
            file.WriteLine("Sex: " + txt_sex.Text);
            file.WriteLine("Address: " + txt_address.Text);
            file.WriteLine("Contact: " + txt_contactnum.Text);
            file.WriteLine("Email: " + txt_email.Text);
            

            file.WriteLine("");
            file.WriteLine("Date: " + date.Text);
            file.WriteLine("Time Check In: " + txt_checkin.Text);
            file.WriteLine("Time Check Out: " + txt_checkout.Text);

            file.Close();

            MessageBox.Show("Thank you. Be careful and take care!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Stay Safe. Ingat!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_firstname.Text = "First Name";
            txt_firstname.ForeColor = Color.Silver;
            txt_middlename.Text = "Put NA if none";
            txt_middlename.ForeColor = Color.Silver;
            txt_lastname.Text = "Last Name";
            txt_lastname.ForeColor = Color.Silver;
            txt_birthdate.Text = "mm/dd/yyyy";
            txt_birthdate.ForeColor = Color.Silver;
            txt_contactnum.Text = "Contact Number";
            txt_contactnum.ForeColor = Color.Silver;
            txt_email.Text = "you@email.com";
            txt_email.ForeColor = Color.Silver;
            txt_address.Text = "House no./Street/Barangay/Town/City/Province/Country/Zip Code";
            txt_address.ForeColor = Color.Silver;
            txt_sex.Text = "Sex";
            txt_sex.ForeColor = Color.Silver;
            txt_age.Text = "Age";
            txt_age.ForeColor = Color.Silver;
            txt_checkin.Text = "00:00 AM/PM";
            txt_checkin.ForeColor = Color.Silver;
            txt_checkout.Text = "00:00 AM/PM";
            txt_checkout.ForeColor = Color.Silver;
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

        private void txt_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void personall_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void CaptureDevie_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            qrcodescanner show = new qrcodescanner();
            show.ShowDialog();
        }
    }
}
