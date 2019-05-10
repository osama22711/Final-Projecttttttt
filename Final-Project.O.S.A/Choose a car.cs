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
    }
}
