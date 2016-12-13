using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;
using System.Drawing;
using System.ComponentModel;

namespace DataCapture
{
    public class GetLoginInfo
    {
        /* This class is used to capture the username and password supplied by the user
           and then assign the details to the LoginData class to access the database.*/ 

        private string UsID = string.Empty;
        private string Pwrd = string.Empty;
        public int counter = 0;
        public string RoleName, Sname, Fname;
        
               
        LoginData getLogin = new LoginData(); 
        public  GetLoginInfo(string uid, string pwd)
        {
            UsID = uid; Pwrd = pwd;
            getLogin.Uname = UsID;    // Assigns the captured login info to LoginData class variables Uname and Pwrd
            getLogin.Pwrd = Pwrd;
            counter = getLogin.getValidateLogin();  // Calls the getValidateLogin method from LoginData class and assign result to counter
        }
        
        // Fetches users basic information and inserts them to the login log table in database.
        public void validateLogin()
        {
            
            getLogin.fetchUserInfo();
            getLogin.insertLoginDetails();
            
        }

        public void getRoleName()
        {
            RoleName = getLogin.rolename;
            Sname = getLogin.Surname;
            Fname = getLogin.Firstname;
        }

                
    }
}
