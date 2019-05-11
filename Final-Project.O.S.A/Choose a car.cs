using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

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
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                MessageBox.Show("Please check one of the cars not two!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Please check one of the cars not two!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                MessageBox.Show("Please check one of the cars not two!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkBox1.Checked)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[5].Value = Panel1CompanyTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[6].Value = Panel1ModelTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[7].Value = Convert.ToDouble(Panel1Price.Text.Substring(0,2));
                Form1.R1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.R1);
                Form1.R1.BringToFront();
                Form1.Instance.SidePanel.Height = Form1.Instance.button3.Height;
                Form1.Instance.SidePanel.Top = Form1.Instance.button3.Top;
            }
            else if (checkBox2.Checked)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[5].Value = Panel2CompanyTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[6].Value = Panel2ModelTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[7].Value = Panel2Price.Text;
                Form1.R1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.R1);
                Form1.R1.BringToFront();
                Form1.Instance.SidePanel.Height = Form1.Instance.button3.Height;
                Form1.Instance.SidePanel.Top = Form1.Instance.button3.Top;
            }
            else if (checkBox3.Checked)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[5].Value = Panel3CompanyTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[6].Value = Panel3ModelTextBox.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[7].Value = Panel3Price.Text;
                Form1.R1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.R1);
                Form1.R1.BringToFront();
                Form1.Instance.SidePanel.Height = Form1.Instance.button3.Height;
                Form1.Instance.SidePanel.Top = Form1.Instance.button3.Top;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarsDatabase car1 = new CarsDatabase();
                if(textBox1.Text == car1.dataGridView1.Rows[0].Cells[0].Value.ToString())
                {
                    Panel1CompanyTextBox.Text = car1.dataGridView1.Rows[0].Cells[0].Value.ToString();
                    Panel1ModelTextBox.Text = car1.dataGridView1.Rows[0].Cells[1].Value.ToString();
                    Panel1Price.Text = car1.dataGridView1.Rows[0].Cells[2].Value.ToString();
                    Panel1PictureBox.Image = (Image)car1.dataGridView1.Rows[0].Cells[3].Value;
                ////////////////////////////////////////////////////////////////////////////////////////
                    Panel2CompanyTextBox.Text = car1.dataGridView1.Rows[1].Cells[0].Value.ToString();
                    Panel2ModelTextBox.Text = car1.dataGridView1.Rows[1].Cells[1].Value.ToString();
                    Panel2Price.Text = car1.dataGridView1.Rows[1].Cells[2].Value.ToString();
                    Panel2PictureBox.Image = (Image)car1.dataGridView1.Rows[1].Cells[3].Value; ;
                /////////////////////////////////////////////////////////////////////////////////////////
                    Panel3CompanyTextBox.Text = car1.dataGridView1.Rows[2].Cells[0].Value.ToString();
                    Panel3ModelTextBox.Text = car1.dataGridView1.Rows[2].Cells[1].Value.ToString();
                    Panel3Price.Text = car1.dataGridView1.Rows[2].Cells[2].Value.ToString();
                    Panel3PictureBox.Image = (Image)car1.dataGridView1.Rows[2].Cells[3].Value;
                }
            else if (textBox1.Text == car1.dataGridView1.Rows[3].Cells[0].Value.ToString())
            {
                Panel1CompanyTextBox.Text = car1.dataGridView1.Rows[3].Cells[0].Value.ToString();
                Panel1ModelTextBox.Text = car1.dataGridView1.Rows[3].Cells[1].Value.ToString();
                Panel1Price.Text = car1.dataGridView1.Rows[3].Cells[2].Value.ToString();
                Panel1PictureBox.Image = (Image)car1.dataGridView1.Rows[3].Cells[3].Value;
                ////////////////////////////////////////////////////////////////////////////////////////
                Panel2CompanyTextBox.Text = car1.dataGridView1.Rows[4].Cells[0].Value.ToString();
                Panel2ModelTextBox.Text = car1.dataGridView1.Rows[4].Cells[1].Value.ToString();
                Panel2Price.Text = car1.dataGridView1.Rows[4].Cells[2].Value.ToString();
                Panel2PictureBox.Image = (Image)car1.dataGridView1.Rows[4].Cells[3].Value; ;
                /////////////////////////////////////////////////////////////////////////////////////////
                Panel3CompanyTextBox.Text = car1.dataGridView1.Rows[5].Cells[0].Value.ToString();
                Panel3ModelTextBox.Text = car1.dataGridView1.Rows[5].Cells[1].Value.ToString();
                Panel3Price.Text = car1.dataGridView1.Rows[5].Cells[2].Value.ToString();
                Panel3PictureBox.Image = (Image)car1.dataGridView1.Rows[5].Cells[3].Value;
            }
            else if (textBox1.Text == car1.dataGridView1.Rows[6].Cells[0].Value.ToString())
            {
                Panel1CompanyTextBox.Text = car1.dataGridView1.Rows[6].Cells[0].Value.ToString();
                Panel1ModelTextBox.Text = car1.dataGridView1.Rows[6].Cells[1].Value.ToString();
                Panel1Price.Text = car1.dataGridView1.Rows[6].Cells[2].Value.ToString();
                Panel1PictureBox.Image = (Image)car1.dataGridView1.Rows[6].Cells[3].Value;
                ////////////////////////////////////////////////////////////////////////////////////////
                Panel2CompanyTextBox.Text = car1.dataGridView1.Rows[7].Cells[0].Value.ToString();
                Panel2ModelTextBox.Text = car1.dataGridView1.Rows[7].Cells[1].Value.ToString();
                Panel2Price.Text = car1.dataGridView1.Rows[7].Cells[2].Value.ToString();
                Panel2PictureBox.Image = (Image)car1.dataGridView1.Rows[7].Cells[3].Value; ;
                /////////////////////////////////////////////////////////////////////////////////////////
                Panel3CompanyTextBox.Text = car1.dataGridView1.Rows[8].Cells[0].Value.ToString();
                Panel3ModelTextBox.Text = car1.dataGridView1.Rows[8].Cells[1].Value.ToString();
                Panel3Price.Text = car1.dataGridView1.Rows[8].Cells[2].Value.ToString();
                Panel3PictureBox.Image = (Image)car1.dataGridView1.Rows[8].Cells[3].Value;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Choose_a_car_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Mercedes";
        }
    }
}
