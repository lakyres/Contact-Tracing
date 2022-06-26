namespace contact_tracing
{
    partial class successlogin_pg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successlogin_pg));
            this.up_border = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.up_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // up_border
            // 
            this.up_border.BackColor = System.Drawing.Color.DeepPink;
            this.up_border.Controls.Add(this.btn_x);
            this.up_border.Dock = System.Windows.Forms.DockStyle.Top;
            this.up_border.Location = new System.Drawing.Point(0, 0);
            this.up_border.Name = "up_border";
            this.up_border.Size = new System.Drawing.Size(469, 26);
            this.up_border.TabIndex = 0;
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
            this.btn_x.Location = new System.Drawing.Point(434, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(35, 26);
            this.btn_x.TabIndex = 3;
            this.btn_x.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // successlogin_pg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.up_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "successlogin_pg";
            this.Text = "Form2";
            this.up_border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel up_border;
        private System.Windows.Forms.Button btn_x;
    }
}