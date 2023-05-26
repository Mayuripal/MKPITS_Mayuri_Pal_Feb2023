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
using System.CodeDom;

namespace MachineTest1
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian,NRI }
        Nationality nationality;

        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate=DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Productstore.GetProductCatergory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember="Product_Type_Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds= Productstore.GetProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";


            DataSet ds1 = Productstore.GetPercentGst(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["CGST"].ToString());
                sgst = Convert.ToInt32(dr["SGST"].ToString());
                igst = Convert.ToInt32(dr["IGST"].ToString());
            }
            if (nationality==0)
            {
                tgst = igst;
            }
            else
            {
                tgst = cgst + sgst;
            }
            textBox3.Text=cgst.ToString();
            textBox4.Text=sgst.ToString();
            textBox5.Text=tgst.ToString();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = Productstore.GetProductPrice(comboBox2.Text);
            foreach(DataRow dr in ds2.Tables[0].Rows)
            {
                textBox9.Text = dr["Product_Price"].ToString();  
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality =Nationality.Indian;

            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(cgst)+Convert.ToInt32(sgst));


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;

            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculatetotal();
            }

        }
       

        public void calculatetotal()
        {
            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = totalamount.ToString();

            double cgst_amount= (Convert.ToDouble(textBox9.Text)*Convert.ToDouble(textBox3.Text)/100.0);
            textBox6.Text = cgst_amount.ToString();

            double sgst_amount= (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text)/100.0);
            textBox7.Text = sgst_amount.ToString();

            double igst_amount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = igst_amount.ToString();

            double net_amount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            textBox12.Text = net_amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkdetail();
        }

        public void checkdetail()
        {
            if(textBox1.Text== "" || textBox2.Text=="")
            {
                MessageBox.Show("please fill customer details properly");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("please input quantity");
            }
        }
    }
}
