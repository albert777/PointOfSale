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
    public partial class AddUpdateStock : Form
    {
        public AddUpdateStock()
        {
            InitializeComponent();
        }

        private void CaptureStockInfo()
        {
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            try
            {
                GetStockDetails stocks = new GetStockDetails(txtProductID.Text, txtProductName.Text, txtDescription.Text,
                    txtSupplierID.Text, txtCategoryID.Text, Quantity, txtUnitPrice.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Some form fields are not filled, \nfill appropriately and try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }

        private void RetrieveStockInfo()
        {
            try
            {
                UpdateStock stock = new UpdateStock();
                stock.Kwrd = txtSearch.Text;
                DataTable table = stock.dTable();

                ListViewItem entry = null;
                listViewStockSearch.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    
                    entry = new ListViewItem(row["ProductID"].ToString());
                    entry.SubItems.Add(row["ProductName"].ToString());
                    entry.SubItems.Add(row["ProductDescription"].ToString());
                    entry.SubItems.Add(row["SupplierID"].ToString());
                    entry.SubItems.Add(row["CategoryID"].ToString());
                    entry.SubItems.Add(row["Quantity"].ToString());
                    entry.SubItems.Add(row["UnitPrice"].ToString());
                    listViewStockSearch.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FetchListViewContentFromDatabase()
        {
            string productid = null;

            try
            {
                if (string.IsNullOrEmpty(listViewStockSearch.FocusedItem.Text))
                {

                }
                else
                {
                    
                    productid = listViewStockSearch.FocusedItem.Text;
                    UpdateStock update = new UpdateStock();
                    update.prodid = productid;
                    DataTable table = update.GetStockTable();

                    foreach (DataRow row in table.Rows)
                    {
                        txtbProductID.Text = row["ProductID"].ToString();
                        txtbProductName.Text = row["ProductName"].ToString();
                        txtbDescription.Text = row["ProductDescription"].ToString();
                        txtbSupplierID.Text = row["SupplierID"].ToString();
                        txtbCategoryID.Text = row["CategoryID"].ToString();
                        txtbQuantity.Text = row["Quantity"].ToString();
                        txtbUnitPrice.Text = row["UnitPrice"].ToString();
                    }
                   
                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update");
                return;
            }
        }

        private void UpdateStockDetails()
        {
            int Quantity = Convert.ToInt32(txtbQuantity.Text);
            UpdateStock stockupdate = new UpdateStock();
            stockupdate.ProductID = txtbProductID.Text;
            stockupdate.ProductName = txtbProductName.Text;
            stockupdate.ProductDesc = txtbDescription.Text;
            stockupdate.SuppplierID = txtbSupplierID.Text;
            stockupdate.CategoryID = txtbCategoryID.Text;
            stockupdate.Quantity = Quantity;
            stockupdate.Unitprice = txtbUnitPrice.Text;
            stockupdate.UpdateStockDetails();

            txtbProductID.Text = null;
            txtbProductName.Text = null;
            txtbDescription.Text = null;
            txtbSupplierID.Text = null;
            txtbCategoryID.Text = null;
            txtbQuantity.Text = null;
            txtbUnitPrice.Text = null;
            txtSearch.Text = null;
            listViewStockSearch.Items.Clear();
            MessageBox.Show("Record updated successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CaptureStockInfo();
            MessageBox.Show("Record Added successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RetrieveStockInfo();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveStockInfo();
            }
        }

        private void listViewStockSearch_MouseClick(object sender, MouseEventArgs e)
        {
            FetchListViewContentFromDatabase();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStockDetails();
        }
    }
}
