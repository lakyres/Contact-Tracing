namespace contact_tracing
{
    partial class selecteddatelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selecteddatelist));
            this.upper_panel = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.lbl_selectedrecord = new System.Windows.Forms.Label();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upper_panel
            // 
            this.upper_panel.AutoScroll = true;
            this.upper_panel.BackColor = System.Drawing.Color.Purple;
            this.upper_panel.Controls.Add(this.btn_x);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(800, 26);
            this.upper_panel.TabIndex = 0;
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
            this.btn_x.Location = new System.Drawing.Point(765, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(35, 26);
            this.btn_x.TabIndex = 3;
            this.btn_x.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // lbl_selectedrecord
            // 
            this.lbl_selectedrecord.AutoSize = true;
            this.lbl_selectedrecord.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedrecord.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_selectedrecord.Location = new System.Drawing.Point(34, 64);
            this.lbl_selectedrecord.Name = "lbl_selectedrecord";
            this.lbl_selectedrecord.Size = new System.Drawing.Size(150, 20);
            this.lbl_selectedrecord.TabIndex = 1;
            this.lbl_selectedrecord.Text = "Records on this date";
            // 
            // selecteddatelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_selectedrecord);
            this.Controls.Add(this.upper_panel);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selecteddatelist";
            this.Text = "selecteddatelist";
            this.Load += new System.EventHandler(this.selecteddatelist_Load);
            this.upper_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Label lbl_selectedrecord;
        private System.Windows.Forms.Button btn_x;
    }
}