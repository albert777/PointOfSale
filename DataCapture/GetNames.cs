using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;

namespace DataCapture
{
    public class GetNames
    {
        public string Sname, Fname;

        LoginData getLogin = new LoginData();
        public string Surname()
        {

            return Sname = getLogin.Surname;
        }

        public string Firstname()
        {

            return Fname = getLogin.Firstname;
        }
    }
}
