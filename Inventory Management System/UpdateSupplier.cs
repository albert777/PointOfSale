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

namespace Inventory_Management_System
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
            fillCombo();
        }

        public void fillCombo()
        {
            combGender.Items.Add("Male");
            combGender.Items.Add("Female");

            combMarSt.Items.Add("Single");
            combMarSt.Items.Add("Married");
            combMarSt.Items.Add("Divorced");            
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
            upDateSup initGrid = new upDateSup();
            gridSearchSup.DataSource = initGrid.Table();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            upDateSup searchSup = new upDateSup();
            searchSup.Kwrd = txtbSearch.Text;
            gridSearchSup.DataSource = searchSup.dTable();
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

        private void gridSearchSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rw = this.gridSearchSup.Rows[e.RowIndex];

                txtbSupID.Text = rw.Cells["SupplierID"].Value.ToString(); txtbCompName.Text = rw.Cells["CompanyName"].Value.ToString();
                txtbCntctFname.Text = rw.Cells["ContactFirstname"].Value.ToString(); txtbCntctSname.Text = rw.Cells["ContactSurname"].Value.ToString();
                txtbCompAddr.Text = rw.Cells["CompanyAddress"].Value.ToString(); combGender.Text = rw.Cells["Gender"].Value.ToString();
                txtbEmail.Text = rw.Cells["Email"].Value.ToString(); combMarSt.Text = rw.Cells["Marital_Status"].Value.ToString();
                txtbSupAddr.Text = rw.Cells["Address"].Value.ToString(); txtbPhone.Text = rw.Cells["PhoneNumber"].Value.ToString();
            }
            tabUpdateDelete.SelectedTab = pgUpdateDelete; // Activates the Update employee form tab page
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                upDateSup searchSup = new upDateSup();
                searchSup.Kwrd = txtbSearch.Text;
                gridSearchSup.DataSource = searchSup.dTable();
            }
        }
    }
}
