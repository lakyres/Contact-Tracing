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
            this.admin_btn5 = new System.Windows.Forms.Button();
            this.menu_btn4 = new System.Windows.Forms.Button();
            this.menu_btn1 = new System.Windows.Forms.Button();
            this.menu_logo = new System.Windows.Forms.Panel();
            this.menu_top = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.about1 = new contact_tracing.about();
            this.personall1 = new contact_tracing.personall();
            this.adminonly1 = new contact_tracing.adminonly();
            this.personall2 = new contact_tracing.personall();
            this.menu.SuspendLayout();
            this.menu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.menu.Controls.Add(this.admin_btn5);
            this.menu.Controls.Add(this.menu_btn4);
            this.menu.Controls.Add(this.menu_btn1);
            this.menu.Controls.Add(this.menu_logo);
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(644, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(230, 568);
            this.menu.TabIndex = 0;
            // 
            // admin_btn5
            // 
            this.admin_btn5.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_btn5.FlatAppearance.BorderSize = 0;
            this.admin_btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_btn5.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn5.ForeColor = System.Drawing.Color.Snow;
            this.admin_btn5.Image = ((System.Drawing.Image)(resources.GetObject("admin_btn5.Image")));
            this.admin_btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_btn5.Location = new System.Drawing.Point(0, 263);
            this.admin_btn5.Name = "admin_btn5";
            this.admin_btn5.Padding = new System.Windows.Forms.Padding(11);
            this.admin_btn5.Size = new System.Drawing.Size(230, 122);
            this.admin_btn5.TabIndex = 5;
            this.admin_btn5.Text = "Admin";
            this.admin_btn5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.admin_btn5.UseVisualStyleBackColor = true;
            this.admin_btn5.Click += new System.EventHandler(this.admin_btn5_Click);
            // 
            // menu_btn4
            // 
            this.menu_btn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn4.FlatAppearance.BorderSize = 0;
            this.menu_btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn4.Font = new System.Drawing.Font("Bebas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn4.ForeColor = System.Drawing.Color.Snow;
            this.menu_btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_btn4.Location = new System.Drawing.Point(0, 190);
            this.menu_btn4.Name = "menu_btn4";
            this.menu_btn4.Padding = new System.Windows.Forms.Padding(11);
            this.menu_btn4.Size = new System.Drawing.Size(230, 73);
            this.menu_btn4.TabIndex = 4;
            this.menu_btn4.Text = "About";
            this.menu_btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_btn4.UseVisualStyleBackColor = true;
            this.menu_btn4.Click += new System.EventHandler(this.button1_Click_1);
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
            this.menu_btn1.Text = "Fill out form";
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
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.HotPink;
            this.about1.Location = new System.Drawing.Point(0, 24);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(644, 544);
            this.about1.TabIndex = 5;
            // 
            // personall1
            // 
            this.personall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.personall1.Location = new System.Drawing.Point(0, 24);
            this.personall1.Name = "personall1";
            this.personall1.Size = new System.Drawing.Size(644, 544);
            this.personall1.TabIndex = 7;
            // 
            // adminonly1
            // 
            this.adminonly1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.adminonly1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminonly1.BackgroundImage")));
            this.adminonly1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminonly1.Location = new System.Drawing.Point(0, 24);
            this.adminonly1.Name = "adminonly1";
            this.adminonly1.Size = new System.Drawing.Size(644, 544);
            this.adminonly1.TabIndex = 9;
            // 
            // personall2
            // 
            this.personall2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.personall2.Location = new System.Drawing.Point(0, 24);
            this.personall2.Name = "personall2";
            this.personall2.Size = new System.Drawing.Size(644, 544);
            this.personall2.TabIndex = 10;
            // 
            // contraceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 568);
            this.Controls.Add(this.menu_top);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.personall2);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.personall1);
            this.Controls.Add(this.adminonly1);
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
        private System.Windows.Forms.Button menu_btn1;
        private System.Windows.Forms.Panel menu_logo;
        private System.Windows.Forms.Panel menu_top;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button menu_btn4;
        private about about1;
        private System.Windows.Forms.Button admin_btn5;
        private personall personall1;
        private adminonly adminonly1;
        private personall personall2;
    }
}

