namespace contact_tracing
{
    partial class personal_info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_birthdate = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.lbl_contactnum = new System.Windows.Forms.Label();
            this.txt_contactnum = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.submit_btn1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(190, 96);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(127, 20);
            this.txt_firstname.TabIndex = 0;
            this.txt_firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.Color.White;
            this.lbl_firstname.Location = new System.Drawing.Point(101, 96);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(83, 18);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "First Name";
            this.lbl_firstname.Click += new System.EventHandler(this.lbl_firstname_Click);
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middlename.ForeColor = System.Drawing.Color.White;
            this.lbl_middlename.Location = new System.Drawing.Point(19, 126);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(165, 18);
            this.lbl_middlename.TabIndex = 2;
            this.lbl_middlename.Text = "Middle Name (optional)";
            this.lbl_middlename.Click += new System.EventHandler(this.middlename_Click);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.White;
            this.lbl_lastname.Location = new System.Drawing.Point(104, 153);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(80, 18);
            this.lbl_lastname.TabIndex = 3;
            this.lbl_lastname.Text = "Last Name";
            this.lbl_lastname.Click += new System.EventHandler(this.lbl_lastname_Click);
            // 
            // txt_middlename
            // 
            this.txt_middlename.Location = new System.Drawing.Point(190, 124);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(127, 20);
            this.txt_middlename.TabIndex = 4;
            this.txt_middlename.TextChanged += new System.EventHandler(this.txt_middlename_TextChanged);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(190, 151);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(127, 20);
            this.txt_lastname.TabIndex = 5;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.White;
            this.lbl_age.Location = new System.Drawing.Point(398, 124);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(35, 18);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "Age";
            this.lbl_age.Click += new System.EventHandler(this.age_Click);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.White;
            this.lbl_birthdate.Location = new System.Drawing.Point(337, 96);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(96, 18);
            this.lbl_birthdate.TabIndex = 7;
            this.lbl_birthdate.Text = "Date of Birth";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(439, 122);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(43, 20);
            this.txt_age.TabIndex = 8;
            this.txt_age.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.Location = new System.Drawing.Point(439, 96);
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(127, 20);
            this.txt_birthdate.TabIndex = 9;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.White;
            this.lbl_sex.Location = new System.Drawing.Point(400, 151);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(32, 18);
            this.lbl_sex.TabIndex = 10;
            this.lbl_sex.Text = "Sex";
            this.lbl_sex.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_sex
            // 
            this.txt_sex.Location = new System.Drawing.Point(438, 151);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(77, 20);
            this.txt_sex.TabIndex = 11;
            // 
            // lbl_contactnum
            // 
            this.lbl_contactnum.AutoSize = true;
            this.lbl_contactnum.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactnum.ForeColor = System.Drawing.Color.White;
            this.lbl_contactnum.Location = new System.Drawing.Point(116, 338);
            this.lbl_contactnum.Name = "lbl_contactnum";
            this.lbl_contactnum.Size = new System.Drawing.Size(119, 18);
            this.lbl_contactnum.TabIndex = 12;
            this.lbl_contactnum.Text = "Contact Number";
            this.lbl_contactnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_contactnum
            // 
            this.txt_contactnum.Location = new System.Drawing.Point(241, 338);
            this.txt_contactnum.Name = "txt_contactnum";
            this.txt_contactnum.Size = new System.Drawing.Size(127, 20);
            this.txt_contactnum.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(241, 369);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(191, 20);
            this.txt_email.TabIndex = 14;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(188, 369);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 18);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(74, 249);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 18);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(140, 249);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(406, 20);
            this.txt_address.TabIndex = 17;
            // 
            // submit_btn1
            // 
            this.submit_btn1.BackColor = System.Drawing.Color.Thistle;
            this.submit_btn1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn1.ForeColor = System.Drawing.Color.White;
            this.submit_btn1.Location = new System.Drawing.Point(452, 420);
            this.submit_btn1.Name = "submit_btn1";
            this.submit_btn1.Size = new System.Drawing.Size(105, 41);
            this.submit_btn1.TabIndex = 18;
            this.submit_btn1.Text = "Submit";
            this.submit_btn1.UseVisualStyleBackColor = false;
            this.submit_btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(34, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 24);
            this.date.TabIndex = 19;
            // 
            // personal_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.date);
            this.Controls.Add(this.submit_btn1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contactnum);
            this.Controls.Add(this.lbl_contactnum);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.txt_birthdate);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_middlename);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txt_firstname);
            this.Name = "personal_info";
            this.Size = new System.Drawing.Size(586, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_birthdate;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.Label lbl_contactnum;
        private System.Windows.Forms.TextBox txt_contactnum;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button submit_btn1;
        private System.Windows.Forms.DateTimePicker date;
    }
}
