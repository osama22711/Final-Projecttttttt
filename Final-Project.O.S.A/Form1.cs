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
                return MainPanel;
            }
            set
            {
                MainPanel = value;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btn.Visible = false;
            _obj = this;
            Home h1 = new Home();
            h1.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(h1);
            h1.Show();
        }
        private void btn_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls["Home"].BringToFront();
            if (!MainPanel.Controls.Contains(Home.Instance))
            {
                MainPanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
            Home.Instance.BringToFront();
        }
    }
}
