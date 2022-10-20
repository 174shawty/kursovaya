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
        MySqlConnection con = new MySqlConnection("host=caseum.chuc.ru;port=33333;user=st_3_20_24;password=20270681;database=is_3_20_st24_KURS");
        
    }

}
