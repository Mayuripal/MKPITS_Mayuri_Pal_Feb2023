using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greaterorsmaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            if (n1 > n2) { label3.Text = (n1 + " is greater than " + n2); }
            else { label3.Text = (n2 + " is greater than " + n1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1= Convert.ToInt32(textBox1.Text);
            int n2= Convert.ToInt32(textBox2.Text); 
            if (n1>n2) { label3.Text = (n2 + " is smaller than " + n1); }
            else { label3.Text = (n1 + " is smaller than " + n2); }
        }
    }
}
