using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace производственная_практика
{
    class db
    {
        MySqlConnection connection = new MySqlConnection("server =95.131.149.21 ; port= 3306; username=mtkp_tip_71_02; password=14034321; database=mtkp_tip_71_02");
        public void openConnection ()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
