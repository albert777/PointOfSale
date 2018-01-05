using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCapture;
using Microsoft.VisualBasic;


namespace Inventory_Management_System
{
    
    public partial class POS : Form
    {
        private CashOut processPay;    
        public POS()
        {
            InitializeComponent();
            double setnull = 0.00;
            discountedAmount = String.Format("{0:0.00}", setnull);
            labelTotalPrice.Text = discountedAmount;
        }

        public string userdetail; // Gets users details for updating database
        string discountedAmount; // Gets discounted amount so as to determine total payout.
        double discount; // Sets discount value as well as return the value to zero when necessary.
        //public string AmountPaid;
        //public string getAmountToPay;
        
        //public string displayChange;

        private void RetrieveStock()
        {
            UpdateStock getStocks = new UpdateStock();
            getStocks.Kwrd = txtbSearch.Text;
            DataTable Table = getStocks.dTable();

            ListViewItem entry = null;
            listViewSearch.Items.Clear();

            foreach (DataRow row in Table.Rows)
            {
                entry = new ListViewItem(row["ProductName"].ToString());
                entry.SubItems.Add(row["ProductDescription"].ToString());
                entry.SubItems.Add(row["UnitPrice"].ToString());
                listViewSearch.Items.Add(entry);
            }
        }

        private void AddToSell()
        {
            string product_name = null;

            try
            {
                if (string.IsNullOrEmpty(listViewSearch.FocusedItem.Text))
                {

                }
                else
                {

                    product_name = listViewSearch.FocusedItem.Text;
                    UpdateStock getStocks = new UpdateStock();
                    getStocks.Kwrd = product_name;
                    DataTable Table = getStocks.dTable();

                    foreach (DataRow row in Table.Rows)
                    {
                        txtbProd.Text = row["ProductName"].ToString();
                        txtbPrice.Text = row["UnitPrice"].ToString();
                        
                    }
                    txtbSearch.Text = null;
                    listViewSearch.Items.Clear();

                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to add", MsgBoxStyle.Exclamation, "Add to Cart");
                return;
            }
        }

        private void CalculateTotalPrice()
        {
            if (string.IsNullOrEmpty(txtbQunatity.Text))
            {
                labelTotalPrice.Text = "0.00";
            }
            else
            {
                    double Quantity, Price;

                    Quantity = Convert.ToDouble(txtbQunatity.Text);
                    Price = Convert.ToDouble(txtbPrice.Text);
                    double totPrice = Quantity * Price;

                    double TotalPrice = Math.Round(totPrice, 2);

                    labelTotalPrice.Text = String.Format("{0:0,0.00}", TotalPrice); // Displays the output string in decimal format.
            }
        }

        private void CalculateTotalPriceAfterDiscount()
        {
            
            double Quantity, Price;

            Quantity = Convert.ToDouble(txtbQunatity.Text);
            Price = Convert.ToDouble(txtbPrice.Text);
            double totPrice = Quantity * Price;
            double TPrice = Math.Round(totPrice, 2);

            if (string.IsNullOrEmpty(txtbDiscount.Text))
            {

                labelTotalPrice.Text = String.Format("{0:0,0.00}", TPrice);
            }
            else
            {

                double discountedvalue = Convert.ToDouble(txtbDiscount.Text);
                discountedvalue = discountedvalue / 100;
                discount = discountedvalue * totPrice;
                discountedAmount = String.Format("{0:0,0.00}", discount);
                discount = totPrice - discount;
                double TotalPrice = Math.Round(discount, 2);
                labelTotalPrice.Text = String.Format("{0:0,0.00}", TotalPrice);
            }
            discount = 0.00;
        }

        private void AddToListView()
        {
            listViewPurchase.View = View.Details;

            ListViewItem addItem = listViewPurchase.Items.Add(txtbProd.Text);
            addItem.SubItems.Add(txtbQunatity.Text);
            addItem.SubItems.Add(txtbPrice.Text);
            addItem.SubItems.Add(discountedAmount);
            addItem.SubItems.Add(labelTotalPrice.Text);
            discountedAmount = String.Format("{0:0.00}", discount); //Sets discount back to Zero 
        }

        //public void sendCheckout()
        //{
        //    double paid = Convert.ToDouble(AmountPaid);
        //    double change = paid - Convert.ToDouble(getAmountToPay);
        //    //labelChange.Text = String.Format("{0:0,0.00}", change);
        //    MessageBox.Show(String.Format("{0:0,0.00}", change));
        //    displayChange = String.Format("{0:0,0.00}", change);
        //}

        private void TotalInCart()
        {
            double ammountToPay = 0;
            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                ammountToPay += double.Parse(Item.SubItems[4].Text);
            }
            labelTotalAmountToPay.Text = String.Format("{0:0,0.00}", ammountToPay);  
        }

