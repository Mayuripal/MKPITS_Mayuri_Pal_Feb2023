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
            DataSet ds = Invoice.GetProduct();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        {
            double Totalprice = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text);
            textBox6.Text = Totalprice.ToString();

            double cgstamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox7.Text) / 100;
            textBox9.Text = cgstamount.ToString();

            double sgstamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox8.Text) / 100;
            textBox10.Text = sgstamount.ToString();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
