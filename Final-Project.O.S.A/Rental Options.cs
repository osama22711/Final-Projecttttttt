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
            Form1.I1.Dock = DockStyle.Fill;
            Form1.Instance.MMPanel.Controls.Add(Form1.I1);
            Form1.I1.BringToFront();
        }
    }
}
