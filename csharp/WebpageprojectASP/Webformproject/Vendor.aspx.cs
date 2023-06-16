using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; 
using StoreLibrary;
using System.Data.Common;

namespace Webformproject
{
    public partial class Vendor1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getVendor_Id();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = DbConnection.insertVendor_Mast(TextBox2.Text);
            Label1.Text = res;
            getVendor_Id();
            TextBox1.Text = "";

        }
        public void getVendor_Id()
        {
            int res = Convert.ToInt32(DbConnection.getVendor_Id());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string res = Class1.(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            //Label1.Text = res;
        }
    }
}