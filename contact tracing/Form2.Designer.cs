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
            this.view_all = new System.Windows.Forms.Button();
            this.date_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.view_date = new System.Windows.Forms.Button();
            this.selectedate_pnl = new System.Windows.Forms.Label();
            this.up_border.SuspendLayout();
            this.date_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // up_border
            // 
            this.up_border.BackColor = System.Drawing.Color.Orchid;
            this.up_border.Controls.Add(this.btn_x);
            this.up_border.Dock = System.Windows.Forms.DockStyle.Top;
            this.up_border.Location = new System.Drawing.Point(0, 0);
            this.up_border.Name = "up_border";
            this.up_border.Size = new System.Drawing.Size(896, 26);
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
            this.btn_x.Location = new System.Drawing.Point(861, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(35, 26);
            this.btn_x.TabIndex = 3;
            this.btn_x.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // view_all
            // 
            this.view_all.BackColor = System.Drawing.Color.Pink;
            this.view_all.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.DarkOrchid;
            this.view_all.Location = new System.Drawing.Point(91, 89);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(257, 128);
            this.view_all.TabIndex = 1;
            this.view_all.Text = "View all contact tracing records\r\n";
            this.view_all.UseVisualStyleBackColor = false;
            this.view_all.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_panel
            // 
            this.date_panel.BackColor = System.Drawing.Color.MediumPurple;
            this.date_panel.Controls.Add(this.selectedate_pnl);
            this.date_panel.Controls.Add(this.view_date);
            this.date_panel.Controls.Add(this.dateTimePicker1);
            this.date_panel.Location = new System.Drawing.Point(485, 53);
            this.date_panel.Name = "date_panel";
            this.date_panel.Size = new System.Drawing.Size(333, 206);
            this.date_panel.TabIndex = 2;
            this.date_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // view_date
            // 
            this.view_date.BackColor = System.Drawing.Color.Pink;
            this.view_date.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_date.ForeColor = System.Drawing.Color.DarkOrchid;
            this.view_date.Location = new System.Drawing.Point(93, 109);
            this.view_date.Name = "view_date";
            this.view_date.Size = new System.Drawing.Size(153, 71);
            this.view_date.TabIndex = 1;
            this.view_date.Text = "VIEW";
            this.view_date.UseVisualStyleBackColor = false;
            // 
            // selectedate_pnl
            // 
            this.selectedate_pnl.AutoSize = true;
            this.selectedate_pnl.Font = new System.Drawing.Font("Bebas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedate_pnl.ForeColor = System.Drawing.Color.LavenderBlush;
            this.selectedate_pnl.Location = new System.Drawing.Point(33, 65);
            this.selectedate_pnl.Name = "selectedate_pnl";
            this.selectedate_pnl.Size = new System.Drawing.Size(265, 25);
            this.selectedate_pnl.TabIndex = 2;
            this.selectedate_pnl.Text = "All records on the selected date";
            // 
            // successlogin_pg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(896, 289);
            this.Controls.Add(this.date_panel);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.up_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "successlogin_pg";
            this.Text = "Form2";
            this.up_border.ResumeLayout(false);
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel up_border;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button view_all;
        private System.Windows.Forms.Panel date_panel;
        private System.Windows.Forms.Button view_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label selectedate_pnl;
    }
}