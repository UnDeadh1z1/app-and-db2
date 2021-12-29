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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void singup_Click(object sender, EventArgs e)
        {
            if (avtlog.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (avtpas.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            string login = avtlog.Text;
            string password = avtpas.Text;

            db DB = new db();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM personal WHERE log = @userlogin AND pas = @userpassword", DB.GetConnection());

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            { 
                MessageBox.Show("Вы авторизоывались");
            this.Hide();
            tables tables = new tables();
            tables.Show();
        }
            else
                MessageBox.Show("Вы не вошли");

           
        }

        private void zareg_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg reg= new reg();
            reg.Show();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admintables admintables = new admintables();
            admintables.Show();
        }
    }
}
