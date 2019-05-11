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
    public partial class Confirmation : UserControl
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We Will be sending you an email!");
            Form1.h1.BringToFront();
            Form1.Instance.SidePanel.Height = Form1.Instance.button1.Height;
            Form1.Instance.SidePanel.Top = Form1.Instance.button1.Top;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            ConfirmFname.Text = Form1.User1.dataGridView1.Rows[0].Cells[0].Value.ToString();
            ConfirmLname.Text = Form1.User1.dataGridView1.Rows[0].Cells[1].Value.ToString();
            ConfirmEmail.Text = Form1.User1.dataGridView1.Rows[0].Cells[2].Value.ToString();
            ConfirmPickup.Text = Form1.User1.dataGridView1.Rows[0].Cells[3].Value.ToString();
            ConfirmReturn.Text = Form1.User1.dataGridView1.Rows[0].Cells[4].Value.ToString();
            ConfirmCarCompany.Text = Form1.User1.dataGridView1.Rows[0].Cells[5].Value.ToString();
            ConfirmCarModel.Text = Form1.User1.dataGridView1.Rows[0].Cells[6].Value.ToString();
            //////// Make total Price ///////////////////////////////////////////////////
            ConfirmCardType.Text = Form1.User1.dataGridView1.Rows[0].Cells[9].Value.ToString();
            ConfirmCardNumber.Text = Form1.User1.dataGridView1.Rows[0].Cells[10].Value.ToString();
            ConfirmExp.Text = Form1.User1.dataGridView1.Rows[0].Cells[11].Value.ToString();
            LabelPrice.Text = Form1.User1.dataGridView1.Rows[0].Cells[7].Value.ToString();
            ConfirmRentalOptions.Text = Form1.User1.dataGridView1.Rows[0].Cells[8].Value.ToString();
            ConfirmRentalPrice.Text = Form1.User1.dataGridView1.Rows[0].Cells[12].Value.ToString();
            if(ConfirmCarCompany.Text=="BMW")
            {
                CarsDatabase car1 = new CarsDatabase();
                if(ConfirmCarModel.Text=="X3")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[0].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "M4")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[1].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "C5")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[2].Cells[3].Value;
                }
            }
            else if (ConfirmCarCompany.Text == "Mercedes")
            {
                CarsDatabase car1 = new CarsDatabase();
                if (ConfirmCarModel.Text == "GLC")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[3].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "AMG-S")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[4].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "AMG")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[5].Cells[3].Value;
                }
            }
            else if (ConfirmCarCompany.Text == "Ford")
            {
                CarsDatabase car1 = new CarsDatabase();
                if (ConfirmCarModel.Text == "Eco-Sport")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[6].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "Focus-8")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[7].Cells[3].Value;
                }
                else if (ConfirmCarModel.Text == "Fusion-1")
                {
                    ConfirmPicture.Image = (Image)car1.dataGridView1.Rows[8].Cells[3].Value;
                }
            }
        }

        private void LabelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
