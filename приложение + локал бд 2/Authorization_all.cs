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
    public partial class Authorization_all : Form
    {
        public Authorization_all()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GL_menu_adm f = new GL_menu_adm ();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authorization_user f = new Authorization_user();
            this.Hide();
            f.ShowDialog();
        }
    }
}
