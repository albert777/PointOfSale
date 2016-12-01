using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;
using System.Data;

namespace DataCapture
{
    public class UpdateStock
    {
         public string ProductID, ProductName, ProductDesc, CategoryID, SuppplierID, Unitprice;
        public int Quantity;

        AddStockUpdate stockDetails = new AddStockUpdate();

        public void UpdateStockDetails()
        {
            
            stockDetails.ProdID = ProductID; stockDetails.ProdName = ProductName; stockDetails.ProdDesc = ProductDesc;
            stockDetails.CatID = CategoryID; stockDetails.SupID = SuppplierID; stockDetails.Uprice = Unitprice;
            stockDetails.Quant = Quantity;
            stockDetails.UpdateStock();
            
        }

        public string Kwrd = string.Empty;
        public DataTable dTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = Kwrd;
            dtble = search.SearchStocks();
            return dtble;
        }

        public string prodid = string.Empty;
        public DataTable GetStockTable()
        {
            DataTable dtble = new DataTable();
            DBSearches search = new DBSearches();
            search.KeyWrd = prodid;
            dtble = search.SearchStocksWithProdID();
            return dtble;
        }
    }
}
