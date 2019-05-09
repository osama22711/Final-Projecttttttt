namespace Final_Project.O.S.A
{
    partial class Choose_a_car
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
            this.home1 = new Final_Project.O.S.A.Home();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(256, 118);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(8, 8);
            this.home1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(95, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "___________________________";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(438, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "___________________________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("29LT Bukra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(275, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose a car";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Choose_a_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.home1);
            this.Name = "Choose_a_car";
            this.Size = new System.Drawing.Size(748, 536);
            this.Load += new System.EventHandler(this.Choose_a_car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Home home1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
