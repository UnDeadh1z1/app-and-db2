using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Menu_tabl : Form
    {
        public Menu_tabl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authorization_all f = new Authorization_all();
            this.Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            T_Oborudovanie f = new T_Oborudovanie();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_Spis_oborud f = new T_Spis_oborud ();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_Lekcionnie_auditorii f = new T_Lekcionnie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T_Potochnie_auditorii f = new T_Potochnie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            T_Computernie_auditorii f = new T_Computernie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            T_Prikhodnaya_nakladnaya f = new T_Prikhodnaya_nakladnaya();
            this.Hide();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            T_Sod_prikhodnoy_nakladnoy f = new T_Sod_prikhodnoy_nakladnoy();
            this.Hide();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            T_Raskhodnaya_nakladnaya f = new T_Raskhodnaya_nakladnaya();
            this.Hide();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            T_Sod_raskhodnoy_nakladnoy f = new T_Sod_raskhodnoy_nakladnoy();
            this.Hide();
            f.ShowDialog();
        }
    }
}
