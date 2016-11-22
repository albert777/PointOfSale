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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GetSupplierDet sup = new GetSupplierDet(txtbSupID.Text, txtbCntctSname.Text, txtbCntctFname.Text,
                txtbCompName.Text, txtbCompAddr.Text, combGender.Text, combMarSt.Text, txtbEmail.Text, txtbSupAddr.Text, txtbPhone.Text);

                txtbSupID.Text = null; txtbCntctSname.Text = null; txtbCntctFname.Text = null;
                txtbCompName.Text = null; txtbCompAddr.Text = null; combGender.Text = null;
                combMarSt.Text = null; txtbEmail.Text = null; txtbSupAddr.Text = null; txtbPhone.Text = null;
                MessageBox.Show("Suppliers Details saved successfully!", "Data Saved");
            }
            catch(Exception)
            {
                MessageBox.Show("Some form fields are not filled, \nfill appropriately and try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
