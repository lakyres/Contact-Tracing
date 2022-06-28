namespace contact_tracing
{
    partial class adminonly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminonly));
            this.transparent_panel = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.transparent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparent_panel
            // 
            this.transparent_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.transparent_panel.Controls.Add(this.show_pass);
            this.transparent_panel.Controls.Add(this.btn_login);
            this.transparent_panel.Controls.Add(this.txt_password);
            this.transparent_panel.Controls.Add(this.txt_username);
            this.transparent_panel.Controls.Add(this.lbl_password);
            this.transparent_panel.Controls.Add(this.lbl_username);
            this.transparent_panel.Controls.Add(this.lbl_admin);
            this.transparent_panel.Location = new System.Drawing.Point(154, 111);
            this.transparent_panel.Name = "transparent_panel";
            this.transparent_panel.Size = new System.Drawing.Size(332, 305);
            this.transparent_panel.TabIndex = 0;
            this.transparent_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Plum;
            this.btn_login.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(115, 239);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(101, 43);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(135, 190);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(147, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(135, 122);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(147, 20);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_password.Location = new System.Drawing.Point(42, 188);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(87, 22);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_username.Location = new System.Drawing.Point(40, 120);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(89, 22);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.HotPink;
            this.lbl_admin.Location = new System.Drawing.Point(87, 29);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(160, 38);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "Admin log in";
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pass.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.show_pass.Location = new System.Drawing.Point(222, 216);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(77, 26);
            this.show_pass.TabIndex = 21;
            this.show_pass.Text = "Show ";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // adminonly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.transparent_panel);
            this.Name = "adminonly";
            this.Size = new System.Drawing.Size(686, 534);
            this.transparent_panel.ResumeLayout(false);
            this.transparent_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel transparent_panel;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox show_pass;
    }
}
