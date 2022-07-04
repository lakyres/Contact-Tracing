namespace contact_tracing
{
    partial class personall
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
            this.CTF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CTF
            // 
            this.CTF.BackColor = System.Drawing.Color.Plum;
            this.CTF.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTF.ForeColor = System.Drawing.Color.Transparent;
            this.CTF.Location = new System.Drawing.Point(220, 224);
            this.CTF.Name = "CTF";
            this.CTF.Size = new System.Drawing.Size(172, 98);
            this.CTF.TabIndex = 50;
            this.CTF.Text = "Contact Tracing Form";
            this.CTF.UseVisualStyleBackColor = false;
            this.CTF.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // personall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.CTF);
            this.Name = "personall";
            this.Size = new System.Drawing.Size(631, 541);
            this.Load += new System.EventHandler(this.personall_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CTF;
    }
}
