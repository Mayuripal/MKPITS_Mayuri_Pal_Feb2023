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
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class Form1 : Form
    {
        //creating an Nationality enum
        enum Nationality { Indian, NRI }
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;                                     //for todays date
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                                                                        //product category
            DataSet ds = ProductStore.GetProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "Product_Category_ID";                                              //for product category id in invoice detail table 
        }
            //initialize values
             int cgst = 0;
             int sgst = 0;
             int igst = 0;
             int tgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                                                                                        //product name
            DataSet ds = ProductStore.GetProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "product_name";
            comboBox2.ValueMember = "Product_ID";                                                    //for product id in invoice detail table

                                                                                     
            DataSet ds2 = ProductStore.GetPercentGst(comboBox1.Text);                   //percent gst
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["CGST"].ToString());
                sgst = Convert.ToInt32(dr["SGST"].ToString());                                      //convert stringproduct category to int 
                igst = Convert.ToInt32(dr["IGST"].ToString());
            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else                                                                      // if else for nationality condition
            {
                tgst = igst;
            }
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = igst.ToString();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
                                                                                                     //quantity
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                                                                                                    //contact details
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                                                                                                    //product price
            DataSet ds3 = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                textBox9.Text = dr["Product_Price"].ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {                                                                                           //selected radio button 1
            nationality = Nationality.Indian;
                                                                                                    // % GST
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text));
            calculate_total();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {                                                                                            //selected radio button 2
            nationality = Nationality.NRI;
                                                                                                    // % GST
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = igst.ToString();
            calculate_total() ;

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }

                                                                                                               //creating a method  calculate_total
            public void calculate_total()
            {
                double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);                    //price*quantity
                textBox11.Text = totalamount.ToString();

                double cgstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox6.Text) / 100.0);            //amount cgst = price * %cgst
                textBox3.Text = cgstamount.ToString();

                double sgstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox7.Text) / 100.0);            //amount sgst = price * %sgst
                textBox4.Text = sgstamount.ToString();

                double igstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox8.Text) / 100.0);             //amount igst = price * %igst
                textBox5.Text = igstamount.ToString();

                double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox5.Text);                       //netamount=totalamount * igst
                textBox12.Text = netamount.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUserDetail();                                                                                          // insert data( save button )
        }
        public void CheckUserDetail ()
        {
            if (textBox1.Text == "" || textBox2.Text == "" )                                                             // validations
            {
                MessageBox.Show("please fill all the details");
            }
            else if (textBox10.Text == "0") 
            {
                MessageBox.Show("quantity cannot be zero");
            }
            else
            {
                string result = ProductStore.InsertInvoiceDetailS(textBox2.Text, textBox1.Text,Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality),dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text),
                    Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox6.Text),Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), 
                    Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text),Convert.ToDecimal(textBox11.Text));
                    
                    MessageBox.Show(result);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();                                                                                                 // reset button
        }

        public void clearall()
        {
            textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();
            textBox5.Clear();textBox6.Clear();textBox7.Clear();textBox8.Clear();
            textBox9.Clear();textBox10.Clear();textBox11.Clear();textBox12.Clear();
            comboBox1.Text=" ";comboBox2.Text=" ";
        }
    }
}

