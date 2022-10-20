using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kursovaya
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_20_24;password=20270681;database=is_3_20_st24_KURS");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection checkConnection()
        {
            return connection;
        }

    }

}
