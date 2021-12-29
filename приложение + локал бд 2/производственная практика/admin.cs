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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void inventary_Click(object sender, EventArgs e)
        {
            this.Hide();
            invetryadmin invetryadmin = new invetryadmin();
            invetryadmin.Show();
        }

        private void personal_Click(object sender, EventArgs e)
        {
            this.Hide();
            personaladmin personaladmin = new personaladmin();
            personaladmin.Show();
        }

        private void otchety_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminotch adminotch = new adminotch();
            adminotch.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void sklady_Click(object sender, EventArgs e)
        {
            this.Hide();
            skladadmin skladadmin = new skladadmin();
            skladadmin.Show();
        }
    }
}
