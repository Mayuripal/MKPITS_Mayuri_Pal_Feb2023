using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for nation name in combobox1
            DataSet ds = Database.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "F2";

        }
    }
}
