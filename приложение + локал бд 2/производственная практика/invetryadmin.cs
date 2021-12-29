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
    public partial class invetryadmin : Form
    {
        public invetryadmin()
        {
            InitializeComponent();
        }

        private void invetryadmin_Load(object sender, EventArgs e)
        {
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM iventar ", DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            db DB = new db();
            try
            {   // Формирование запроса
                MySqlCommand command = new MySqlCommand("insert into iventar (id_predmeta,name_predmeta,kolvo,cena,id_rabotnika,time,id_sklada) values(@id,@name,@kol,@cen,@rab,@data,@sklad);", DB.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idsk.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = post.Text;
                command.Parameters.Add("@kol", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@cen", MySqlDbType.VarChar).Value = nomer.Text;
                command.Parameters.Add("@rab", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@data", MySqlDbType.VarChar).Value = data.Text;
                command.Parameters.Add("@sklad", MySqlDbType.VarChar).Value = textBox3.Text;

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
            MySqlCommand command2 = new MySqlCommand("Select * From iventar ", DB.GetConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db DB = new db();
            try
            {
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("update iventar set name_predmeta = @name, kolvo = @kol, cena=@cen, id_rabotnika=@rab,time=@data, id_sklada=@sklad  where id_predmeta = @id", DB.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idsk.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = post.Text;
                command.Parameters.Add("@kol", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@cen", MySqlDbType.VarChar).Value = nomer.Text;
                command.Parameters.Add("@rab", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@data", MySqlDbType.VarChar).Value = data.Text;
                command.Parameters.Add("@sklad", MySqlDbType.VarChar).Value = textBox3.Text;
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
            MySqlCommand command2 = new MySqlCommand("Select * From iventar ", DB.GetConnection());

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
                    MySqlCommand command = new MySqlCommand("DELETE FROM iventar WHERE id_predmeta=@nomer", DB.GetConnection());
                    command.Parameters.Add("@nomer", MySqlDbType.Int32).Value = iddel.Text;
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
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM iventar ", DB.GetConnection());

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
