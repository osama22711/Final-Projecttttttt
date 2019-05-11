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
                Form1.Confirm1.Dock = DockStyle.Fill;
                Form1.Instance.MMPanel.Controls.Add(Form1.Confirm1);
                Form1.Confirm1.BringToFront();
            }
        }
    }
}
