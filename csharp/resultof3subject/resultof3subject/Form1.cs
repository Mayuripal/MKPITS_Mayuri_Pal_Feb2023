using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resultof3subject
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
            int n3=Convert.ToInt32(textBox3.Text);
            int total=n1 + n2+ n3;
            label4.Text = "total :" + total;
            float per = (total / 300f) * 100f;
            label5.Text = "percentage :" + per;
            if(per >= 85) { label6.Text = "grade :distinction"; }
            else if(per >= 60) { label6.Text = "grade :firstclass"; }
            else { label6.Text = "grade :fail"; }
        }
    }
}
