using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            comboBox3.Text = " ";

            switch (comboBox1.Text)
            {
                case "Pathaan":
                    comboBox2.Items.Add("PVR");
                    comboBox2.Items.Add("SUDAMA");
                    break;
                case "War":
                    comboBox2.Items.Add("INOX");
                    comboBox2.Items.Add("LIBERTY");
                    break;
                case "URI":
                    comboBox2.Items.Add("SMIRITI");
                    comboBox2.Items.Add("ALANKAR");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = " ";
            //textBox1.Text = "0";

            switch (comboBox2.Text)
            {
                case "PVR":
                    comboBox3.Items.Add("12AM-3PM");
                    comboBox3.Items.Add("1PM-4PM");
                    textBox5.Text = "120";
                    break;
                case "SUDAMA":
                    comboBox3.Items.Add("2PM-5PM");
                    comboBox3.Items.Add("12AM-3PM");
                    textBox5.Text = "260";
                    break;
                case "INOX":
                    comboBox3.Items.Add("6PM-9PM");
                    comboBox3.Items.Add("1PM-4PM");
                    textBox5.Text = "310";
                    break;
                case "LIBERTY":
                    comboBox3.Items.Add("12AM-3PM");
                    comboBox3.Items.Add("1PM-4PM");
                    textBox5.Text = "270";
                    break;
                case "SMIRITI":
                    comboBox3.Items.Add("2PM-5PM");
                    comboBox3.Items.Add("12AM-3PM");
                    textBox5.Text = "280";
                    break;
                case "ALANKAR":
                    comboBox3.Items.Add("6PM-9PM");
                    comboBox3.Items.Add("1PM-4PM");
                    textBox5.Text = "320";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            textBox1.Text=comboBox1.Text;
            textBox2.Text =comboBox2.Text;
            textBox3.Text =comboBox3.Text;
            
            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new Online_Booking(Convert.ToInt32(numericUpDown1.Value),Convert.ToSingle(textBox5.Text));
            }
            else if (radioButton2.Checked)
            {
                mt = new Boxoffice_Booking(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox5.Text));
            }
            
            textBox4.Text = mt.Calculate_Ticket_Price() ;
            label13.Text = "Enjoy your movie ";
        }

       
    }
}
