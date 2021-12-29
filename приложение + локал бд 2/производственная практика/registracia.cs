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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void zareg_Click(object sender, EventArgs e)
        {
            if (zaregfio.Text == "")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (zaregid.Text == "")
            {
                MessageBox.Show("Введите ID");
                return;
            }
            if (zaregdolz.Text == "")
            {
                MessageBox.Show("Введите вашу должность");
                return;
            }
            if (zareglog.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (zaregpas.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (zaregpas.Text != repitpas.Text)
            {
                MessageBox.Show("Вы повторили пароль не верно");
                return;
            }


            if (zaregpas.Text == zareglog.Text)
            {
                MessageBox.Show("Ошибка - Логин не может быть равень паролю");
                zareglog.Text = "";
                zaregpas.Text = "";
                return;

            }
            {
                if (zaregpas.MaxLength < 20 && zareglog.MaxLength < 20)
                {
                    MessageBox.Show("Ошибка - Логин или пароль больше 20 символов");
                    zareglog.Text = "";
                    zaregpas.Text = "";
                    return;
                }
                {
                    if (zaregpas.Text.Length < 5 && zareglog.Text.Length < 5)
                    {
                        MessageBox.Show("Ошибка - Логин или пароль меньше 5 символов");
                        zareglog.Text = "";
                        zaregpas.Text = "";
                        return;
                    }
                    {
                        int p = 0;
                        for (int i = 0; i < zaregpas.Text.Length; i++)
                        {
                            if (char.IsLower(zaregpas.Text[i]))
                            {
                                p = 1;
                            }
                        }
                        if (p == 0)
                        {
                            MessageBox.Show("Должна быть хоть одна маленькая буква");
                            zareglog.Text = "";
                            zaregpas.Text = "";
                            return;
                        }
                        {
                            int l = 0;
                            for (int i = 0; i < zaregpas.Text.Length; i++)
                            {
                                if (char.IsUpper(zaregpas.Text[i]))
                                {
                                    l = 1;
                                }
                            }
                            if (l == 0)
                            {
                                MessageBox.Show("Должна быть хоть одна заглавная буква");
                                zareglog.Text = "";
                                zaregpas.Text = "";
                                return;
                            }
                        }
                    }
                }
            }

        
        
        if (checkUser())
                return;

            db DB = new db();
            MySqlCommand command = new MySqlCommand ("INSERT INTO personal (id_rsbotnika, FIO, dolznost, log, pas ) VALUES (@id, @fio, @dolz, @login, @pass)", DB.GetConnection());
            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = zaregfio.Text;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = zaregid.Text;
            command.Parameters.Add("@dolz", MySqlDbType.VarChar).Value = zaregdolz.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = zareglog.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = zaregpas.Text;

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
            }
            else
                MessageBox.Show("Аккаунт не создан");

            DB.closeConnection();

            

           
        }
        public Boolean checkUser()
        {
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM personal WHERE  id_rsbotnika = @id", DB.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = zaregid.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)

            {
                MessageBox.Show("Данный ID уже занят");
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
