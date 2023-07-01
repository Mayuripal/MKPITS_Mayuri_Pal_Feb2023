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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //fill list box with product name
            DataSet ds = Invoice.GetProduct();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to fill detaild according to selected product
            DataSet ds1 = Invoice.GetProductDetail(listBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            { 
                textBox1.Text = dr["Name"].ToString();
                textBox2.Text = dr["AVAILABLE_QTY"].ToString();
                textBox3.Text = dr["SELL_QTY"].ToString();
                textBox4.Text = dr["PRICE_PER_UNIT"].ToString();
                textBox7.Text = dr["CGST"].ToString();
                textBox8.Text = dr["SGST"].ToString();

            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {   //calculate gst and total amount
            double cgstamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox7.Text) / 100;
            textBox9.Text = cgstamount.ToString();

            double sgstamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox8.Text) / 100;
            textBox10.Text = sgstamount.ToString();

            double Total = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text);
            double totalprice = Total + cgstamount + sgstamount;
            textBox6.Text = totalprice.ToString();
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
            if(radioButton4.Checked)
            {
                textBox14.Text = textBox6.Text;
                textBox15.Text = textBox6.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox15.Text = "";
            if (textBox14.Text=="")
            {
                MessageBox.Show("Please fill price ");
            }
            
           
           
        }

        public void net_amount()
        {
            double price = Convert.ToDouble(textBox6.Text);
            double total = Convert.ToDouble(textBox14.Text);
            if(price>total)
            {
                double amount = price - total;
                textBox15.Text = amount.ToString();
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            
            textBox16.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
