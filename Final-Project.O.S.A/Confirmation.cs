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
        }
    }
}
