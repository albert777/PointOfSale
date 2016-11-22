using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace DatabaseLink
{
    public static class ConnectDB
    {
        public static string MySQLServer;
        public static string MySQLPort;
        public static string MySQLUserName;
        public static string PwdMySQL;
        public static string DBNameMySQL;
        public static string sqL;
        public static DataSet ds = new DataSet();
        public static MySqlCommand cmd;
        public static MySqlDataReader reader;


        public static string searchStr = "";

        public static MySqlDataAdapter dAdapter = new MySqlDataAdapter();

        public static MySqlConnection con = new MySqlConnection();
        public static void getData()
        {
            string AppName = Application.ProductName;

            try
            {
                DBNameMySQL = Interaction.GetSetting(AppName, "DBSection", "DB_Name", "temp");
                MySQLServer = Interaction.GetSetting(AppName, "DBSection", "DB_IP", "temp");
                MySQLPort = Interaction.GetSetting(AppName, "DBSection", "DB_Port", "temp");
                MySQLUserName = Interaction.GetSetting(AppName, "DBSection", "DB_User", "temp");
                PwdMySQL = Interaction.GetSetting(AppName, "DBSection", "DB_Password", "temp");
            }
            catch
            {
                Interaction.MsgBox("System registry was not established, you can set/save " + "these settings by pressing F1", MsgBoxStyle.Information);
            }

        }

        public static void ConnDB()
        {
            con.Close();
            try
            {
                con.ConnectionString = "Server = '" + MySQLServer + "';  " + "Port = '" + MySQLPort + "'; " + "Database = '" + DBNameMySQL + "'; " + "user id = '" + MySQLUserName + "'; " + "password = '" + PwdMySQL + "'";

                con.Open();
            }
            catch
            {
                Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");
            }

        }


        public static void DisconnMy()
        {
            con.Close();
            con.Dispose();

        }

        public static void SaveData()
        {
            string AppName = Application.ProductName;

            Interaction.SaveSetting(AppName, "DBSection", "DB_Name", DBNameMySQL);
            Interaction.SaveSetting(AppName, "DBSection", "DB_IP", MySQLServer);
            Interaction.SaveSetting(AppName, "DBSection", "DB_Port", MySQLPort);
            Interaction.SaveSetting(AppName, "DBSection", "DB_User", MySQLUserName);
            Interaction.SaveSetting(AppName, "DBSection", "DB_Password", PwdMySQL);

            Interaction.MsgBox("Database connection settings are saved.", MsgBoxStyle.Information);
        }
    }
}
