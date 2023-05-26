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

namespace CourseRegistration
{
    public partial class Form1 : Form
    {
        enum Category { Student,ITProffectional }
        Category category;
        public Form1()
        {
            InitializeComponent();
            //for todays date
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // For nation name in combobox1
            DataSet ds = CourseRegistration.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Nationname";
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For statename in combobox 2
            DataSet ds1 = CourseRegistration.GetState(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "Statename";
            //comboBox2.ValueMember = "Stateid";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // For city name in combobox3
            DataSet ds2 = CourseRegistration.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "Cityname";
            //comboBox2.ValueMember = "Cityid";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = Category.Student;
            double studentfee = 1000;
            textBox2.Text = studentfee.ToString();
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = Category.ITProffectional;
            double ITProff = 3000;
            textBox2.Text = ITProff.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double balance=Convert.ToDouble(textBox2.Text)-Convert.ToDouble(textBox3.Text);
            textBox4.Text = balance.ToString();
        }
    }
    
}
