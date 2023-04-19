using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeform
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
            int counter,flag=0;
            for (counter = 2; counter < n1; counter++)
            {
                if (n1 % counter == 0)
                {
                    flag = 1;
                    break;
                }
            }
                if (flag == 0) 
                {
                    label2.Text = ("is a prime number");
                }
                else 
                { 
                    label2.Text = ("is not a prime number"); 
                }
            
        }
    }
}
