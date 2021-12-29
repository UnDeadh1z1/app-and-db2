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
    public partial class Del_Potochnie_auditorii : Form
    {
        public Del_Potochnie_auditorii()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /*==========================================
          |         КНОПКА УДАЛЕНИЯ ДАННЫХ         |
          ==========================================*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите инвентарный номер, пожалуйста");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить эту строку данных?", "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TSO;Integrated Security=true;";
                    SqlConnection myConnection = new SqlConnection(connectString);
                    myConnection.Open();

                    SqlCommand sqldel = new SqlCommand("DELETE FROM Potochnie_auditorii WHERE paud_nom_aud=@paud_nom_aud", myConnection);
                    sqldel.Parameters.AddWithValue("paud_nom_aud", textBox1.Text);

                    sqldel.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены из БД");
                }
                else
                {
                    MessageBox.Show("Данные не были удалены");
                }

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

