using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankbalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            int dep;
            int amt=Convert.ToInt32(textBox2.Text);
            if (amt>0)
            {
                dep=bal+amt;
                label3.Text = "Amount deposited, your balance is :" + dep;
            }
            else
            {
                label3.Text = ("enter amount greater than 0 ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bal=1000;
            int wid;
            int amt =Convert.ToInt32(textBox2.Text);
            if (amt<=bal) 
            {
                wid=bal-amt;
                label3.Text = ("amount with balance is :" + wid);
            }
            else { label3.Text = ("enter amount less than your balance"); }
        }
    }
}
