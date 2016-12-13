using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public POS()
        {
            InitializeComponent();
            double setnull = 0.00;
            discountedAmount = String.Format("{0:0.00}", setnull);
            labelTotalPrice.Text = discountedAmount;
        }
        public string userdetail;

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

        string discountedAmount;
        double discount;
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

        private void TotalInCart()
        {
            double ammountToPay = 0;
            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                ammountToPay += double.Parse(Item.SubItems[4].Text);
            }
            labelTotalAmountToPay.Text = String.Format("{0:0,0.00}", ammountToPay);
            
        }

        private void AddSalesToDB()
        {
            GetNames log = new GetNames();
            string sname = log.Surname();
            string fname = log.Firstname();
            int Unitprice, Quantity, discount, totalamount;
            string prodname; string staffname = sname + " " + fname ;
            DateTime Date = DateTime.Now;
            
            foreach (ListViewItem Item in listViewPurchase.Items)
            {
                prodname = Item.SubItems[0].Text;
                Unitprice = Convert.ToInt32(Item.SubItems[1].Text);
                Quantity = Convert.ToInt32(Item.SubItems[2].Text);
                discount = Convert.ToInt32(Item.SubItems[3].Text);
                totalamount = Convert.ToInt32(Item.SubItems[4].Text);
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

        private void RemoveItemFromListview()
        {
            foreach (ListViewItem item in listViewPurchase.Items)
                if (item.Selected)
                    listViewPurchase.Items.Remove(item);
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
