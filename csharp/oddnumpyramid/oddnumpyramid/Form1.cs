﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oddnumpyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stringbuilder class is used to append new string to existing string
            StringBuilder sb = new StringBuilder();
            int height = Convert.ToInt32(textBox1.Text);
            for (int innercounter = 1; innercounter <= height; innercounter++)
            {
                for (int outtercounter = 1; outtercounter <= height - innercounter; outtercounter++)
                {
                    sb.Append(" ");
                }
                for (int k = 1; k <= 2 * innercounter - 1; k++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label2.Text= sb.ToString();

        }
    }
}
