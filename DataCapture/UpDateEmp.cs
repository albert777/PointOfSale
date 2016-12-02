using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;
using System.Data;

namespace DataCapture
{
    public class UpDateEmp
    {
        public string StD, Snam = string.Empty, Fnam, gendr, Mstats, qual, rel, soor, emal, Adr, Phon, RID, Rnam;
        public DateTime DOB, DOE; public byte[] IMG;

        
        public string Kwrd = string.Empty;
        AddEmployee addEmp = new AddEmployee();
        // Calls the UpdateEmployee method in the AddEmployee class, which updates database with changes supplied by User
        public void upDateEmp()
        {
            addEmp.StID = StD; addEmp.Sname = Snam; addEmp.Fname = Fnam; addEmp.gender = gendr; addEmp.Mstatus = Mstats; addEmp.quali = qual; addEmp.relg = rel;
            addEmp.soo = soor; addEmp.email = emal; addEmp.Addr = Adr; addEmp.Phone = Phon; addEmp.rID = RID; addEmp.Rname = Rnam; addEmp.dob = DOB; addEmp.doe = DOE; addEmp.img = IMG;
            addEmp.UpdateEmployee();
           
        }

        public string staffid = string.Empty;
        public DataTable GetEmployeeTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = staffid;
            dtble = search.SearchEmployeeWithStaffID();
            return dtble;
        }

        // Datatable method to initialize datagridview columnheader at form load     
            
        //DataTable table = new DataTable();
        //public DataTable Table()
        //{            
        //    table.Columns.Add("Staff_ID"); table.Columns.Add("Surname"); table.Columns.Add("First Name"); table.Columns.Add("Gender"); table.Columns.Add("DOB"); table.Columns.Add("Marital Status");
        //    table.Columns.Add("Qualification"); table.Columns.Add("Religion"); table.Columns.Add("State of Origin"); table.Columns.Add("Email"); table.Columns.Add("Address"); table.Columns.Add("Phone Number");
        //    table.Columns.Add("Role ID"); table.Columns.Add("Role Name"); table.Columns.Add("DOE"); table.Columns.Add("Picture");
            
        //    return table;
        //}
        // Calls the  SearchEmployee method in the DBSearch class and returns a table
        public DataTable dTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = Kwrd;
            dtble = search.SearchEmployee();
            return dtble;
        }  
      
        // To delete employee record
        public void deleteEmp()
        {
            addEmp.StID = StD;
            addEmp.DeleteEmployee();
        }
    }
}
