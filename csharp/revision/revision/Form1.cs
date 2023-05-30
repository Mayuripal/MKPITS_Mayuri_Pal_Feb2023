using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = student2.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Nationname";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1=student2.GetState(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "Statename";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = student2.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "Cityname";
        }
    }
}
