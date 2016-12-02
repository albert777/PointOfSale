using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseLink;

namespace DataCapture
{
    public class upDateSup
    {
        public string SupID, CSname, CFname, CompName, CompAddr, /*CTitle,*/ gender, Mstatus, email, Addr, Phone;

        AddSupplierUpdate Sup = new AddSupplierUpdate();
        public void UpDateSupplierInfo()
        {
            Sup.SupID = SupID; Sup.CSname = CSname; Sup.CFname = CFname; Sup.CompName = CompName;
            Sup.CompAddr = CompAddr; Sup.gender = gender; Sup.Mstatus = Mstatus; Sup.email = email;
            Sup.Addr = Addr; Sup.Phone = Phone;
            Sup.UpdateSupplier();
        }

        public string supplierid = string.Empty;
        public DataTable GetSupplierTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = supplierid;
            dtble = search.SearchSupplierWithSupplierID();
            return dtble;
        }


        public string Kwrd = string.Empty; 
        public DataTable dTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = Kwrd;
            dtble = search.SearchSuppliers();
            return dtble;
        }  
        
        // Datatable method to initialize datagridview columnheader at form load     

        DataTable table = new DataTable();
        public DataTable Table()
        {
            table.Columns.Add("Supplier ID"); table.Columns.Add("Company Name"); table.Columns.Add("Company Address"); 
            table.Columns.Add("Contact Surname"); table.Columns.Add("Contact Firstname"); table.Columns.Add("Gender"); table.Columns.Add("Marital Status");
            table.Columns.Add("Address"); table.Columns.Add("Email"); table.Columns.Add("Phone Number");
            
            return table;
        }

        AddSupplierUpdate addSup = new AddSupplierUpdate();
        // To delete employee record
        public void deleteSup()
        {
            addSup.SupID = SupID;
            addSup.DeleteSupplier();
        }
    }
}
