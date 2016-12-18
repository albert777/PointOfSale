using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLink;

namespace DataCapture
{
    public class GetStockDetails
    {
        private string ProductID, ProductName, ProductDesc, CategoryID, SuppplierID, Unitprice;
        private int Quantity;

        AddStockUpdate stockDetails = new AddStockUpdate();

        public GetStockDetails(string prodid, string prodname, string proddesc, string catid, string suppid, int quant, string uprice)
        {
            ProductID = prodid; ProductName = prodname; ProductDesc = proddesc; CategoryID = catid;
            SuppplierID = suppid; Unitprice = uprice; Quantity = quant;

            stockDetails.ProdID = ProductID; stockDetails.ProdName = ProductName; stockDetails.ProdDesc = ProductDesc;
            stockDetails.CatID = CategoryID; stockDetails.SupID = SuppplierID; stockDetails.Uprice = Unitprice;
            stockDetails.Quant = Quantity;
            stockDetails.InsertNewStock();
            
        }

        public GetStockDetails(string prodname, int quant)
        {
            stockDetails.ProdName = prodname; stockDetails.Quant = quant;
            stockDetails.UpdateStockWithQuantityAfterSale();
        }

    }
}
