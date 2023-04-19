using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detailform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            switch(country) 
            {
                case "India":
                    comboBox2.Items.Add("maharashtra");
                    comboBox2.Items.Add("rajasthan");
                    comboBox2.Items.Add("bengal");
                    break;
                case "America":
                    comboBox2.Items.Add("alaska");
                    comboBox2.Items.Add("texas");
                    comboBox2.Items.Add("florida");
                    break;
                case "Africa":
                    comboBox2.Items.Add("nigeria");
                    comboBox2.Items.Add("egypt");
                    comboBox2.Items.Add("benin");
                    break;
                
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text += "Name : " + textBox1.Text + "\n";

            label4.Text += "phone no : " + maskedTextBox1.Text + "\n";

            label4.Text += "dob : " + dateTimePicker1.Text + "\n";

            label4.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";

            label4.Text = "country : " + comboBox1.Text + "\n";

            label4.Text += "state : " + comboBox2.Text + "\n";

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }


    }
}
