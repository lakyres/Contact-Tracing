namespace contact_tracing
{
    partial class symptoms
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
            this.fever = new System.Windows.Forms.CheckBox();
            this.runnynose = new System.Windows.Forms.CheckBox();
            this.fatigue = new System.Windows.Forms.CheckBox();
            this.shortness = new System.Windows.Forms.CheckBox();
            this.lose = new System.Windows.Forms.CheckBox();
            this.sore = new System.Windows.Forms.CheckBox();
            this.cough = new System.Windows.Forms.CheckBox();
            this.nosymp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fever
            // 
            this.fever.AutoSize = true;
            this.fever.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fever.ForeColor = System.Drawing.Color.Transparent;
            this.fever.Location = new System.Drawing.Point(96, 101);
            this.fever.Name = "fever";
            this.fever.Size = new System.Drawing.Size(77, 28);
            this.fever.TabIndex = 0;
            this.fever.Text = "Fever";
            this.fever.UseVisualStyleBackColor = true;
            this.fever.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // runnynose
            // 
            this.runnynose.AutoSize = true;
            this.runnynose.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runnynose.ForeColor = System.Drawing.Color.Transparent;
            this.runnynose.Location = new System.Drawing.Point(96, 145);
            this.runnynose.Name = "runnynose";
            this.runnynose.Size = new System.Drawing.Size(124, 28);
            this.runnynose.TabIndex = 1;
            this.runnynose.Text = "Runny nose";
            this.runnynose.UseVisualStyleBackColor = true;
            this.runnynose.CheckedChanged += new System.EventHandler(this.runnynose_CheckedChanged);
            // 
            // fatigue
            // 
            this.fatigue.AutoSize = true;
            this.fatigue.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatigue.ForeColor = System.Drawing.Color.Transparent;
            this.fatigue.Location = new System.Drawing.Point(96, 188);
            this.fatigue.Name = "fatigue";
            this.fatigue.Size = new System.Drawing.Size(93, 28);
            this.fatigue.TabIndex = 2;
            this.fatigue.Text = "Fatigue";
            this.fatigue.UseVisualStyleBackColor = true;
            this.fatigue.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // shortness
            // 
            this.shortness.AutoSize = true;
            this.shortness.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortness.ForeColor = System.Drawing.Color.White;
            this.shortness.Location = new System.Drawing.Point(96, 232);
            this.shortness.Name = "shortness";
            this.shortness.Size = new System.Drawing.Size(188, 28);
            this.shortness.TabIndex = 3;
            this.shortness.Text = "Shortness of breath";
            this.shortness.UseVisualStyleBackColor = true;
            this.shortness.CheckedChanged += new System.EventHandler(this.shortness_CheckedChanged);
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.Color.Transparent;
            this.lose.Location = new System.Drawing.Point(323, 101);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(189, 28);
            this.lose.TabIndex = 4;
            this.lose.Text = "Lose of taste/smell";
            this.lose.UseVisualStyleBackColor = true;
            this.lose.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // sore
            // 
            this.sore.AutoSize = true;
            this.sore.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sore.ForeColor = System.Drawing.Color.Transparent;
            this.sore.Location = new System.Drawing.Point(323, 145);
            this.sore.Name = "sore";
            this.sore.Size = new System.Drawing.Size(122, 28);
            this.sore.TabIndex = 5;
            this.sore.Text = "Sore throat";
            this.sore.UseVisualStyleBackColor = true;
            this.sore.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cough
            // 
            this.cough.AutoSize = true;
            this.cough.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cough.ForeColor = System.Drawing.SystemColors.Control;
            this.cough.Location = new System.Drawing.Point(323, 188);
            this.cough.Name = "cough";
            this.cough.Size = new System.Drawing.Size(83, 28);
            this.cough.TabIndex = 6;
            this.cough.Text = "Cough";
            this.cough.UseVisualStyleBackColor = true;
            this.cough.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // nosymp
            // 
            this.nosymp.AutoSize = true;
            this.nosymp.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosymp.ForeColor = System.Drawing.Color.White;
            this.nosymp.Location = new System.Drawing.Point(323, 232);
            this.nosymp.Name = "nosymp";
            this.nosymp.Size = new System.Drawing.Size(143, 28);
            this.nosymp.TabIndex = 7;
            this.nosymp.Text = "No symptoms";
            this.nosymp.UseVisualStyleBackColor = true;
            this.nosymp.CheckedChanged += new System.EventHandler(this.nosymp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Put a check if you have the given symptom/s.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // symptoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nosymp);
            this.Controls.Add(this.cough);
            this.Controls.Add(this.sore);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.shortness);
            this.Controls.Add(this.fatigue);
            this.Controls.Add(this.runnynose);
            this.Controls.Add(this.fever);
            this.Name = "symptoms";
            this.Size = new System.Drawing.Size(595, 474);
            this.Load += new System.EventHandler(this.symptoms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fever;
        private System.Windows.Forms.CheckBox runnynose;
        private System.Windows.Forms.CheckBox fatigue;
        private System.Windows.Forms.CheckBox shortness;
        private System.Windows.Forms.CheckBox lose;
        private System.Windows.Forms.CheckBox sore;
        private System.Windows.Forms.CheckBox cough;
        private System.Windows.Forms.CheckBox nosymp;
        private System.Windows.Forms.Label label1;
    }
}
