using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (PickupComboBox.Text == "")
            {
                MessageBox.Show("Please enter all your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
