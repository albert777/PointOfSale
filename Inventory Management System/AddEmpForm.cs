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
using System.IO;

namespace Inventory_Management_System
{
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
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

            combReligion.Items.Add("Christianity");
            combReligion.Items.Add("Islam");

            combQuali.Items.Add("SSCE");
            combQuali.Items.Add("BSc");
            combQuali.Items.Add("MSc");
            combQuali.Items.Add("Ph.D");

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictImage.Image.Save(ms, pictImage.Image.RawFormat);
                byte[] imageBt = ms.ToArray();

                DateTime Date = DateTime.Parse(txtbDOB.Text);
                DateTime Datee = DateTime.Parse(txtbDOE.Text);
                GetEmpDetails getEmp = new GetEmpDetails(txtbStaffID.Text, txtbFirstName.Text, txtbSurname.Text, combGender.Text, combMarSt.Text, combQuali.Text, combReligion.Text,
                                                         txtbSOO.Text, txtbEmail.Text, txtbAddress.Text, txtbPhone.Text, txtbRoleID.Text, txtbRoleN.Text, Date, Datee, imageBt);
                txtbStaffID.Text = null; txtbFirstName.Text = null; txtbSurname.Text = null; combGender.Text = null; combMarSt.Text = null; combQuali.Text = null; combReligion.Text = null;
                txtbSOO.Text = null; txtbEmail.Text = null; txtbAddress.Text = null; txtbPhone.Text = null;
                txtbRoleID.Text = null; txtbRoleN.Text = null; txtbDOB.Text = null; txtbDOE.Text = null; pictImage.Image = null;

                MessageBox.Show("Employee record saved successfully!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Some form fields are not filled, \nfill appropriately and try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                                                      
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();                
                pictImage.ImageLocation = picPath;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
