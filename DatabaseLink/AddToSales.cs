using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseLink
{
    public class AddToSales
    {
        public string Staffname, ProductName; public int Quantity, Unitprice, Discount, Totalprice;
        public DateTime date;

        public void InsertNewSales()
        {
            //Connecting to the database accessing the stored procedure.
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("AddSales", ConnectDB.con);

            ConnectDB.cmd.Parameters.Add("Staffname", MySqlDbType.String).Value = Staffname;
            ConnectDB.cmd.Parameters.Add("DSold", MySqlDbType.DateTime).Value = date;
            ConnectDB.cmd.Parameters.Add("Pname", MySqlDbType.String).Value = ProductName;
            ConnectDB.cmd.Parameters.Add("Quant", MySqlDbType.Int32).Value = Quantity;
            ConnectDB.cmd.Parameters.Add("Uprice", MySqlDbType.Int32).Value = Unitprice;
            ConnectDB.cmd.Parameters.Add("discount", MySqlDbType.Int32).Value = Discount;
            ConnectDB.cmd.Parameters.Add("Tamount", MySqlDbType.Int32).Value = Totalprice;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }

        }
    }
}
