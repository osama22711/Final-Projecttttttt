using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.O.S.A
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Home h1 = new Home();
        public static Choose_a_car c1 = new Choose_a_car();
        public static Information I1 = new Information();
        public static Confirmation Confirm1 = new Confirmation();
        public static Rental_Options R1 = new Rental_Options();
        public static UserDatabase User1 = new UserDatabase();
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get
            {
                return MMPanel;
            }
            set
            {
                MMPanel = value;
            }
        }
        public Button BackButton
        { get {  return btn ; }
          set { btn = value ; }
        }
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            h1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            c1.BringToFront();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            R1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            I1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            Confirm1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btn.Visible = false;
        }
        private void btn_Click_1(object sender, EventArgs e)
        {
            _obj = this;
            h1.Dock = DockStyle.Fill;
            MMPanel.Controls.Add(h1);
            h1.BringToFront();
        }
    }
}
