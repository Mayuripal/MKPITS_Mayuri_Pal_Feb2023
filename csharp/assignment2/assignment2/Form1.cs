using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int []arr=new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter<arr.Length)
            {
                arr[counter] = Convert.ToInt32(textBox3.Text);
                counter++;
            }

            else if (counter>arr.Length) 
            {
                button1.Enabled = false;
            }
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
