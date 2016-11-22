using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;

namespace DataCapture
{
    public class GetEmpDetails
    {
        private string StID, Sname = string.Empty, Fname, gender, Mstatus, quali, relg, soo, email, Addr, Phone, rID, Rname;
        private DateTime dob, doe; private byte[] Img;

                
        AddEmployee addEmp = new AddEmployee();
        // Constructor that captures employee details and calls the insertemployee method from AddEmployee class, which adds the employee to the database
        public GetEmpDetails(string sid, string sname, string fname, string gender, string mstatus, string quali, string relg, string soo, string email, string addr, string phone, string rid, string rname, DateTime dob, DateTime doe, byte[] img)
        {
            StID = sid; Sname = sname; Fname = fname; this.gender = gender; Mstatus = mstatus; this.quali = quali; this.relg = relg; this.soo = soo; this.email = email; Addr = addr;
            Phone = phone; rID = rid; Rname = rname; this.dob = dob; this.doe = doe; Img = img;

            addEmp.StID = StID; addEmp.Sname = Sname; addEmp.Fname = Fname; addEmp.gender = this.gender; addEmp.Mstatus = Mstatus; addEmp.quali = this.quali; addEmp.relg = this.relg;
            addEmp.soo = this.soo; addEmp.email = this.email; addEmp.Addr = Addr; addEmp.Phone = Phone; addEmp.rID = rID; addEmp.Rname = Rname; addEmp.dob = this.dob; addEmp.doe = this.doe; addEmp.img = Img;
            addEmp.InsertEmployee();
            //addEmp.AddEmpRole();
        }

                
    }
}
