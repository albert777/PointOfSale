using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;
namespace DataCapture
{
    public class GetSupplierDet
    {
        private string SupID, CSname, CFname, CompName, CompAddr, /*CTitle,*/ gender, Mstatus, email, Addr, Phone;

                
        AddSupplierUpdate addSup =new AddSupplierUpdate();
        // Constructor that captures Suppliers details and calls the InsertSupplier method from AddSupplierUpdate class, which adds the supplier to the database
        public GetSupplierDet(string supid, string csname, string cfname, string cmpname, string cmpaddr, string gender, string mstatus, string email, string addr, string phone)
        {
            SupID = supid; CSname = csname; CFname = cfname; this.gender = gender; Mstatus = mstatus; 
            CompName = cmpname; CompAddr = cmpaddr; this.email = email; Addr = addr;
            Phone = phone;

            addSup.SupID = SupID; addSup.CSname = CSname; addSup.CFname = CFname; addSup.gender = this.gender; 
            addSup.Mstatus = Mstatus; addSup.CompName = CompName; addSup.CompAddr = CompAddr;
            addSup.email = this.email; addSup.Addr = Addr; addSup.Phone = Phone;
            addSup.InsertSupplier();
            
        }
    }
}
