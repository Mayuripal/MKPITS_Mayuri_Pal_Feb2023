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
        enum Category { Student,ITProfessional }
        Category category;
        enum Gender { Male ,Female ,Other }
        Gender gender;
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
            comboBox1.ValueMember = "Nationid";
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // For statename in combobox 2
            DataSet ds1 = CourseRegistration.GetState(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "Statename";
            comboBox2.ValueMember = "Stateid";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // For city name in combobox3
            DataSet ds2 = CourseRegistration.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "Cityname";
            comboBox3.ValueMember = "Cityid";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            category = Category.Student;
            textBox3.Clear();
            textBox4.Clear();
            double studentfee = 1000;
            textBox2.Text = studentfee.ToString();
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = Category.ITProfessional;
            textBox3.Clear();
            textBox4.Clear();
            double ITProff = 3000;
            textBox2.Text = ITProff.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        double perc = 0;
        double total = 0;
        double Balance = 0;

        public void check_balance_amount()
        {
             total =Convert.ToDouble(textBox2.Text);
            
            double paid=Convert.ToDouble(textBox3.Text);
            if(category ==0)
            {
                perc = total * 0.5;
            }
            else
            {
                perc = total * 0.8;
            }
            if(Convert.ToDouble(textBox3.Text)<perc)
            {
                MessageBox.Show("Paid Amount should be atleast 50% for student and 80% for II Professional");
            }
            else
            {
                 Balance = Convert.ToDouble(textBox2.Text)-Convert.ToDouble(textBox3.Text);
                textBox4.Text = Balance.ToString();
            }
            if (paid>total)
            {
                MessageBox.Show("Enter proper amount ");
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();

            string result = CourseRegistration.Inserttablecourseregdetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);

            result = CourseRegistration.Inserttableregaddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);

            result=CourseRegistration.InsertTableFeeDetail(Convert.ToDouble(textBox2.Text),perc,Convert.ToInt32(textBox3.Text),Convert.ToDouble(textBox4.Text),dateTimePicker1.Value);
            MessageBox.Show(result);
        }

        public void check()
        {
            if (textBox1.Text == " " || textBox3.Text == "")
            {
                MessageBox.Show("Fill all the details");
            }
            else
            {
                MessageBox.Show(" Record Inserted Sucessfull ");
            }
        }
    }
    
}
