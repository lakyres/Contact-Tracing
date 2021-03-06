namespace contact_tracing
{
    partial class contacttracing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contactnum = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_contactnum = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_birthdate = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.btn_submit2 = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.lbl_display = new System.Windows.Forms.Label();
            this.camera = new System.Windows.Forms.PictureBox();
            this.lbl_scan = new System.Windows.Forms.Label();
            this.webcam = new System.Windows.Forms.ComboBox();
            this.lbl_webcam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(23, 93);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 24);
            this.date.TabIndex = 44;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Thistle;
            this.btn_submit.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_submit.Location = new System.Drawing.Point(494, 402);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 43);
            this.btn_submit.TabIndex = 43;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // txt_email
            // 
            this.txt_email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_email.Location = new System.Drawing.Point(256, 388);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(165, 20);
            this.txt_email.TabIndex = 42;
            this.txt_email.Text = "you@email.com";
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_contactnum
            // 
            this.txt_contactnum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_contactnum.Location = new System.Drawing.Point(256, 362);
            this.txt_contactnum.Name = "txt_contactnum";
            this.txt_contactnum.Size = new System.Drawing.Size(139, 20);
            this.txt_contactnum.TabIndex = 41;
            this.txt_contactnum.Text = "Contact Number";
            this.txt_contactnum.TextChanged += new System.EventHandler(this.txt_contactnum_TextChanged);
            this.txt_contactnum.Enter += new System.EventHandler(this.txt_contactnum_Enter);
            this.txt_contactnum.Leave += new System.EventHandler(this.txt_contactnum_Leave);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_email.Location = new System.Drawing.Point(195, 385);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 22);
            this.lbl_email.TabIndex = 40;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_contactnum
            // 
            this.lbl_contactnum.AutoSize = true;
            this.lbl_contactnum.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactnum.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_contactnum.Location = new System.Drawing.Point(109, 363);
            this.lbl_contactnum.Name = "lbl_contactnum";
            this.lbl_contactnum.Size = new System.Drawing.Size(141, 22);
            this.lbl_contactnum.TabIndex = 39;
            this.lbl_contactnum.Text = "Contact Number";
            this.lbl_contactnum.Click += new System.EventHandler(this.lbl_contactnum_Click_1);
            // 
            // txt_address
            // 
            this.txt_address.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_address.Location = new System.Drawing.Point(118, 283);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(441, 20);
            this.txt_address.TabIndex = 38;
            this.txt_address.Text = "House no./Street/Barangay/Town/City/Province/Country/Zip Code";
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            this.txt_address.Enter += new System.EventHandler(this.txt_address_Enter);
            this.txt_address.Leave += new System.EventHandler(this.txt_address_Leave);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_address.Location = new System.Drawing.Point(37, 280);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(75, 22);
            this.lbl_address.TabIndex = 37;
            this.lbl_address.Text = "Address";
            this.lbl_address.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_birthdate.Location = new System.Drawing.Point(480, 141);
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(115, 20);
            this.txt_birthdate.TabIndex = 36;
            this.txt_birthdate.Text = "mm/dd/yyyy";
            this.txt_birthdate.TextChanged += new System.EventHandler(this.txt_birthdate_TextChanged);
            this.txt_birthdate.Enter += new System.EventHandler(this.txt_birthdate_Enter);
            this.txt_birthdate.Leave += new System.EventHandler(this.txt_birthdate_Leave);
            // 
            // txt_sex
            // 
            this.txt_sex.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_sex.Location = new System.Drawing.Point(480, 193);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(79, 20);
            this.txt_sex.TabIndex = 35;
            this.txt_sex.Text = "Sex";
            this.txt_sex.TextChanged += new System.EventHandler(this.txt_sex_TextChanged);
            this.txt_sex.Enter += new System.EventHandler(this.txt_sex_Enter);
            this.txt_sex.Leave += new System.EventHandler(this.txt_sex_Leave);
            // 
            // txt_age
            // 
            this.txt_age.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_age.Location = new System.Drawing.Point(480, 167);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(48, 20);
            this.txt_age.TabIndex = 34;
            this.txt_age.Text = "Age";
            this.txt_age.TextChanged += new System.EventHandler(this.txt_age_TextChanged);
            this.txt_age.Enter += new System.EventHandler(this.txt_age_Enter);
            this.txt_age.Leave += new System.EventHandler(this.txt_age_Leave);
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_sex.Location = new System.Drawing.Point(436, 190);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(38, 22);
            this.lbl_sex.TabIndex = 33;
            this.lbl_sex.Text = "Sex";
            this.lbl_sex.Click += new System.EventHandler(this.lbl_sex_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_age.Location = new System.Drawing.Point(433, 164);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(41, 22);
            this.lbl_age.TabIndex = 32;
            this.lbl_age.Text = "Age";
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_birthdate.Location = new System.Drawing.Point(361, 141);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(113, 22);
            this.lbl_birthdate.TabIndex = 31;
            this.lbl_birthdate.Text = "Date of Birth";
            this.lbl_birthdate.Click += new System.EventHandler(this.lbl_birthdate_Click);
            // 
            // txt_middlename
            // 
            this.txt_middlename.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_middlename.Location = new System.Drawing.Point(165, 170);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(139, 20);
            this.txt_middlename.TabIndex = 30;
            this.txt_middlename.Text = "Put NA if none";
            this.txt_middlename.TextChanged += new System.EventHandler(this.txt_middlename_TextChanged);
            this.txt_middlename.Enter += new System.EventHandler(this.txt_middlename_Enter);
            this.txt_middlename.Leave += new System.EventHandler(this.txt_middlename_Leave);
            // 
            // txt_lastname
            // 
            this.txt_lastname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_lastname.Location = new System.Drawing.Point(165, 196);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(139, 20);
            this.txt_lastname.TabIndex = 29;
            this.txt_lastname.Text = "Last Name";
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_lastname_TextChanged_1);
            this.txt_lastname.Enter += new System.EventHandler(this.txt_lastname_Enter);
            this.txt_lastname.Leave += new System.EventHandler(this.txt_lastname_Leave);
            // 
            // txt_firstname
            // 
            this.txt_firstname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_firstname.Location = new System.Drawing.Point(165, 144);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(139, 20);
            this.txt_firstname.TabIndex = 28;
            this.txt_firstname.Text = "First Name";
            this.txt_firstname.TextChanged += new System.EventHandler(this.txt_firstname_TextChanged);
            this.txt_firstname.Enter += new System.EventHandler(this.txt_firstname_Enter);
            this.txt_firstname.Leave += new System.EventHandler(this.txt_firstname_Leave);
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middlename.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_middlename.Location = new System.Drawing.Point(43, 167);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(116, 22);
            this.lbl_middlename.TabIndex = 27;
            this.lbl_middlename.Text = "Middle Name";
            this.lbl_middlename.Click += new System.EventHandler(this.lbl_middlename_Click);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Location = new System.Drawing.Point(64, 193);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(95, 22);
            this.lbl_lastname.TabIndex = 26;
            this.lbl_lastname.Text = "Last Name";
            this.lbl_lastname.Click += new System.EventHandler(this.lbl_lastname_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_firstname.Location = new System.Drawing.Point(59, 141);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(100, 22);
            this.lbl_firstname.TabIndex = 25;
            this.lbl_firstname.Text = "First Name";
            this.lbl_firstname.Click += new System.EventHandler(this.lbl_firstname_Click);
            // 
            // btn_submit2
            // 
            this.btn_submit2.BackColor = System.Drawing.Color.Thistle;
            this.btn_submit2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_submit2.Location = new System.Drawing.Point(1166, 428);
            this.btn_submit2.Name = "btn_submit2";
            this.btn_submit2.Size = new System.Drawing.Size(101, 43);
            this.btn_submit2.TabIndex = 57;
            this.btn_submit2.Text = "Submit";
            this.btn_submit2.UseVisualStyleBackColor = false;
            this.btn_submit2.Click += new System.EventHandler(this.btn_submit2_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.Plum;
            this.btn_scan.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_scan.Location = new System.Drawing.Point(1083, 172);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(101, 43);
            this.btn_scan.TabIndex = 56;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click_1);
            // 
            // txt_display
            // 
            this.txt_display.BackColor = System.Drawing.SystemColors.Info;
            this.txt_display.Location = new System.Drawing.Point(726, 328);
            this.txt_display.Multiline = true;
            this.txt_display.Name = "txt_display";
            this.txt_display.ReadOnly = true;
            this.txt_display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_display.Size = new System.Drawing.Size(434, 229);
            this.txt_display.TabIndex = 55;
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_display.Location = new System.Drawing.Point(640, 341);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(70, 22);
            this.lbl_display.TabIndex = 54;
            this.lbl_display.Text = "Display";
            // 
            // camera
            // 
            this.camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.camera.Location = new System.Drawing.Point(819, 80);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(258, 230);
            this.camera.TabIndex = 53;
            this.camera.TabStop = false;
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scan.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_scan.Location = new System.Drawing.Point(695, 182);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(118, 22);
            this.lbl_scan.TabIndex = 52;
            this.lbl_scan.Text = "Scan QR code";
            // 
            // webcam
            // 
            this.webcam.FormattingEnabled = true;
            this.webcam.Location = new System.Drawing.Point(819, 55);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(258, 21);
            this.webcam.TabIndex = 51;
            // 
            // lbl_webcam
            // 
            this.lbl_webcam.AutoSize = true;
            this.lbl_webcam.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_webcam.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_webcam.Location = new System.Drawing.Point(734, 55);
            this.lbl_webcam.Name = "lbl_webcam";
            this.lbl_webcam.Size = new System.Drawing.Size(79, 22);
            this.lbl_webcam.TabIndex = 50;
            this.lbl_webcam.Text = "Webcam";
            // 
            // contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1306, 581);
            this.Controls.Add(this.btn_submit2);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.lbl_scan);
            this.Controls.Add(this.webcam);
            this.Controls.Add(this.lbl_webcam);
            this.Controls.Add(this.date);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contactnum);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_contactnum);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_birthdate);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.lbl_middlename);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Name = "contacttracing";
            this.Text = "contacttracing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.contacttracing_FormClosing);
            this.Load += new System.EventHandler(this.contacttracing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contactnum;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contactnum;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_birthdate;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Button btn_submit2;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.Label lbl_scan;
        private System.Windows.Forms.ComboBox webcam;
        private System.Windows.Forms.Label lbl_webcam;
    }
}