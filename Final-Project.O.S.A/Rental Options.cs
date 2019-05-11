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
    public partial class Rental_Options : UserControl
    {
        public Rental_Options()
        {
            InitializeComponent();
        }

        private void ExtrasButton_Click(object sender, EventArgs e)
        {
            if (Extras1Checkbutton.Checked == true && Extras2Checkbutton.Checked == true && Extras3Checkbutton.Checked == true && Extras4Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " CDW - PAI - TheftProtection - Fuels plans";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras1Checkbutton.Text.Substring(1, 4))+ Convert.ToDouble(Extras2Checkbutton.Text.Substring(1,4)) + Convert.ToDouble(Extras3Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras1Checkbutton.Checked == true && Extras2Checkbutton.Checked == true && Extras3Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " CDW - PAI - TheftProtection";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras1Checkbutton.Text.Substring(1, 4)) + Convert.ToDouble(Extras2Checkbutton.Text.Substring(1, 4)) + Convert.ToDouble(Extras3Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras1Checkbutton.Checked == true && Extras2Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " CDW - PAI ";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras1Checkbutton.Text.Substring(1, 4)) + Convert.ToDouble(Extras2Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras2Checkbutton.Checked == true && Extras3Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " PAI - Theft Protection ";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras2Checkbutton.Text.Substring(1, 4)) + Convert.ToDouble(Extras3Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras1Checkbutton.Checked == true && Extras3Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " CDW - Theft Protection ";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras1Checkbutton.Text.Substring(1, 4)) + Convert.ToDouble(Extras3Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras1Checkbutton.Checked==true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " CDW -";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras1Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras2Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " PAI - ";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras2Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras3Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " Theft Protection - ";
                Form1.User1.dataGridView1.Rows[0].Cells[12].Value = Convert.ToDouble(Extras3Checkbutton.Text.Substring(1, 4));
            }
            else if (Extras4Checkbutton.Checked == true)
            {
                Form1.User1.dataGridView1.Rows[0].Cells[8].Value += " Fuels plans - ";
            }
            Form1.I1.Dock = DockStyle.Fill;
            Form1.Instance.MMPanel.Controls.Add(Form1.I1);
            Form1.I1.BringToFront();
        }

        private void Extras1Checkbutton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
