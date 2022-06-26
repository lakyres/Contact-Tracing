namespace contact_tracing
{
    partial class timedate
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
            this.txt_checkin = new System.Windows.Forms.TextBox();
            this.txt_checkout = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_checkin = new System.Windows.Forms.Label();
            this.lbl_checkout = new System.Windows.Forms.Label();
            this.submit_btn2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_checkin
            // 
            this.txt_checkin.Location = new System.Drawing.Point(293, 186);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.Size = new System.Drawing.Size(100, 20);
            this.txt_checkin.TabIndex = 1;
            // 
            // txt_checkout
            // 
            this.txt_checkout.Location = new System.Drawing.Point(293, 245);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(100, 20);
            this.txt_checkout.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(243, 128);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 19);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            this.lbl_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_checkin
            // 
            this.lbl_checkin.AutoSize = true;
            this.lbl_checkin.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkin.ForeColor = System.Drawing.Color.White;
            this.lbl_checkin.Location = new System.Drawing.Point(172, 186);
            this.lbl_checkin.Name = "lbl_checkin";
            this.lbl_checkin.Size = new System.Drawing.Size(115, 19);
            this.lbl_checkin.TabIndex = 4;
            this.lbl_checkin.Text = "Time Check In";
            this.lbl_checkin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_checkout
            // 
            this.lbl_checkout.AutoSize = true;
            this.lbl_checkout.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkout.ForeColor = System.Drawing.Color.White;
            this.lbl_checkout.Location = new System.Drawing.Point(160, 245);
            this.lbl_checkout.Name = "lbl_checkout";
            this.lbl_checkout.Size = new System.Drawing.Size(127, 19);
            this.lbl_checkout.TabIndex = 5;
            this.lbl_checkout.Text = "Time Check Out";
            this.lbl_checkout.Click += new System.EventHandler(this.label3_Click);
            // 
            // submit_btn2
            // 
            this.submit_btn2.BackColor = System.Drawing.Color.MediumOrchid;
            this.submit_btn2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn2.ForeColor = System.Drawing.Color.White;
            this.submit_btn2.Location = new System.Drawing.Point(403, 287);
            this.submit_btn2.Name = "submit_btn2";
            this.submit_btn2.Size = new System.Drawing.Size(89, 38);
            this.submit_btn2.TabIndex = 6;
            this.submit_btn2.Text = "Submit";
            this.submit_btn2.UseVisualStyleBackColor = false;
            this.submit_btn2.Click += new System.EventHandler(this.submit_btn2_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(292, 128);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 7;
            // 
            // timedate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.date);
            this.Controls.Add(this.submit_btn2);
            this.Controls.Add(this.lbl_checkout);
            this.Controls.Add(this.lbl_checkin);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_checkout);
            this.Controls.Add(this.txt_checkin);
            this.Name = "timedate";
            this.Size = new System.Drawing.Size(688, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_checkin;
        private System.Windows.Forms.TextBox txt_checkout;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_checkin;
        private System.Windows.Forms.Label lbl_checkout;
        private System.Windows.Forms.Button submit_btn2;
        private System.Windows.Forms.DateTimePicker date;
    }
}
