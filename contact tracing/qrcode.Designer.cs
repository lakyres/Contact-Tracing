namespace contact_tracing
{
    partial class qrcodescanner
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
            this.lbl_webcam = new System.Windows.Forms.Label();
            this.webcam = new System.Windows.Forms.ComboBox();
            this.lbl_scan = new System.Windows.Forms.Label();
            this.camera = new System.Windows.Forms.PictureBox();
            this.lbl_display = new System.Windows.Forms.Label();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.date2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_webcam
            // 
            this.lbl_webcam.AutoSize = true;
            this.lbl_webcam.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_webcam.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_webcam.Location = new System.Drawing.Point(106, 37);
            this.lbl_webcam.Name = "lbl_webcam";
            this.lbl_webcam.Size = new System.Drawing.Size(79, 22);
            this.lbl_webcam.TabIndex = 28;
            this.lbl_webcam.Text = "Webcam";
            // 
            // webcam
            // 
            this.webcam.FormattingEnabled = true;
            this.webcam.Location = new System.Drawing.Point(191, 37);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(258, 21);
            this.webcam.TabIndex = 29;
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scan.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_scan.Location = new System.Drawing.Point(67, 164);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(118, 22);
            this.lbl_scan.TabIndex = 30;
            this.lbl_scan.Text = "Scan QR code";
            // 
            // camera
            // 
            this.camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.camera.Location = new System.Drawing.Point(191, 62);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(258, 230);
            this.camera.TabIndex = 31;
            this.camera.TabStop = false;
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_display.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_display.Location = new System.Drawing.Point(12, 323);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(70, 22);
            this.lbl_display.TabIndex = 32;
            this.lbl_display.Text = "Display";
            // 
            // txt_display
            // 
            this.txt_display.Location = new System.Drawing.Point(98, 310);
            this.txt_display.Multiline = true;
            this.txt_display.Name = "txt_display";
            this.txt_display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_display.Size = new System.Drawing.Size(434, 229);
            this.txt_display.TabIndex = 33;
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.Plum;
            this.btn_scan.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_scan.Location = new System.Drawing.Point(455, 154);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(101, 43);
            this.btn_scan.TabIndex = 34;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Thistle;
            this.btn_submit.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_submit.Location = new System.Drawing.Point(538, 410);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 43);
            this.btn_submit.TabIndex = 35;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Location = new System.Drawing.Point(483, 12);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(236, 24);
            this.date2.TabIndex = 36;
            // 
            // qrcodescanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(725, 551);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.lbl_scan);
            this.Controls.Add(this.webcam);
            this.Controls.Add(this.lbl_webcam);
            this.Name = "qrcodescanner";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qrcodescanner_FormClosing);
            this.Load += new System.EventHandler(this.qrcodescanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_webcam;
        private System.Windows.Forms.ComboBox webcam;
        private System.Windows.Forms.Label lbl_scan;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker date2;
    }
}