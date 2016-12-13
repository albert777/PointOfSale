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
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
            fillCombo();
        }

        public void SelectTab()
        {
            tabUpdateDelete.SelectedTab = pgSearch;
        }

        public void fillCombo()
        {
            combGender.Items.Add("Male");
            combGender.Items.Add("Female");

            combMarSt.Items.Add("Single");
            combMarSt.Items.Add("Married");
            combMarSt.Items.Add("Divorced");            
        }

        private void searchDB()
        {
            try
            {
                upDateSup update = new upDateSup();
                update.Kwrd = txtbSearch.Text;
                DataTable Table = update.dTable();

                ListViewItem entry = null;
                listViewSupplier.Items.Clear();

                foreach (DataRow row in Table.Rows)
                {

                    entry = new ListViewItem(row["SupplierID"].ToString());
                    entry.SubItems.Add(row["CompanyName"].ToString());
                    entry.SubItems.Add(row["ContactSurname"].ToString());
                    entry.SubItems.Add(row["ContactFirstname"].ToString());
                    entry.SubItems.Add(row["CompanyAddress"].ToString());
                    entry.SubItems.Add(row["Address"].ToString());
                    entry.SubItems.Add(row["Gender"].ToString());
                    entry.SubItems.Add(row["Marital_Status"].ToString());
                    entry.SubItems.Add(row["Email"].ToString());
                    entry.SubItems.Add(row["PhoneNumber"].ToString());
                    listViewSupplier.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FetchListView()
        {
            string supplierid = null;

            try
            {
                if (string.IsNullOrEmpty(listViewSupplier.FocusedItem.Text))
                {

                }
                else
                {

                    supplierid = listViewSupplier.FocusedItem.Text;
                    upDateSup update = new upDateSup();
                    update.supplierid = supplierid;
                    DataTable table = update.GetSupplierTable();

                    foreach (DataRow row in table.Rows)
                    {
                        txtbSupID.Text = row["SupplierID"].ToString();
                        txtbCompName.Text = row["CompanyName"].ToString();
                        txtbCntctSname.Text = row["ContactSurname"].ToString();
                        txtbCntctFname.Text = row["ContactFirstname"].ToString();
                        txtbCompAddr.Text = row["CompanyAddress"].ToString();
                        txtbSupAddr.Text = row["Address"].ToString();
                        combGender.Text = row["Gender"].ToString();
                        combMarSt.Text = row["Marital_Status"].ToString();
                        txtbEmail.Text = row["Email"].ToString();
                        txtbPhone.Text = row["PhoneNumber"].ToString();
                        
                    }
                    tabUpdateDelete.SelectedTab = pgUpdateDelete; // Activates the Update employee form tab page

                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            upDateSup getSupUpdate = new upDateSup();

            getSupUpdate.SupID = txtbSupID.Text; getSupUpdate.CompName = txtbCompName.Text;
            getSupUpdate.CFname = txtbCntctFname.Text; getSupUpdate.CSname = txtbCntctSname.Text;
            getSupUpdate.CompAddr = txtbCompAddr.Text; getSupUpdate.gender = combGender.Text;
            getSupUpdate.email = txtbEmail.Text; getSupUpdate.Mstatus = combMarSt.Text;
            getSupUpdate.Addr = txtbSupAddr.Text; getSupUpdate.Phone = txtbPhone.Text;
            getSupUpdate.UpDateSupplierInfo();
            
            txtbSupID.Text = null; txtbCompName.Text = null;
            txtbCntctFname.Text = null; txtbCntctSname.Text = null;
            txtbCompAddr.Text = null; combGender.Text = null;
            txtbEmail.Text = null; combMarSt.Text = null;
            txtbSupAddr.Text = null; txtbPhone.Text = null;
            MessageBox.Show("Supplier's record updated successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            //upDateSup initGrid = new upDateSup();
            //gridSearchSup.DataSource = initGrid.Table();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure you want to delete this supplier's record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirm == DialogResult.Yes)
            {
                upDateSup delete = new upDateSup();
                delete.SupID = txtbSupID.Text;
                delete.deleteSup();

                txtbSupID.Text = null; txtbCompName.Text = null;
                txtbCntctFname.Text = null; txtbCntctSname.Text = null;
                txtbCompAddr.Text = null; combGender.Text = null;
                txtbEmail.Text = null; combMarSt.Text = null;
                txtbSupAddr.Text = null; txtbPhone.Text = null;
                MessageBox.Show("Supplier's record deleted successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
            else if (Confirm == DialogResult.No)
            {
 
            }
        }

        //private void gridSearchSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow rw = this.gridSearchSup.Rows[e.RowIndex];

        //        txtbSupID.Text = rw.Cells["SupplierID"].Value.ToString(); txtbCompName.Text = rw.Cells["CompanyName"].Value.ToString();
        //        txtbCntctFname.Text = rw.Cells["ContactFirstname"].Value.ToString(); txtbCntctSname.Text = rw.Cells["ContactSurname"].Value.ToString();
        //        txtbCompAddr.Text = rw.Cells["CompanyAddress"].Value.ToString(); combGender.Text = rw.Cells["Gender"].Value.ToString();
        //        txtbEmail.Text = rw.Cells["Email"].Value.ToString(); combMarSt.Text = rw.Cells["Marital_Status"].Value.ToString();
        //        txtbSupAddr.Text = rw.Cells["Address"].Value.ToString(); txtbPhone.Text = rw.Cells["PhoneNumber"].Value.ToString();
        //    }
        //    tabUpdateDelete.SelectedTab = pgUpdateDelete; // Activates the Update employee form tab page
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchDB();
            }
        }

        private void listViewSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            FetchListView();
        }
    }
}
