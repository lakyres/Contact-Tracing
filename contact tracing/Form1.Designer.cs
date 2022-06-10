namespace contact_tracing
{
    partial class contraceform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contraceform));
            this.menu = new System.Windows.Forms.Panel();
            this.menu_btn3 = new System.Windows.Forms.Button();
            this.menu_btn2 = new System.Windows.Forms.Button();
            this.menu_btn1 = new System.Windows.Forms.Button();
            this.menu_logo = new System.Windows.Forms.Panel();
            this.menu_top = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.symptoms1 = new contact_tracing.symptoms();
            this.timedate1 = new contact_tracing.timedate();
            this.personal_info1 = new contact_tracing.personal_info();
            this.menu.SuspendLayout();
            this.menu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.menu.Controls.Add(this.menu_btn3);
            this.menu.Controls.Add(this.menu_btn2);
            this.menu.Controls.Add(this.menu_btn1);
            this.menu.Controls.Add(this.menu_logo);
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(644, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(230, 540);
            this.menu.TabIndex = 0;
            // 
            // menu_btn3
            // 
            this.menu_btn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn3.FlatAppearance.BorderSize = 0;
            this.menu_btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn3.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn3.ForeColor = System.Drawing.Color.Snow;
            this.menu_btn3.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn3.Image")));
            this.menu_btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn3.Location = new System.Drawing.Point(0, 280);
            this.menu_btn3.Name = "menu_btn3";
            this.menu_btn3.Padding = new System.Windows.Forms.Padding(11);
            this.menu_btn3.Size = new System.Drawing.Size(230, 90);
            this.menu_btn3.TabIndex = 3;
            this.menu_btn3.Text = "   Date/Time";
            this.menu_btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_btn3.UseVisualStyleBackColor = true;
            this.menu_btn3.Click += new System.EventHandler(this.menu_btn3_Click);
            // 
            // menu_btn2
            // 
            this.menu_btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn2.FlatAppearance.BorderSize = 0;
            this.menu_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn2.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn2.ForeColor = System.Drawing.Color.Snow;
            this.menu_btn2.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn2.Image")));
            this.menu_btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn2.Location = new System.Drawing.Point(0, 190);
            this.menu_btn2.Name = "menu_btn2";
            this.menu_btn2.Padding = new System.Windows.Forms.Padding(11);
            this.menu_btn2.Size = new System.Drawing.Size(230, 90);
            this.menu_btn2.TabIndex = 2;
            this.menu_btn2.Text = " Symptoms";
            this.menu_btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_btn2.UseVisualStyleBackColor = true;
            this.menu_btn2.Click += new System.EventHandler(this.menu_btn2_Click);
            // 
            // menu_btn1
            // 
            this.menu_btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn1.FlatAppearance.BorderSize = 0;
            this.menu_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn1.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn1.ForeColor = System.Drawing.Color.Snow;
            this.menu_btn1.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn1.Image")));
            this.menu_btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn1.Location = new System.Drawing.Point(0, 100);
            this.menu_btn1.Name = "menu_btn1";
            this.menu_btn1.Padding = new System.Windows.Forms.Padding(11);
            this.menu_btn1.Size = new System.Drawing.Size(230, 90);
            this.menu_btn1.TabIndex = 1;
            this.menu_btn1.Text = "  Personal    Information";
            this.menu_btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_btn1.UseVisualStyleBackColor = true;
            this.menu_btn1.Click += new System.EventHandler(this.menu_btn1_Click);
            // 
            // menu_logo
            // 
            this.menu_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.menu_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_logo.BackgroundImage")));
            this.menu_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_logo.Location = new System.Drawing.Point(0, 0);
            this.menu_logo.Name = "menu_logo";
            this.menu_logo.Padding = new System.Windows.Forms.Padding(11);
            this.menu_logo.Size = new System.Drawing.Size(230, 100);
            this.menu_logo.TabIndex = 0;
            // 
            // menu_top
            // 
            this.menu_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.menu_top.Controls.Add(this.btn_x);
            this.menu_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Size = new System.Drawing.Size(644, 27);
            this.menu_top.TabIndex = 1;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.Plum;
            this.btn_x.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_x.FlatAppearance.BorderSize = 0;
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.ForeColor = System.Drawing.Color.Snow;
            this.btn_x.Image = ((System.Drawing.Image)(resources.GetObject("btn_x.Image")));
            this.btn_x.Location = new System.Drawing.Point(609, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(35, 27);
            this.btn_x.TabIndex = 2;
            this.btn_x.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // symptoms1
            // 
            this.symptoms1.BackColor = System.Drawing.Color.MediumPurple;
            this.symptoms1.Location = new System.Drawing.Point(0, 24);
            this.symptoms1.Name = "symptoms1";
            this.symptoms1.Size = new System.Drawing.Size(644, 516);
            this.symptoms1.TabIndex = 4;
            // 
            // timedate1
            // 
            this.timedate1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.timedate1.Location = new System.Drawing.Point(0, 24);
            this.timedate1.Name = "timedate1";
            this.timedate1.Size = new System.Drawing.Size(644, 516);
            this.timedate1.TabIndex = 3;
            // 
            // personal_info1
            // 
            this.personal_info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.personal_info1.Location = new System.Drawing.Point(0, 24);
            this.personal_info1.Name = "personal_info1";
            this.personal_info1.Size = new System.Drawing.Size(644, 516);
            this.personal_info1.TabIndex = 2;
            // 
            // contraceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 540);
            this.Controls.Add(this.symptoms1);
            this.Controls.Add(this.timedate1);
            this.Controls.Add(this.personal_info1);
            this.Controls.Add(this.menu_top);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "contraceform";
            this.Text = "Digital Contact Tracing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button menu_btn3;
        private System.Windows.Forms.Button menu_btn2;
        private System.Windows.Forms.Button menu_btn1;
        private System.Windows.Forms.Panel menu_logo;
        private System.Windows.Forms.Panel menu_top;
        private System.Windows.Forms.Button btn_x;
        private personal_info personal_info1;
        private timedate timedate1;
        private symptoms symptoms1;
    }
}

