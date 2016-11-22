using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLink;

namespace Inventory_Management_System
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ConnectDB.getData();
            //MdiClient ctlMDI;

            //// Loop through all of the form's controls looking
            //// for the control of type MdiClient.
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        // Attempt to cast the control to type MdiClient.
            //        ctlMDI = (MdiClient)ctl;

            //        // Set the BackColor of the MdiClient control.
            //        ctlMDI.BackColor = this.BackColor;
            //    }
            //    catch (InvalidCastException)
            //    {
            //        // Catch and ignore the error if casting failed.
            //    }
            //}

            //// Display a child form to show this is still an MDI application.
            ////Form2 frm = new Form2();
            ////frm.MdiParent = this;
            //frm.Show();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmpForm addemp = new AddEmpForm();
            addemp.ShowDialog();
            while (addemp.Visible == true)
            {
                this.Enabled = false;
            }
            //addemp.Show();
        }

        private void updateEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpUpdateForm upDate = new EmpUpdateForm();
            upDate.ShowDialog();
            while (upDate.Visible == true)
            {
                this.Enabled = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpUpdateForm delete = new EmpUpdateForm();
            delete.ShowDialog();
            while (delete.Visible == true)
            {
                this.Enabled = false;
            }
        }

        private void newEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddSupplier addSup = new AddSupplier();
            addSup.ShowDialog();
            while (addSup.Visible == true)
            {
                this.Enabled = false;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSup = new UpdateSupplier();
            updateSup.ShowDialog();
            while (updateSup.Visible == true)
            {
                this.Enabled = false;
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSup = new UpdateSupplier();
            updateSup.ShowDialog();
            while (updateSup.Visible == true)
            {
                this.Enabled = false;
            }
        }

        private void MainView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F12)
            //{
            //    DBConfig db = new DBConfig();
            //    db.ShowDialog();
            //}
        }
    }
}
