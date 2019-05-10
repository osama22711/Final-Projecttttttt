namespace Final_Project.O.S.A
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.PickupComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PickupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.ReturnComboBox = new System.Windows.Forms.ComboBox();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.AnotherLocCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(52, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pickup Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PickupComboBox
            // 
            this.PickupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickupComboBox.FormattingEnabled = true;
            this.PickupComboBox.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "Damascus",
            "Cairo",
            "Baghdad"});
            this.PickupComboBox.Location = new System.Drawing.Point(242, 151);
            this.PickupComboBox.Name = "PickupComboBox";
            this.PickupComboBox.Size = new System.Drawing.Size(121, 21);
            this.PickupComboBox.TabIndex = 1;
            this.PickupComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(406, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PickupDatePicker
            // 
            this.PickupDatePicker.Location = new System.Drawing.Point(489, 151);
            this.PickupDatePicker.MinDate = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            this.PickupDatePicker.Name = "PickupDatePicker";
            this.PickupDatePicker.Size = new System.Drawing.Size(200, 20);
            this.PickupDatePicker.TabIndex = 3;
            this.PickupDatePicker.Value = new System.DateTime(2019, 5, 9, 17, 4, 16, 0);
            this.PickupDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Location = new System.Drawing.Point(489, 298);
            this.ReturnDatePicker.MinDate = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDatePicker.TabIndex = 7;
            this.ReturnDatePicker.Value = new System.DateTime(2019, 5, 9, 17, 4, 16, 0);
            this.ReturnDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ReturnDateLabel.Location = new System.Drawing.Point(406, 295);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(60, 24);
            this.ReturnDateLabel.TabIndex = 6;
            this.ReturnDateLabel.Text = "Date";
            this.ReturnDateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ReturnComboBox
            // 
            this.ReturnComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnComboBox.FormattingEnabled = true;
            this.ReturnComboBox.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara",
            "Damascus",
            "Cairo",
            "Baghdad"});
            this.ReturnComboBox.Location = new System.Drawing.Point(242, 298);
            this.ReturnComboBox.Name = "ReturnComboBox";
            this.ReturnComboBox.Size = new System.Drawing.Size(121, 21);
            this.ReturnComboBox.TabIndex = 5;
            this.ReturnComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.Font = new System.Drawing.Font("29LT Bukra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ReturnLabel.Location = new System.Drawing.Point(52, 295);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(176, 24);
            this.ReturnLabel.TabIndex = 4;
            this.ReturnLabel.Text = "Return Location";
            this.ReturnLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // AnotherLocCheckbox
            // 
            this.AnotherLocCheckbox.AutoSize = true;
            this.AnotherLocCheckbox.Font = new System.Drawing.Font("29LT Bukra Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherLocCheckbox.ForeColor = System.Drawing.Color.Black;
            this.AnotherLocCheckbox.Location = new System.Drawing.Point(286, 225);
            this.AnotherLocCheckbox.Name = "AnotherLocCheckbox";
            this.AnotherLocCheckbox.Size = new System.Drawing.Size(200, 20);
            this.AnotherLocCheckbox.TabIndex = 8;
            this.AnotherLocCheckbox.Text = "Return to another location";
            this.AnotherLocCheckbox.UseVisualStyleBackColor = true;
            this.AnotherLocCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("29LT Bukra Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select My Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("29LT Bukra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(327, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Home";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(407, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "___________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(152, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "___________________________";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnotherLocCheckbox);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.ReturnComboBox);
            this.Controls.Add(this.ReturnLabel);
            this.Controls.Add(this.PickupDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PickupComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(748, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PickupComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PickupDatePicker;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.ComboBox ReturnComboBox;
        private System.Windows.Forms.Label ReturnLabel;
        private System.Windows.Forms.CheckBox AnotherLocCheckbox;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
