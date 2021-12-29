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
    public partial class T_Spis_oborud : Form
    {
        public T_Spis_oborud()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authorization_all f = new Authorization_all();
            this.Hide();
            f.ShowDialog();
        }
    }
}
