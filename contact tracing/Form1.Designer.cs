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
            this.menu_logo = new System.Windows.Forms.Panel();
            this.menu_btn1 = new System.Windows.Forms.Button();
            this.menu_btn2 = new System.Windows.Forms.Button();
            this.menu_btn3 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
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
            this.menu.Location = new System.Drawing.Point(590, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(230, 540);
            this.menu.TabIndex = 0;
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
            // 
            // contraceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.menu);
            this.Name = "contraceform";
            this.Text = "Digital Contact Tracing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button menu_btn3;
        private System.Windows.Forms.Button menu_btn2;
        private System.Windows.Forms.Button menu_btn1;
        private System.Windows.Forms.Panel menu_logo;
    }
}

