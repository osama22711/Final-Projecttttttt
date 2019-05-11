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
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();
        }

        private void InfoFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            if (InfoFname.Text == "" || InfoLName.Text == "" || InfoEmail.Text == "" || InfoExpireMonth.Text == "" || InfoExpireYear.Text == "" || InfoCardNumber.Text == "" || InfoCardType.Text == "")
            {
                MessageBox.Show("Please enter all your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(InformationCheckbox.Checked==false)
            {
                MessageBox.Show("Please read the policies", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1.User1.dataGridView1.Rows[0].Cells[0].Value = InfoFname.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[1].Value = InfoLName.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[2].Value = InfoEmail.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[9].Value = InfoCardType.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[10].Value = InfoCardNumber.Text;
                Form1.User1.dataGridView1.Rows[0].Cells[11].Value += InfoExpireMonth.Text + " / ";
                Form1.User1.dataGridView1.Rows[0].Cells[11].Value += InfoExpireYear.Text;
                Form1.Confirm1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.Confirm1);
                Form1.Confirm1.BringToFront();
                Form1.Instance.SidePanel.Height = Form1.Instance.button5.Height;
                Form1.Instance.SidePanel.Top = Form1.Instance.button5.Top;
            }
        }
    }
}
