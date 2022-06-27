namespace contact_tracing
{
    partial class checktime
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txt_checkin = new System.Windows.Forms.TextBox();
            this.txt_checkout = new System.Windows.Forms.TextBox();
            this.lbl_checkout = new System.Windows.Forms.Label();
            this.lbl_checkin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(198, 73);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 24);
            this.date.TabIndex = 0;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_checkin
            // 
            this.txt_checkin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_checkin.Location = new System.Drawing.Point(349, 166);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.Size = new System.Drawing.Size(102, 20);
            this.txt_checkin.TabIndex = 1;
            this.txt_checkin.Text = "00:00 AM/PM";
            this.txt_checkin.Enter += new System.EventHandler(this.txt_checkin_Enter);
            this.txt_checkin.Leave += new System.EventHandler(this.txt_checkin_Leave);
            // 
            // txt_checkout
            // 
            this.txt_checkout.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_checkout.Location = new System.Drawing.Point(349, 255);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(102, 20);
            this.txt_checkout.TabIndex = 2;
            this.txt_checkout.Text = "00:00 AM/PM";
            this.txt_checkout.Enter += new System.EventHandler(this.txt_checkout_Enter);
            this.txt_checkout.Leave += new System.EventHandler(this.txt_checkout_Leave);
            // 
            // lbl_checkout
            // 
            this.lbl_checkout.AutoSize = true;
            this.lbl_checkout.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkout.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_checkout.Location = new System.Drawing.Point(148, 252);
            this.lbl_checkout.Name = "lbl_checkout";
            this.lbl_checkout.Size = new System.Drawing.Size(141, 22);
            this.lbl_checkout.TabIndex = 3;
            this.lbl_checkout.Text = "Time Check Out";
            // 
            // lbl_checkin
            // 
            this.lbl_checkin.AutoSize = true;
            this.lbl_checkin.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkin.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_checkin.Location = new System.Drawing.Point(148, 164);
            this.lbl_checkin.Name = "lbl_checkin";
            this.lbl_checkin.Size = new System.Drawing.Size(127, 22);
            this.lbl_checkin.TabIndex = 4;
            this.lbl_checkin.Text = "Time Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(287, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Plum;
            this.btn_submit.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_submit.Location = new System.Drawing.Point(259, 315);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 43);
            this.btn_submit.TabIndex = 19;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // checktime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_checkin);
            this.Controls.Add(this.lbl_checkout);
            this.Controls.Add(this.txt_checkout);
            this.Controls.Add(this.txt_checkin);
            this.Controls.Add(this.date);
            this.Name = "checktime";
            this.Size = new System.Drawing.Size(651, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txt_checkin;
        private System.Windows.Forms.TextBox txt_checkout;
        private System.Windows.Forms.Label lbl_checkout;
        private System.Windows.Forms.Label lbl_checkin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_submit;
    }
}
