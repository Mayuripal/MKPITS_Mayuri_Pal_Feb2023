using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceGeneration
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            dateTimePickerInvoiceDate.Value = DateTime.Today;
            dateTimePickerInvoiceDate.MinDate = DateTime.Today;
        }

        

        private void FormLoad1(object sender, EventArgs e)
        {
            //fill list box with product name
            DataSet ds = Invoice.GetProduct();
            listBoxProductName.DataSource = ds.Tables[0];
            listBoxProductName.DisplayMember = "Name";
            listBoxProductName.ValueMember = "ID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to fill detaild according to selected product
            DataSet ds1 = Invoice.GetProductDetail(listBoxProductName.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            { 
                textBoxProductName.Text = dr["Name"].ToString();
                textBoxAvailableQuantity.Text = dr["AVAILABLE_QTY"].ToString();
                textBoxTotalQuantity.Text = dr["SELL_QTY"].ToString();
                textBoxPrice.Text = dr["PRICE_PER_UNIT"].ToString();
                textBoxPercentCGST.Text = dr["CGST"].ToString();
                textBoxPercentSGST.Text = dr["SGST"].ToString();

            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {   //calculate gst and total amount
            double cgstamount = Convert.ToDouble(textBoxPrice.Text) * Convert.ToDouble(textBoxPercentCGST.Text) / 100;
            textBoxCGSTAmount.Text = cgstamount.ToString();

            double sgstamount = Convert.ToDouble(textBoxPrice.Text) * Convert.ToDouble(textBoxPercentSGST.Text) / 100;
            textBoxSgstAmount.Text = sgstamount.ToString();

            double Total = Convert.ToDouble(textBoxPrice.Text) * Convert.ToDouble(textBoxQuantityRequired.Text);
            double totalprice = Total + cgstamount + sgstamount;
            textBoxTotalPrice.Text = totalprice.ToString();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCash.Checked)
            {
                textBoxPaidAmount.Text = textBoxTotalPrice.Text;
                textBoxNetAmount.Text = textBoxTotalPrice.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPaidAmount.Text = "";
            textBoxNetAmount.Text = "";
            if (textBoxPaidAmount.Text=="")
            {
                MessageBox.Show("Please fill price ");
            }
            
           
           
        }

        public void net_amount()
        {
            double price = Convert.ToDouble(textBoxTotalPrice.Text);
            double total = Convert.ToDouble(textBoxPaidAmount.Text);
            if(price>total)
            {
                double amount = price - total;
                textBoxNetAmount.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("Fill Price properly ");
            }
            
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            net_amount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        public void clear_all()
        {
            textBoxProductName.Clear();
            textBoxAvailableQuantity.Clear();
            textBoxTotalQuantity.Clear();
            textBoxPrice.Clear();
            textBoxQuantityRequired.Clear();
            textBoxTotalPrice.Clear();
            textBoxPercentCGST.Clear();
            textBoxPercentSGST.Clear();
            textBoxCGSTAmount.Clear();
            textBoxSgstAmount.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxMobileNo.Clear();
            
            textBoxSoldPersonId.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
