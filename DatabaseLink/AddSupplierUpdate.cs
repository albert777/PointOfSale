using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DatabaseLink
{
    public class AddSupplierUpdate
    {
        // Used to retrieve the content of textBox
        public string SupID, CSname, CFname, CompName, CompAddr, /*CTitle,*/ gender, Mstatus, email, Addr, Phone;


        // Connecting to Database
        //DBConnect dbcon = new DBConnect();

        // Method for Inserting textBox values to Database
        public void InsertSupplier()
        {
           ConnectDB.ConnDB();
           ConnectDB.cmd = new MySqlCommand("AddSupplier", ConnectDB.con); // AddEmpoyee is a StoredProcedure database called via this connection
            //MySqlDataReader reader;

            //dbcon.con.Open();
           ConnectDB.cmd.Parameters.Add("SupID", MySqlDbType.String).Value = SupID;
           ConnectDB.cmd.Parameters.Add("CompName", MySqlDbType.String).Value = CompName;
           ConnectDB.cmd.Parameters.Add("CSname", MySqlDbType.String).Value = CSname;
           ConnectDB.cmd.Parameters.Add("CFname", MySqlDbType.String).Value = CFname;
           ConnectDB.cmd.Parameters.Add("CompAddr", MySqlDbType.String).Value = CompAddr;
            //com.Parameters.Add("CTitle", MySqlDbType.String).Value = CTitle;
           ConnectDB.cmd.Parameters.Add("gender", MySqlDbType.String).Value = gender;
           ConnectDB.cmd.Parameters.Add("Mstatus", MySqlDbType.String).Value = Mstatus;
           ConnectDB.cmd.Parameters.Add("addr", MySqlDbType.String).Value = Addr;
           ConnectDB.cmd.Parameters.Add("email", MySqlDbType.String).Value = email;
           ConnectDB.cmd.Parameters.Add("Phone", MySqlDbType.String).Value = Phone;

           ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

           ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
           while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }

        // Method for Updating employee data in database via the 'UpdateEmployee' storedProcedure
        public void UpdateSupplier()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("UpdateSupplier", ConnectDB.con);
            //MySqlDataReader reader;

            //dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("SupID", MySqlDbType.String).Value = SupID;
            ConnectDB.cmd.Parameters.Add("CompName", MySqlDbType.String).Value = CompName;
            ConnectDB.cmd.Parameters.Add("CSname", MySqlDbType.String).Value = CSname;
            ConnectDB.cmd.Parameters.Add("CFname", MySqlDbType.String).Value = CFname;
            ConnectDB.cmd.Parameters.Add("CompAddr", MySqlDbType.String).Value = CompAddr;
            //com.Parameters.Add("CTitle", MySqlDbType.String).Value = CTitle;
            ConnectDB.cmd.Parameters.Add("gender", MySqlDbType.String).Value = gender;
            ConnectDB.cmd.Parameters.Add("Mstatus", MySqlDbType.String).Value = Mstatus;
            ConnectDB.cmd.Parameters.Add("addr", MySqlDbType.String).Value = Addr;
            ConnectDB.cmd.Parameters.Add("email", MySqlDbType.String).Value = email;
            ConnectDB.cmd.Parameters.Add("Phone", MySqlDbType.String).Value = Phone;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }

        public void DeleteSupplier()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("DeleteSupplier", ConnectDB.con);
            //MySqlDataReader reader;

            //dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("SupID", MySqlDbType.String).Value = SupID;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }
    }
}
