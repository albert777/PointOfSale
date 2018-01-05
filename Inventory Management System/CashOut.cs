using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class CashOut : Form 
    {
        //private POS snd = new POS();
        string pospay;
        //string DisplayChange;
        public CashOut(string get)
        {
            InitializeComponent();
            richCashOut.SelectionAlignment = HorizontalAlignment.Center;
            pospay = get; 
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text + button0.Text;
        }

        //private void richCashOut_KeyDown(object sender, KeyEventArgs e)
        //{
            
        //}
        public string get;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            POS showPOS = (POS) Application.OpenForms["POS"];
            //showPOS.labelChange.ForeColor = Color.Green;
            //showPOS.richTextBox1.Text = showPOS.displayChange;
            showPOS.Show();
            double change = Convert.ToDouble(richCashOut.Text) - Convert.ToDouble(pospay);
            showPOS.labelChange.Text = String.Format("{0:0,0.00}", change);
            //MessageBox.Show(String.Format("{0:0,0.00}", change), "Label Change Text");
            //showPOS.labelChange.TextChanged += labelChange_TextChanged;
            showPOS.AddSalesToDB();
            showPOS.UpdateStockWithQuantityAfterSale();
            showPOS.PrintReceipt();
            //showPOS.RemoveItemFromListviewAfterSale();
            //showPOS.SetTextBoxToNullAfterSale();
            
            
           
            this.Hide();
        }

        //void labelChange_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richCashOut.Text = richCashOut.Text.Substring(0, richCashOut.Text.Length - 1);
        }
    }
}
