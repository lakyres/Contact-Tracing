namespace contact_tracing
{
    partial class timecheck
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_checkin = new System.Windows.Forms.TextBox();
            this.txt_checkout = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.lbl_checkin = new System.Windows.Forms.Label();
            this.lbl_checkout = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txt_checkin
            // 
            this.txt_checkin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_checkin.Location = new System.Drawing.Point(327, 204);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.Size = new System.Drawing.Size(111, 20);
            this.txt_checkin.TabIndex = 1;
            this.txt_checkin.Text = "00:00 AM/PM";
            this.txt_checkin.Enter += new System.EventHandler(this.txt_checkin_Enter);
            this.txt_checkin.Leave += new System.EventHandler(this.txt_checkin_Leave);
            // 
            // txt_checkout
            // 
            this.txt_checkout.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_checkout.Location = new System.Drawing.Point(327, 289);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(111, 20);
            this.txt_checkout.TabIndex = 2;
            this.txt_checkout.Text = "00:00 AM/PM";
            this.txt_checkout.Enter += new System.EventHandler(this.txt_checkout_Enter);
            this.txt_checkout.Leave += new System.EventHandler(this.txt_checkout_Leave);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Transparent;
            this.date.Location = new System.Drawing.Point(278, 98);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(47, 22);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_checkin
            // 
            this.lbl_checkin.AutoSize = true;
            this.lbl_checkin.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkin.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_checkin.Location = new System.Drawing.Point(146, 204);
            this.lbl_checkin.Name = "lbl_checkin";
            this.lbl_checkin.Size = new System.Drawing.Size(127, 22);
            this.lbl_checkin.TabIndex = 4;
            this.lbl_checkin.Text = "Time Check In";
            // 
            // lbl_checkout
            // 
            this.lbl_checkout.AutoSize = true;
            this.lbl_checkout.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkout.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_checkout.Location = new System.Drawing.Point(146, 286);
            this.lbl_checkout.Name = "lbl_checkout";
            this.lbl_checkout.Size = new System.Drawing.Size(141, 22);
            this.lbl_checkout.TabIndex = 5;
            this.lbl_checkout.Text = "Time Check Out";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(253, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timecheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_checkout);
            this.Controls.Add(this.lbl_checkin);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txt_checkout);
            this.Controls.Add(this.txt_checkin);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "timecheck";
            this.Size = new System.Drawing.Size(686, 521);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_checkin;
        private System.Windows.Forms.TextBox txt_checkout;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lbl_checkin;
        private System.Windows.Forms.Label lbl_checkout;
        private System.Windows.Forms.Button button1;
    }
}
