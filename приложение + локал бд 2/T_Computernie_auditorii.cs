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
    public partial class T_Computernie_auditorii : Form
    {

        public T_Computernie_auditorii()
        {
            InitializeComponent();

            InitializeComponent();

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
            string queryselect = "SELECT*FROM Computernie_auditorii";

            SqlCommand command = new SqlCommand(queryselect, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            //цикл считывания данных с БД в программу 
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
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
            Add_Computernie_auditorii f = new Add_Computernie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        /*==========================================
          |         КНОПКА ИЗМЕНЕНИЯ ДАННЫХ        |
          ==========================================*/
        private void button2_Click(object sender, EventArgs e)
        {
            Upd_Computernie_auditorii f = new Upd_Computernie_auditorii();
            this.Hide();
            f.ShowDialog();
        }

        /*==========================================
          |         КНОПКА УДАЛЕНИЯ ДАННЫХ         |
          ==========================================*/
        private void button3_Click(object sender, EventArgs e)
        {
            Del_Computernie_auditorii f = new Del_Computernie_auditorii();
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
