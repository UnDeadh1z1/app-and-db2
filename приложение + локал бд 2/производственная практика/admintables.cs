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
    public partial class admintables : Form
    {
        public admintables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (adminlog.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (adminpass.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            string login = adminlog.Text;
            string password = adminpass.Text;
            string dolz = "admin";

            db DB = new db();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM personal WHERE log = @userlogin AND pas = @userpassword AND dolznost = @dolznost", DB.GetConnection());

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@dolznost", MySqlDbType.VarChar).Value = dolz;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизоывались");
                this.Hide();
                admin admin = new admin();
                admin.Show();
            }
            else
                MessageBox.Show("Вы не вошли");


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
