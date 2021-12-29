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
    public partial class Upd_Potochnie_auditorii : Form
    {
        public Upd_Potochnie_auditorii()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        /*==========================================
          |         КНОПКА ИЗМЕНЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Введите данные, пожалуйста");
            }
            else
            {
                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TSO;Integrated Security=true;";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                SqlCommand sqlupd = new SqlCommand("UPDATE Potochnie_auditorii SET paud_nom_aud=@paud_nom_aud, paud_inv_nom=@paud_inv_nom, paud_tip =@paud_tip  , paud_prim=@paud_prim WHERE paud_nom_aud=@paud_nom_aud", myConnection);

                sqlupd.Parameters.Add("@paud_nom_aud", int.Parse(textBox1.Text));
                sqlupd.Parameters.Add("@paud_inv_nom", textBox2.Text);
                sqlupd.Parameters.Add("@paud_tip ", textBox3.Text);
                sqlupd.Parameters.Add("@paud_prim ", textBox4.Text);

                sqlupd.ExecuteNonQuery();
                MessageBox.Show("Данные в БД изменены");
            }
        }

        /*==========================================
          |        КНОПКА ПРОСМОТРА ДАННЫХ         |
          ==========================================*/
        private void button2_Click(object sender, EventArgs e)
        {
            T_Potochnie_auditorii f = new T_Potochnie_auditorii();
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
