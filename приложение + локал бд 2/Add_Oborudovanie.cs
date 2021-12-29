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
    public partial class Add_Oborudovanie : Form
    {
        public Add_Oborudovanie()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        /*==========================================
          |        КНОПКА ДОБАВЛЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите данные, пожалуйста");
            }
            else
            {
                string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TSO;Integrated Security=true;";
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                SqlCommand sqlins = new SqlCommand("INSERT INTO Oborudovanie (ob_inv_nom, ob_tip, ob_prim) VALUES (@ob_inv_nom,@ob_tip,@ob_prim)", myConnection);

                sqlins.Parameters.Add("@ob_inv_nom", int.Parse(textBox1.Text));
                sqlins.Parameters.Add("@ob_tip", textBox2.Text);
                sqlins.Parameters.Add("@ob_prim", textBox3.Text);

                sqlins.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены в БД");
            }
        }

        /*==========================================
          |        КНОПКА ПРОСМОТРА ДАННЫХ         |
          ==========================================*/
        private void button2_Click(object sender, EventArgs e)
        {
            T_Oborudovanie f = new T_Oborudovanie();
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
