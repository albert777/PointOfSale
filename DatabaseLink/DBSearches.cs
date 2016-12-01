using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DatabaseLink
{
    public class DBSearches
    {
        public string KeyWrd = string.Empty;

        //DBConnect cn = new DBConnect();
        DataTable dTable = new DataTable();
        // Searches employee table in database based on the search key provided by user
        public DataTable SearchEmployee()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchEmployee", ConnectDB.con);
            ConnectDB.cmd.Parameters.Add("KeyWrd", MySqlDbType.String).Value = KeyWrd;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;
            ConnectDB.dAdapter = new MySqlDataAdapter(ConnectDB.cmd);
            ConnectDB.dAdapter.Fill(dTable);
            return dTable;
        }



        public DataTable SearchSuppliers()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchSuppliers", ConnectDB.con);
            ConnectDB.cmd.Parameters.Add("KeyWrd", MySqlDbType.String).Value = KeyWrd;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;
            ConnectDB.dAdapter = new MySqlDataAdapter(ConnectDB.cmd);
            ConnectDB.dAdapter.Fill(dTable);
            return dTable;
        }


        public DataTable SearchStocks()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchStocks", ConnectDB.con);
            ConnectDB.cmd.Parameters.Add("KeyWrd", MySqlDbType.String).Value = KeyWrd;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;
            ConnectDB.dAdapter = new MySqlDataAdapter(ConnectDB.cmd);
            ConnectDB.dAdapter.Fill(dTable);
            return dTable;
        }

        public DataTable SearchStocksWithProdID()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchStocksWithProdID", ConnectDB.con);
            ConnectDB.cmd.Parameters.Add("ProdID", MySqlDbType.String).Value = KeyWrd;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;
            ConnectDB.dAdapter = new MySqlDataAdapter(ConnectDB.cmd);
            ConnectDB.dAdapter.Fill(dTable);
            return dTable;
        }

    }
}
