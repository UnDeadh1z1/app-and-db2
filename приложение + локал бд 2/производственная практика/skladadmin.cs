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
    public partial class skladadmin : Form
    {
        public skladadmin()
        {
            InitializeComponent();
        }
        private void skladadmin_Load_1(object sender, EventArgs e)
        {
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM sklady ", DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }


        private void search_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            db DB = new db();
            try
            {   // Формирование запроса
                MySqlCommand command = new MySqlCommand("insert into sklady (id_sklada,raspoloz,vmestimost,nomer_postavki) values(@id,@postav,@data,@nomerpost);", DB.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idsk.Text;
                command.Parameters.Add("@postav", MySqlDbType.VarChar).Value = post.Text;
                command.Parameters.Add("@data", MySqlDbType.VarChar).Value = data.Text;
                command.Parameters.Add("@nomerpost", MySqlDbType.VarChar).Value = nomer.Text;

                MySqlDataReader MyReader2;
                DB.openConnection();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                DB.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   // Добавление данных
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command2 = new MySqlCommand("Select * From sklady ", DB.GetConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            db DB = new db();
            try
            {
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("update sklady set raspoloz = @id, vmestimost = @post, nomer_postavki = @data where id_sklada = @nomer", DB.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idsk.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = post.Text;
                command.Parameters.Add("@data", MySqlDbType.VarChar).Value = data.Text;
                command.Parameters.Add("@nomer", MySqlDbType.Int32).Value = nomer.Text;
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
            MySqlCommand command2 = new MySqlCommand("Select * From sklady ", DB.GetConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void del_Click_1(object sender, EventArgs e)
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
                    MySqlCommand command = new MySqlCommand("DELETE FROM sklady WHERE id_sklada=@nomerpost", DB.GetConnection());
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
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM sklady ", DB.GetConnection());

                adapter.SelectCommand = command2;
                adapter.Fill(table);
                otobraz.DataSource = table;
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin admin = new admin();
            admin.Show();
        }
    }
}
