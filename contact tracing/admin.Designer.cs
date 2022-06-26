namespace contact_tracing
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.transparent_panel = new System.Windows.Forms.Panel();
            this.login_lbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.transparent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparent_panel
            // 
            this.transparent_panel.Controls.Add(this.login_btn);
            this.transparent_panel.Controls.Add(this.textBox2);
            this.transparent_panel.Controls.Add(this.textBox1);
            this.transparent_panel.Controls.Add(this.password);
            this.transparent_panel.Controls.Add(this.label1);
            this.transparent_panel.Controls.Add(this.username);
            this.transparent_panel.Controls.Add(this.login_lbl);
            this.transparent_panel.Location = new System.Drawing.Point(112, 68);
            this.transparent_panel.Name = "transparent_panel";
            this.transparent_panel.Size = new System.Drawing.Size(359, 408);
            this.transparent_panel.TabIndex = 0;
            this.transparent_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Bebas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.login_lbl.Location = new System.Drawing.Point(88, 55);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(183, 44);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "ADMIN LOG IN";
            this.login_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.LightPink;
            this.username.Location = new System.Drawing.Point(34, 165);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 19);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.LightPink;
            this.password.Location = new System.Drawing.Point(34, 234);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 19);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 5;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.BlueViolet;
            this.login_btn.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.login_btn.Location = new System.Drawing.Point(145, 297);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 28);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.transparent_panel);
            this.DoubleBuffered = true;
            this.Name = "admin";
            this.Size = new System.Drawing.Size(624, 525);
            this.Load += new System.EventHandler(this.admin_Load);
            this.transparent_panel.ResumeLayout(false);
            this.transparent_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel transparent_panel;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btn;
    }
}
