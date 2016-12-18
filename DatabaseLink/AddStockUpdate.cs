using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DatabaseLink
{
    public class AddStockUpdate
    {
        public string ProdID, ProdName, ProdDesc, CatID, SupID, Uprice;
        public int Quant;

        public void InsertNewStock()
        { 
            //Connecting to the database accessing the stored procedure.
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("AddStocks", ConnectDB.con);

            ConnectDB.cmd.Parameters.Add("ProdID", MySqlDbType.String).Value = ProdID;
            ConnectDB.cmd.Parameters.Add("Pname", MySqlDbType.String).Value = ProdName;
            ConnectDB.cmd.Parameters.Add("Pdescr", MySqlDbType.String).Value = ProdDesc;
            ConnectDB.cmd.Parameters.Add("SupID", MySqlDbType.String).Value = SupID;
            ConnectDB.cmd.Parameters.Add("CatID", MySqlDbType.String).Value = CatID;
            ConnectDB.cmd.Parameters.Add("Quant", MySqlDbType.Int32).Value = Quant;
            ConnectDB.cmd.Parameters.Add("Uprice", MySqlDbType.String).Value = Uprice;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }

        }

        public void UpdateStock()
        {

            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("UpdateStocksByNewStock", ConnectDB.con);

            ConnectDB.cmd.Parameters.Add("ProdID", MySqlDbType.String).Value = ProdID;
            ConnectDB.cmd.Parameters.Add("Pname", MySqlDbType.String).Value = ProdName;
            ConnectDB.cmd.Parameters.Add("Pdescr", MySqlDbType.String).Value = ProdDesc;
            ConnectDB.cmd.Parameters.Add("SupID", MySqlDbType.String).Value = SupID;
            ConnectDB.cmd.Parameters.Add("CatID", MySqlDbType.String).Value = CatID;
            ConnectDB.cmd.Parameters.Add("Quant", MySqlDbType.Int32).Value = Quant;
            ConnectDB.cmd.Parameters.Add("Uprice", MySqlDbType.String).Value = Uprice;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
 
        }

        public void UpdateStockWithQuantityAfterSale()
        {

            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("UpdateStocksByQuantAfterSale", ConnectDB.con);

            ConnectDB.cmd.Parameters.Add("ProdName", MySqlDbType.String).Value = ProdName;
            ConnectDB.cmd.Parameters.Add("Quant", MySqlDbType.Int32).Value = Quant;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }

        }
    }
}
