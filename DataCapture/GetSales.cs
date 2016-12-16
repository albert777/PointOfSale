using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;

namespace DataCapture
{
    public class GetSales
    {
        //private string Staffname, ProductName; private int Quantity, Unitprice, Discount, Totalprice;
        //private DateTime date;

        AddToSales sales = new AddToSales();
        public GetSales(string staffname, DateTime date, string prodname, int Quant, int Uprice, string discount, string Tprice)
        {
            sales.Staffname = staffname; sales.date = date; sales.ProductName = prodname; sales.Quantity = Quant;
            sales.Unitprice = Uprice; sales.Discount = discount; sales.Totalprice = Tprice;
            sales.InsertNewSales();
            
        }
    }
}
