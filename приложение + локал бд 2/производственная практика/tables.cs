using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace производственная_практика
{
    public partial class tables : Form
    {
        public tables()
        {
            InitializeComponent();
        }

        private void inventary_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventary inventary = new inventary();
            inventary.Show();
        }

        private void otcity_Click(object sender, EventArgs e)
        {
            this.Hide();
            otchety otchety = new otchety();
            otchety.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sklady sklady = new sklady();
            sklady.Show();
        }
    }
}
