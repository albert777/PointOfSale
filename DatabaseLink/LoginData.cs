using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
//using DataCapture;

namespace DatabaseLink
{
    public class LoginData
    {
        /* This class coordinates Login activities such read users login information and verifies 
           in the database if the user information is valid. If the username and password supplied 
           by the user is valid, the users details such as UserName, Surname, First_Name as well as date and time 
           of the login are captured and stored in the login log table in database.*/
        
        public string Uname; public string Pwrd; public int count = 0;
        private string Sname, Fname; DateTime date;
        
        //DBConnect conn = new DBConnect(); // Connection to database
        // To cross check user supplied information with the database
        public int getValidateLogin()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchLogin", ConnectDB.con);
            //MySqlDataReader reader;

            //conn.con.Open();
            ConnectDB.cmd.Parameters.Add("Uname", MySqlDbType.String).Value = Uname;
            ConnectDB.cmd.Parameters.Add("Pwrd", MySqlDbType.String).Value = Pwrd;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {
                count++;
            }
            ConnectDB.DisconnMy();
            return count;            
        }

        // To fetch basic user info when login is successful.
        public void fetchUserInfo()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("SearchLoginAndEmployee", ConnectDB.con);
            //MySqlDataReader reader;

            //conn.con.Open();
            ConnectDB.cmd.Parameters.Add("Uname", MySqlDbType.String).Value = Uname;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            if (ConnectDB.reader.Read())
            {
                date = DateTime.Now;
                Sname = ConnectDB.reader.GetString("Surname");
                Fname = ConnectDB.reader.GetString("First_Name");
            }
            //conn.con.Close();
        }

        // To insert the fetched details to the login log for record purposes.
        public void insertLoginDetails()
        {
            ConnectDB.ConnDB();
            ConnectDB.cmd = new MySqlCommand("AddLoginLog", ConnectDB.con);
            //MySqlDataReader reader;

            //conn.con.Open();
            ConnectDB.cmd.Parameters.Add("LDate", MySqlDbType.DateTime).Value = date;
            ConnectDB.cmd.Parameters.Add("uID", MySqlDbType.String).Value = Uname;
            ConnectDB.cmd.Parameters.Add("Sname", MySqlDbType.String).Value = Sname;
            ConnectDB.cmd.Parameters.Add("Fname", MySqlDbType.String).Value = Fname;
            ConnectDB.cmd.CommandType = CommandType.StoredProcedure;

            ConnectDB.reader = ConnectDB.cmd.ExecuteReader();
            while (ConnectDB.reader.Read())
            {
 
            }
            //conn.con.Close();
        }
        
    }
}
