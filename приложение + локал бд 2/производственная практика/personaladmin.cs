using MySql.Data.MySqlClient;
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
    public partial class personaladmin : Form
    {
        public personaladmin()
        {
            InitializeComponent();
        }

        private void personaladmin_Load(object sender, EventArgs e)
        {
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM personal ", DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            db DB = new db();
            try
            {
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("update personal set FIO = @fio, dolznost = @post where id_rsbotnika = @id", DB.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idsk.Text;
                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = post.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = data.Text;

                MySqlDataReader MyReader2;
                DB.openConnection();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                DB.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  // Редактирование данных
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command2 = new MySqlCommand("Select * From personal ", DB.GetConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < otobraz.RowCount; i++)
            {
                otobraz.Rows[i].Selected = false;
                for (int j = 0; j < otobraz.ColumnCount; j++)
                    if (otobraz.Rows[i].Cells[j].Value != null)
                        if
                       (otobraz.Rows[i].Cells[j].Value.ToString().Contains(idseasrch.Text))
                        {
                            otobraz.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            {//Проверка на наличие незаполненных полей
                if (iddel.Text == "")
                {
                    MessageBox.Show("Заполните поле ID.");
                    return;
                }
                db DB = new db();
                try
                {
                    // Формирование запроса
                    MySqlCommand command = new MySqlCommand("DELETE FROM personal WHERE id_rsbotnika=@nomerpost", DB.GetConnection());
                    command.Parameters.Add("@nomerpost", MySqlDbType.Int32).Value = iddel.Text;
                    MySqlDataReader MyReader2;
                    DB.openConnection();
                    MyReader2 = command.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    DB.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }      // Удаление данных
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                // Формирование запроса
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM personal ", DB.GetConnection());

                adapter.SelectCommand = command2;
                adapter.Fill(table);
                otobraz.DataSource = table;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin admin = new admin();
            admin.Show();
        }
    }
}
