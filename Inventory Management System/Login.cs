using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCapture;
using DatabaseLink;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Logins()
        {
            try
            {
                GetLoginInfo login = new GetLoginInfo(txtUserID.Text, txtPassword.Text);

                if (login.counter == 1)
                {
                    login.validateLogin();
                    MainView main = new MainView();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Either the Username or Password you supplied is incorrect, cross check and try again!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logins();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F10)
            //{
            //    DBConfig db = new DBConfig();
            //    db.Show();
            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConnectDB.getData();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logins();
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logins();
            }
            else if (e.KeyCode == Keys.F12)
            {
                DBConfig db = new DBConfig();
                db.ShowDialog();
            }
        }
    }
}
