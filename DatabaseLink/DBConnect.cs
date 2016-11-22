using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseLink
{
    class DBConnect
    {
        public MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Database=emanixbis;username=root;password=ekedie");
    }
}
