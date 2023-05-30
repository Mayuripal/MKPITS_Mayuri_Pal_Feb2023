using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceGeneration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataSet ds = Invoice.GetProduct();
            listBox1.DataSource = ds.Tables[0].Rows;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
        }
    }
}
