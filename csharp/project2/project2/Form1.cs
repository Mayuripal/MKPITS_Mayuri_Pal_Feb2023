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

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // DataSet ds = student.GetCountryName();
            //foreach(DataRow dr in ds.Tables[0].Rows)
            //{
            //    comboBox1.Items.Add(dr["countryname"].ToString());
            //}
            //comboBox1.DataSource = ds.Tables["country"];
            //comboBox1.DisplayMember = "countryname";

            DataSet ds2 = student.GetCoursename();
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.DisplayMember = "coursename";


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
