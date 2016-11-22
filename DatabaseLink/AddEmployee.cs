using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DatabaseLink
{
    public class AddEmployee
    {
        // Used to retrieve the content of textBox
        public string StID, Sname = string.Empty, Fname, gender, Mstatus, quali, relg, soo, email, Addr, Phone, rID, Rname;
        public DateTime dob, doe; public byte[] img;

        // Connecting to Database
      // DBConnect dbcon = new DBConnect();

        // Method for Inserting textBox values to Database
        public void InsertEmployee()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("AddEmployee", ConnectDB.con); // AddEmpoyee is a StoredProcedure database called via this connection
            //MySqlDataReader reader;

           // dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("StID", MySqlDbType.String).Value = StID;
            ConnectDB.cmd.Parameters.Add("Sname", MySqlDbType.String).Value = Sname;
            ConnectDB.cmd.Parameters.Add("Fname", MySqlDbType.String).Value = Fname;
            ConnectDB.cmd.Parameters.Add("gender", MySqlDbType.String).Value = gender;
            ConnectDB.cmd.Parameters.Add("dob", MySqlDbType.DateTime).Value = dob;
            ConnectDB.cmd.Parameters.Add("Mstatus", MySqlDbType.String).Value = Mstatus;
            ConnectDB.cmd.Parameters.Add("quali", MySqlDbType.String).Value = quali;
            ConnectDB.cmd.Parameters.Add("relg", MySqlDbType.String).Value = relg;
            ConnectDB.cmd.Parameters.Add("soo", MySqlDbType.String).Value = soo;
            ConnectDB.cmd.Parameters.Add("email", MySqlDbType.String).Value = email;
            ConnectDB.cmd.Parameters.Add("addr", MySqlDbType.String).Value = Addr;
            ConnectDB.cmd.Parameters.Add("Phone", MySqlDbType.String).Value = Phone;
            ConnectDB.cmd.Parameters.Add("roleid", MySqlDbType.String).Value = rID;
            ConnectDB.cmd.Parameters.Add("Rname", MySqlDbType.String).Value = Rname;
            ConnectDB.cmd.Parameters.Add("doe", MySqlDbType.DateTime).Value = doe;
            ConnectDB.cmd.Parameters.Add("Img", MySqlDbType.Blob).Value = img;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }

        // Method for Updating employee data in database via the 'UpdateEmployee' storedProcedure
        public void UpdateEmployee()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("UpdateEmployee", ConnectDB.con);
            //MySqlDataReader reader;

            //dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("StID", MySqlDbType.String).Value = StID;
            ConnectDB.cmd.Parameters.Add("Sname", MySqlDbType.String).Value = Sname;
            ConnectDB.cmd.Parameters.Add("Fname", MySqlDbType.String).Value = Fname;
            ConnectDB.cmd.Parameters.Add("gender", MySqlDbType.String).Value = gender;
            ConnectDB.cmd.Parameters.Add("dob", MySqlDbType.DateTime).Value = dob;
            ConnectDB.cmd.Parameters.Add("Mstatus", MySqlDbType.String).Value = Mstatus;
            ConnectDB.cmd.Parameters.Add("quali", MySqlDbType.String).Value = quali;
            ConnectDB.cmd.Parameters.Add("relg", MySqlDbType.String).Value = relg;
            ConnectDB.cmd.Parameters.Add("soo", MySqlDbType.String).Value = soo;
            ConnectDB.cmd.Parameters.Add("email", MySqlDbType.String).Value = email;
            ConnectDB.cmd.Parameters.Add("addr", MySqlDbType.String).Value = Addr;
            ConnectDB.cmd.Parameters.Add("Phone", MySqlDbType.String).Value = Phone;
            ConnectDB.cmd.Parameters.Add("roleid", MySqlDbType.String).Value = rID;
            ConnectDB.cmd.Parameters.Add("Rname", MySqlDbType.String).Value = Rname;
            ConnectDB.cmd.Parameters.Add("doe", MySqlDbType.DateTime).Value = doe;
            ConnectDB.cmd.Parameters.Add("Img", MySqlDbType.Blob).Value = img;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }

        public void AddEmpRole()
        {
            ConnectDB.cmd = new MySqlCommand("AddEmpRole", ConnectDB.con);
            //MySqlDataReader reader;

            //dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("RolID", MySqlDbType.String).Value = rID;
            ConnectDB.cmd.Parameters.Add("Rname", MySqlDbType.String).Value = Rname;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }

        public void DeleteEmployee()
        {
            ConnectDB.cmd = new MySqlCommand("DeleteEmployee", ConnectDB.con);
            //MySqlDataReader reader;

           // dbcon.con.Open();
            ConnectDB.cmd.Parameters.Add("StID", MySqlDbType.String).Value = StID;

            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {

            }
            //dbcon.con.Close();
        }
    }
}
