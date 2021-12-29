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
    public partial class otchety : Form
    {
        public otchety()
        {
            InitializeComponent();
        }

        private void otchety_Load(object sender, EventArgs e)
        {
            db DB = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM otchety ", DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            otobraz.DataSource = table;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            tables tables = new tables();
            tables.Show();
        }
    }
}
