using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        char op;
        int result=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+"2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+"3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1 + "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           switch(op)
            {
                case '+':
                    result = Convert.ToInt32(textBox1.Text + textBox1);
                    break;
            }
        }
    }
}
