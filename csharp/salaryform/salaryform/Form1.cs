using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaryform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox2.Text);
            float hra = n *0.35f ;
            label3.Text = ("HRA ="+hra);
            float da = n * 0.45f;
            label4.Text = ("da =" + da);
            float total = n + da + hra;
            label5.Text = ("Total salary :" + total);
        }
    }
}
