using ClassLibraryTrust;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrustProject
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getDepartmentId();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.insertDepartment_Mast(TextBox2.Text);
            Label1.Text = res;
            getDepartmentId();
            TextBox1.Text = " ";
        }

        public void getDepartmentId()
        {
            int res = Convert.ToInt32(DepartmentClass.getDepartment_Id());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res =DepartmentClass.updateDepartment_Mast(TextBox2.Text,Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.deleteDepartment_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = DepartmentClass.searchDepartment_Mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}