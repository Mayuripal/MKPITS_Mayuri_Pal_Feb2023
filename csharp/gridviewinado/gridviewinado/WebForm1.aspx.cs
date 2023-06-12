using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace gridviewinado
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dtable");
            DataRow dr;

            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("DOA", typeof(DateTime)));

            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "pranay";
            dr[2] = DateTime.Now;

            dt.Rows.Add(dr);

            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dtable"].DefaultView;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(TextBox1.Text);
            double paid = Convert.ToDouble(TextBox2.Text);
            double ramount = total - paid;
            double eamount = ramount / 3;
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable("emitable");
            DataRow dr;

            dt1.Columns.Add(new DataColumn("Sr no.", typeof(int)));
            dt1.Columns.Add(new DataColumn("Product", typeof(string)));
            dt1.Columns.Add(new DataColumn("Instalments", typeof(double)));
            for (int i = 1; i <= 3; i++)
            {
                dr = dt1.NewRow();
                dr[0] = i;
                dr[1] = "Shreya";
                dr[2] = eamount;
                dt1.Rows.Add(dr);
            }
            ds1.Tables.Add(dt1);
            GridView2.DataSource = ds1.Tables["emitable"].DefaultView;
            GridView2.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(TextBox1.Text);
            double paid = Convert.ToDouble(TextBox2.Text);
            double ramount = total - paid;
            double eamount = 0;

            if (RadioButton1.Checked)
            {
                if (ramount > 0)
                {
                    Label1.Text = "please pay full amount in cash";
                }
            }

            else if (RadioButton2.Checked)
            {

                if (ramount > 0)
                {
                    eamount = ramount / 3.0;
                }
               
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("emitable");
            DataRow dr;
            dt.Columns.Add(new DataColumn("srno", typeof(int)));
            dt.Columns.Add(new DataColumn("productname", typeof(string)));
            dt.Columns.Add(new DataColumn("emi amount", typeof(decimal)));
            for (int i = 1; i <= 3; i++)
            {
                dr = dt.NewRow();
                dr[0] = i;
                dr[1] = "mouse";
                dr[2] = eamount;
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);
            GridView2.DataSource = ds.Tables["emitable"].DefaultView;
            GridView2.DataBind();
        }
    }
}