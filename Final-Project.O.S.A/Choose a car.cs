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
    public partial class Choose_a_car : UserControl
    {
        public Choose_a_car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==false&&checkBox2.Checked==false&&checkBox3.Checked==false)
            {
                MessageBox.Show("Please check one of the cars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarsDatabase car1 = new CarsDatabase();
            for (int i = 0; i < 8; i++)
            {
                if(textBox1.Text == car1.dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    Panel1CompanyTextBox.Text = car1.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Panel1ModelTextBox.Text = car1.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    Panel1PictureBox.Image = (System.Drawing.Image)car1.dataGridView1.Rows[i].Cells[2].Value;
                }
            }
        }
    }
}
