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

namespace Student_detail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = "male";
            }
            else if (radioButton2.Checked) 
            {
                gender = "female";
            }
            label8.Text = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text,gender,textBox3.Text,textBox4.Text,dateTimePicker1.Text,comboBox1.Text);
            clearall();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = DatabaseConnection.UpdateUsers(textBox2.Text,Convert.ToInt64(textBox3.Text));
            clearall();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = DatabaseConnection.DeleteUsers(textBox1.Text);
            clearall();
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           /////connected
            //SqlDataReader dr = DatabaseConnection.Getcity();
            //while (dr.Read()) { comboBox1.Items.Add(dr["cityname"].ToString()); }
                    
                    /////disconnected
            DataSet ds = DatabaseConnection.GetCity();
            foreach (DataRow dr in ds.Tables["city"].Rows)
            {
                comboBox1.Items.Add(dr["cityname"].ToString());
            }
                    /////grid view
            DataSet dsa = DatabaseConnection.GetStudDetail();
            dataGridView1.DataSource = dsa.Tables[0];
        }

        /// search button
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet sds = DatabaseConnection.SearchStudent(textBox1.Text);
            dataGridView1.DataSource = sds.Tables[0];
        }
    }
}
