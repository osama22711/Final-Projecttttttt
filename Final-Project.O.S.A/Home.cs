﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.O.S.A
{
    public partial class Home : UserControl 
    {
        private static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Home();
                return _obj;
            }
        }
        public Home()
        {
            InitializeComponent();
            ReturnLabel.Hide();
            ReturnDatePicker.Hide();
            ReturnDateLabel.Hide();
            ReturnComboBox.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //make checkbox when checked remove the other date time picker and location picker
            if(AnotherLocCheckbox.Checked==true)
            {
                ReturnLabel.Show();
                ReturnDatePicker.Show();
                ReturnDateLabel.Show();
                ReturnComboBox.Show();
            }
            else
            {
                ReturnLabel.Hide();
                ReturnDatePicker.Hide();
                ReturnDateLabel.Hide();
                ReturnComboBox.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ReturnDatePicker.MinDate = DateTime.Now.Date;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PickupDatePicker.MinDate = DateTime.Now.Date;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void btn_Click(object sender, EventArgs e)
        {
            if (PickupComboBox.Text == "")
            {
                MessageBox.Show("Please enter all your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Choose a car"))
            {
                Choose_a_car c1 = new Choose_a_car();
                c1.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(c1);
            }
            Form1.Instance.PnlContainer.Controls["Choose a car"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (PickupComboBox.Text == "")
            {
                MessageBox.Show("Please enter all your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1.User1.dataGridView1.Rows.Add(1);
                Form1.User1.dataGridView1.Rows[0].Cells[3].Value = PickupComboBox.Text;
                if(AnotherLocCheckbox.Checked==true)
                {
                    Form1.User1.dataGridView1.Rows[0].Cells[4].Value = ReturnComboBox.Text;
                }
                else
                {
                    Form1.User1.dataGridView1.Rows[0].Cells[4].Value = PickupComboBox.Text;
                }
                Form1.c1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.c1);
                Form1.c1.BringToFront();
                Form1.Instance.SidePanel.Height = Form1.Instance.button2.Height;
                Form1.Instance.SidePanel.Top = Form1.Instance.button2.Top;
            }
        }
    }
}
//dasda
