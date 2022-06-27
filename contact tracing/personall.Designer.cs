namespace contact_tracing
{
    partial class personall
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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_birthdate = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_contactnum = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_contactnum = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_firstname.Location = new System.Drawing.Point(63, 79);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(100, 22);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Location = new System.Drawing.Point(68, 132);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(95, 22);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middlename.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_middlename.Location = new System.Drawing.Point(47, 105);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(116, 22);
            this.lbl_middlename.TabIndex = 2;
            this.lbl_middlename.Text = "Middle Name";
            // 
            // txt_firstname
            // 
            this.txt_firstname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_firstname.Location = new System.Drawing.Point(169, 82);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(139, 20);
            this.txt_firstname.TabIndex = 3;
            this.txt_firstname.Text = "First Name";
            this.txt_firstname.Enter += new System.EventHandler(this.txt_firstname_Enter);
            this.txt_firstname.Leave += new System.EventHandler(this.txt_firstname_Leave);
            // 
            // txt_lastname
            // 
            this.txt_lastname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_lastname.Location = new System.Drawing.Point(169, 134);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(139, 20);
            this.txt_lastname.TabIndex = 4;
            this.txt_lastname.Text = "Last Name";
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_lastname_TextChanged);
            this.txt_lastname.Enter += new System.EventHandler(this.txt_lastname_Enter);
            this.txt_lastname.Leave += new System.EventHandler(this.txt_lastname_Leave);
            // 
            // txt_middlename
            // 
            this.txt_middlename.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_middlename.Location = new System.Drawing.Point(169, 108);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(139, 20);
            this.txt_middlename.TabIndex = 5;
            this.txt_middlename.Text = "Put N/A if none";
            this.txt_middlename.Enter += new System.EventHandler(this.txt_middlename_Enter);
            this.txt_middlename.Leave += new System.EventHandler(this.txt_middlename_Leave);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_birthdate.Location = new System.Drawing.Point(365, 79);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(113, 22);
            this.lbl_birthdate.TabIndex = 6;
            this.lbl_birthdate.Text = "Date of Birth";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_age.Location = new System.Drawing.Point(437, 102);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(41, 22);
            this.lbl_age.TabIndex = 7;
            this.lbl_age.Text = "Age";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_sex.Location = new System.Drawing.Point(440, 128);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(38, 22);
            this.lbl_sex.TabIndex = 8;
            this.lbl_sex.Text = "Sex";
            // 
            // txt_age
            // 
            this.txt_age.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_age.Location = new System.Drawing.Point(484, 105);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(48, 20);
            this.txt_age.TabIndex = 9;
            this.txt_age.Text = "Age";
            this.txt_age.Enter += new System.EventHandler(this.txt_age_Enter);
            this.txt_age.Leave += new System.EventHandler(this.txt_age_Leave);
            // 
            // txt_sex
            // 
            this.txt_sex.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_sex.Location = new System.Drawing.Point(484, 131);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(79, 20);
            this.txt_sex.TabIndex = 10;
            this.txt_sex.Text = "Sex";
            this.txt_sex.Enter += new System.EventHandler(this.txt_sex_Enter);
            this.txt_sex.Leave += new System.EventHandler(this.txt_sex_Leave);
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_birthdate.Location = new System.Drawing.Point(484, 79);
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(115, 20);
            this.txt_birthdate.TabIndex = 11;
            this.txt_birthdate.Text = "dd/mm/yyyy";
            this.txt_birthdate.Enter += new System.EventHandler(this.txt_birthdate_Enter);
            this.txt_birthdate.Leave += new System.EventHandler(this.txt_birthdate_Leave);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_address.Location = new System.Drawing.Point(63, 261);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(75, 22);
            this.lbl_address.TabIndex = 12;
            this.lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_address.Location = new System.Drawing.Point(144, 264);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(441, 20);
            this.txt_address.TabIndex = 13;
            this.txt_address.Text = "House no./Street/Barangay/Town/City/Province/Country/Zip Code";
            this.txt_address.Enter += new System.EventHandler(this.txt_address_Enter);
            this.txt_address.Leave += new System.EventHandler(this.txt_address_Leave);
            // 
            // lbl_contactnum
            // 
            this.lbl_contactnum.AutoSize = true;
            this.lbl_contactnum.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactnum.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_contactnum.Location = new System.Drawing.Point(139, 347);
            this.lbl_contactnum.Name = "lbl_contactnum";
            this.lbl_contactnum.Size = new System.Drawing.Size(141, 22);
            this.lbl_contactnum.TabIndex = 14;
            this.lbl_contactnum.Text = "Contact Number";
            this.lbl_contactnum.Click += new System.EventHandler(this.lbl_contactnum_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_email.Location = new System.Drawing.Point(225, 373);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 22);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email";
            // 
            // txt_contactnum
            // 
            this.txt_contactnum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_contactnum.Location = new System.Drawing.Point(286, 349);
            this.txt_contactnum.Name = "txt_contactnum";
            this.txt_contactnum.Size = new System.Drawing.Size(139, 20);
            this.txt_contactnum.TabIndex = 16;
            this.txt_contactnum.Text = "Contact Number";
            this.txt_contactnum.Enter += new System.EventHandler(this.txt_contactnum_Enter);
            this.txt_contactnum.Leave += new System.EventHandler(this.txt_contactnum_Leave);
            // 
            // txt_email
            // 
            this.txt_email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_email.Location = new System.Drawing.Point(286, 375);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(165, 20);
            this.txt_email.TabIndex = 17;
            this.txt_email.Text = "you@email.com";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Thistle;
            this.btn_submit.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_submit.Location = new System.Drawing.Point(462, 409);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 43);
            this.btn_submit.TabIndex = 18;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // personall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
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
            this.Name = "personall";
            this.Size = new System.Drawing.Size(631, 503);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_birthdate;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_contactnum;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_contactnum;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_submit;
    }
}
