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
    public partial class T_Oborudovanie : Form
    {
        public T_Oborudovanie()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            LoadData();
        }

        private void LoadData()
        {
            /*==========================================
              |           ВЫВОД ДАННЫХ ИЗ БД           |
              ==========================================*/

            //cтрока соединения с БД
            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TSO;Integrated Security=true;";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            //sql запрос 
            string queryselect = "SELECT*FROM Oborudovanie";

            SqlCommand command = new SqlCommand(queryselect, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            //цикл считывания данных с БД в программу 
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            myConnection.Close();

            //вывод данных на форму
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        /*==========================================
          |        КНОПКА ДОБАВЛЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Oborudovanie f = new Add_Oborudovanie();
            this.Hide();
            f.ShowDialog();
        }

        /*==========================================
          |         КНОПКА ИЗМЕНЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button2_Click(object sender, EventArgs e)
        {
            Upd_Oborudovanie f = new Upd_Oborudovanie();
            this.Hide();
            f.ShowDialog();
        }

        /*==========================================
          |         КНОПКА УДАЛЕНИЯ ДАННЫХ         |
          ==========================================*/
        private void button3_Click(object sender, EventArgs e)
        {
            Del_Oborudovanie f = new Del_Oborudovanie();
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
