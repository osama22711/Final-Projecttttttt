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
    public partial class CarsDatabase : UserControl
    {
        public CarsDatabase()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///////////////////////////////////////////////////////////////////
            //BMW S ///////////// ////////// //////////////// ///////////// ///
            ///////////////////////////////////////////////////////////////////
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[0].Cells[0].Value = "BMW";
            dataGridView1.Rows[0].Cells[1].Value = "X3";
            dataGridView1.Rows[0].Cells[2].Value = "50$/Day";
            dataGridView1.Rows[0].Cells[3].Value = Properties.Resources.BMW_x3;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[1].Cells[0].Value = "BMW";
            dataGridView1.Rows[1].Cells[1].Value = "M4";
            dataGridView1.Rows[1].Cells[2].Value = "40$/Day";
            dataGridView1.Rows[1].Cells[3].Value = Properties.Resources.BMW_m4;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[2].Cells[0].Value = "BMW";
            dataGridView1.Rows[2].Cells[1].Value = "C5";
            dataGridView1.Rows[2].Cells[2].Value = "35$/Day";
            dataGridView1.Rows[2].Cells[3].Value = Properties.Resources.BMW_c5;
            ///////////////////////////////////////////////////////////////////
            //Mercedes S // /// / // // / // / // / // / // / // / // / // / //
            ///////////////////////////////////////////////////////////////////
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[3].Cells[0].Value = "Mercedes";
            dataGridView1.Rows[3].Cells[1].Value = "GLC";
            dataGridView1.Rows[3].Cells[2].Value = "55$/Day";
            dataGridView1.Rows[3].Cells[3].Value = Properties.Resources.Mercedes_GLC;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[4].Cells[0].Value = "Mercedes";
            dataGridView1.Rows[4].Cells[1].Value = "AMG-S";
            dataGridView1.Rows[4].Cells[2].Value = "45$/Day";
            dataGridView1.Rows[4].Cells[3].Value = Properties.Resources.Mercedes_AMG_S;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[5].Cells[0].Value = "Mercedes";
            dataGridView1.Rows[5].Cells[1].Value = "AMG";
            dataGridView1.Rows[5].Cells[2].Value = "48$/Day";
            dataGridView1.Rows[5].Cells[3].Value = Properties.Resources.Mercedes_AMG;
            ///////////////////////////////////////////////////////////////////
            //Ford S //// // / // // / // / // / // // / // // // / // / // // 
            ///////////////////////////////////////////////////////////////////
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[6].Cells[0].Value = "Ford";
            dataGridView1.Rows[6].Cells[1].Value = "Eco-Sport";
            dataGridView1.Rows[6].Cells[2].Value = "59$/Day";
            dataGridView1.Rows[6].Cells[3].Value = Properties.Resources.Ford_EcoSport;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[7].Cells[0].Value = "Ford";
            dataGridView1.Rows[7].Cells[1].Value = "Focus-8";
            dataGridView1.Rows[7].Cells[2].Value = "47$/Day";
            dataGridView1.Rows[7].Cells[3].Value = Properties.Resources.Ford_Focus_8;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[8].Cells[0].Value = "Ford";
            dataGridView1.Rows[8].Cells[1].Value = "Fusion-1";
            dataGridView1.Rows[8].Cells[2].Value = "50$/Day";
            dataGridView1.Rows[8].Cells[3].Value = Properties.Resources.Ford_Fusion_1;
        }
    }
}
