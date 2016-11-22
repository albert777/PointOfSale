using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLink;
using Microsoft.VisualBasic;

namespace Inventory_Management_System
{
    public partial class DBConfig : Form
    {
        public DBConfig()
        {
            InitializeComponent();
        }

        private string TstServer;
        private string TstPort;
        private string TstUserName;
        private string TstPassword;
        private string TstDatabase;

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Test database connection

            TstServer = txtbServer.Text;
            TstPort = txtbPort.Text;
            TstUserName = txtbUsername.Text;
            TstPassword = txtbPassword.Text;
            TstDatabase = txtbDatabase.Text;


            try
            {
                ConnectDB.con.ConnectionString = "Server = '" + TstServer + "';  " + "Port = '" + TstPort + "'; " + "Database = '" + TstDatabase + "'; " + "user id = '" + TstUserName + "'; " + "password = '" + TstPassword + "'";


                ConnectDB.con.Open();
                Interaction.MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings");

            }
            catch
            {
                Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");

            }
            ConnectDB.DisconnMy();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TstServer = txtbServer.Text;
            TstPort = txtbPort.Text;
            TstUserName = txtbUsername.Text;
            TstPassword = txtbPassword.Text;
            TstDatabase = txtbDatabase.Text;


            try
            {
                ConnectDB.con.ConnectionString = "Server = '" + TstServer + "';  " + "Port = '" + TstPort + "'; " + "Database = '" + TstDatabase + "'; " + "user id = '" + TstUserName + "'; " + "password = '" + TstPassword + "'";
                
                ConnectDB.con.Open();
                ConnectDB.MySQLServer = txtbServer.Text;
                ConnectDB.MySQLPort = txtbPort.Text;
                ConnectDB.MySQLUserName = txtbUsername.Text;
                ConnectDB.PwdMySQL = txtbPassword.Text;
                ConnectDB.DBNameMySQL = txtbDatabase.Text;

                ConnectDB.SaveData();
                this.Close();

                Interaction.MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings");

            }
            catch
            {
                Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");

            }
            ConnectDB.DisconnMy();
        }

        private void DBConfig_Load(object sender, EventArgs e)
        {
            //Sets configuration details to textBox in Config form

            txtbServer.Text = ConnectDB.MySQLServer;
            txtbPort.Text = ConnectDB.MySQLPort;
            txtbUsername.Text = ConnectDB.MySQLUserName;
            txtbPassword.Text = ConnectDB.PwdMySQL;
            txtbDatabase.Text = ConnectDB.DBNameMySQL;
        }
    }
}