        public void UpdateStockWithQuantityAfterSale()
        {
            int Quantity, saleQuantity; string prodname;
            int availQuantity = 0;

            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                prodname = Item.SubItems[0].Text;
                saleQuantity = Convert.ToInt32(Item.SubItems[1].Text);
                DataTable stocktable;
                UpdateStock stockupdate = new UpdateStock();
                stockupdate.Kwrd = prodname;
                stocktable = stockupdate.dTable();

                foreach (DataRow row in stocktable.Rows)
                {
                    availQuantity = Convert.ToInt32(row["Quantity"]);
                }

                Quantity = availQuantity - saleQuantity;
                //MessageBox.Show(Convert.ToString(Quantity));
                GetStockDetails update = new GetStockDetails(prodname, Quantity);
            }
        }

        public void AddSalesToDB()
        {
            Login getFirstname = (Login)Application.OpenForms["Login"];
            //GetNames log = new GetNames();
            //string sname = log.Surname();
            //string fname = log.Firstname();
            int Unitprice, Quantity; string discount, totalamount;
            string prodname; string staffname = getFirstname.username;
            DateTime Date = DateTime.Now;

            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                prodname = Item.SubItems[0].Text;
                Quantity = Convert.ToInt32(Item.SubItems[1].Text);
                Unitprice = Convert.ToInt32(Item.SubItems[2].Text);
                //double conv = Convert.ToDouble(Item.SubItems[3].Text);
                discount = Item.SubItems[3].Text;
                totalamount = Item.SubItems[4].Text;
                GetSales sales = new GetSales(staffname, Date, prodname, Quantity, Unitprice, discount, totalamount);
            }
 
        }

        private void SetTextBoxToNull()
        {
            txtbDiscount.Text = string.Empty;
                double itemnull = 0.00;
                itemnull = Math.Round(itemnull, 2);
            txtbProd.Text = string.Empty; txtbPrice.Text = string.Empty; txtbQunatity.Text = string.Empty;
            
            labelTotalPrice.Text = String.Format("{0:0.00}", itemnull);
        }

        public void SetTextBoxToNullAfterSale()
        {
            
            double itemnull = 0.00;
            itemnull = Math.Round(itemnull, 2);
            labelTotalAmountToPay.Text = String.Format("{0:0.00}", itemnull);

            labelChange.Text = String.Format("{0:0.00}", itemnull);
        }

        public void RemoveItemFromListviewAfterSale()
        {
            foreach (ListViewItem item in listViewPurchase.Items)
                    listViewPurchase.Items.Remove(item);
        }

        private void RemoveItemFromListview()
        {
            foreach (ListViewItem item in listViewPurchase.Items)
                if (item.Selected)
                    listViewPurchase.Items.Remove(item);
        }

        // Increments quantity when minus image is clicked, and recalculates total and amount to pay
        private void IncrementQuantity()
        {
            int IncreaseQuantity = 0;
            double Quantity, UnitPrice, TotalPrice;
            foreach (ListViewItem item in listViewPurchase.Items)
                if (item.Selected)
                {
                    IncreaseQuantity = Convert.ToInt32(item.SubItems[1].Text);
                    IncreaseQuantity++;
                    item.SubItems[1].Text = Convert.ToString(IncreaseQuantity);

                    Quantity = double.Parse(item.SubItems[1].Text);
                    UnitPrice = double.Parse(item.SubItems[2].Text);
                    TotalPrice = Quantity * UnitPrice; 
                    item.SubItems[4].Text = String.Format("{0:0,0.00}", TotalPrice);
                    TotalInCart(); // Method called to calculate total in cart and amount to pay.
                }
        }

        // Decrements quantity when minus image is clicked, and recalculates total and amount to pay
        private void DecrementQuantity()
        {
            int decrementQuantity = 0;
            double Quantity, UnitPrice, TotalPrice;
            foreach (ListViewItem item in listViewPurchase.Items)
                if (item.Selected)
                {
                    decrementQuantity = Convert.ToInt32(item.SubItems[1].Text);
                    decrementQuantity--;
                    item.SubItems[1].Text = Convert.ToString(decrementQuantity);

                    Quantity = double.Parse(item.SubItems[1].Text);
                    UnitPrice = double.Parse(item.SubItems[2].Text);
                    TotalPrice = Quantity * UnitPrice;
                    item.SubItems[4].Text = String.Format("{0:0,0.00}", TotalPrice);
                    TotalInCart(); // Method called to calculate total in cart and amount to pay.
                }
        }

        public void PrintReceipt()
        {
            PrintDocument printReceipt = new PrintDocument();
            printReceipt.PrintPage += new PrintPageEventHandler(printReceipt_PrintPage);
            printReceipt.Print();
        }

        void printReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            Login getFirstname = (Login)Application.OpenForms["Login"];
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 8);
            float fontHeight = font.GetHeight();
            SolidBrush brush = new SolidBrush(Color.Black);

            int startX = 10; int startY = 10; int offset = 40;
            string items = "Items".PadRight(15); string quant = "Qty".PadRight(5); string Uprice = "Price".PadRight(8);
            string disc = "Discount".PadRight(12); string totalp = "Total Price";

            string columnline = items + quant + Uprice + disc + totalp;
            graphic.DrawString("Welcome To Agram Pharmacy", new Font("Courier New", 18), brush, startX, startY);
            graphic.DrawString("-----------------------------------------------------", new Font("Courier New", 8), brush, startX, startY + offset);
            offset = offset + 80;
            graphic.DrawString(columnline, font, brush, startX, startY + 60);
            graphic.DrawString("-----------------------------------------------------", new Font("Courier New", 8), brush, startX, startY + 80);

            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                string item = Item.SubItems[0].Text.PadRight(15);
                string quantity = Item.SubItems[1].Text.PadRight(5);
                string unitPrice = Item.SubItems[2].Text.PadRight(8);
                string discount = Item.SubItems[3].Text.PadRight(12);
                string totalPrice = String.Format("{0:c}", Item.SubItems[4].Text);

                string line = item + quantity + unitPrice + discount + totalPrice;

                graphic.DrawString(line, font, brush, startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            //string amountToPay = "Total to Pay".PadRight(30) + String.Format("{0:c}", labelTotalAmountToPay.Text);
            offset = offset + 5;
            //graphic.DrawString("-----------------------------------------------------", new Font("Courier New", 8), brush, startX, startY + 145);
            graphic.DrawString("Total to Pay".PadRight(39) + String.Format("({0:c})", labelTotalAmountToPay.Text), font, brush, startX, startY + offset);
            //graphic.DrawString("-----------------------------------------------------", new Font("Courier New", 8), brush, startX, startY + 170);
            //offset = offset + (int)fontHeight;
            CashOut getAmountPaid = (CashOut) Application.OpenForms["CashOut"];
            double amountPaid = Convert.ToDouble(getAmountPaid.richCashOut.Text);
            graphic.DrawString("Amount Paid".PadRight(40) + String.Format("{0:c}", amountPaid), font, brush, startX, startY + 200);
            graphic.DrawString("Change Collected".PadRight(40) + String.Format("{0:c}", labelChange.Text), font, brush, startX, startY + 230);
            graphic.DrawString("You were attended to by:  " + getFirstname.username, font, brush, startX, startY + 260);
        }

        private void txtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveStock();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RetrieveStock();
        }

        private void listViewSearch_MouseClick(object sender, MouseEventArgs e)
        {
            AddToSell();
        }

        private void txtbQunatity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtbDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPriceAfterDiscount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToListView();
            TotalInCart();
            SetTextBoxToNull();
            checkBoxDiscount.Checked = false;
            txtbDiscount.ReadOnly = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItemFromListview();
            TotalInCart();
        }

        private void POS_Load(object sender, EventArgs e)
        {
           // Login user = new Login();
            labelWelcome.ForeColor = Color.Green;
            labelWelcome.Text = "Welcome, You are logged in as:  " + userdetail;
        }

        private void txtbQunatity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToListView();
                TotalInCart();
                SetTextBoxToNull();
            }
        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            txtbDiscount.ReadOnly = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IncrementQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DecrementQuantity();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            
            processPay = new CashOut(labelTotalAmountToPay.Text);            
            processPay.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RetrieveStock();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            AddToListView();
            TotalInCart();
            SetTextBoxToNull();
            checkBoxDiscount.Checked = false;
            txtbDiscount.ReadOnly = true;
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            RemoveItemFromListview();
            TotalInCart();
        }

        //private void txtbSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtbSearch.Text))
        //    {
        //        listViewSearch.Items.Clear();
        //    }
        //    RetrieveStock();
        //}
    }
}
