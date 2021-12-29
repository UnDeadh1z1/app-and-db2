using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Add_Computernie_auditorii : Form
    {
        public Add_Computernie_auditorii()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /*==========================================
          |        КНОПКА ДОБАВЛЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""||textBox3.Text=="")
            {
                MessageBox.Show("Введите данные, пожалуйста");
            }
            else
            {
                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TSO;Integrated Security=true;";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                SqlCommand sqlins = new SqlCommand("INSERT INTO Computernie_auditorii (caud_nom_aud, caud_inv_nom, caud_tip, caud_prim) VALUES (@caud_nom_aud,@caud_inv_nom,@caud_tip,@caud_prim)", myConnection);

                sqlins.Parameters.Add("@caud_nom_aud", int.Parse(textBox1.Text));
                sqlins.Parameters.Add("@caud_inv_nom", textBox2.Text);
                sqlins.Parameters.Add("@caud_tip", textBox3.Text);
                sqlins.Parameters.Add("@caud_prim", textBox4.Text);

                sqlins.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены в БД");
            }
        }

        /*==========================================
          |        КНОПКА ПРОСМОТРА ДАННЫХ         |
          ==========================================*/
        private void button2_Click(object sender, EventArgs e)
        {
            T_Computernie_auditorii f = new T_Computernie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        /*==========================================
          |             КНОПКА  ВЫХОДА             |
          ==========================================*/
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Authorization_all f = new Authorization_all();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
