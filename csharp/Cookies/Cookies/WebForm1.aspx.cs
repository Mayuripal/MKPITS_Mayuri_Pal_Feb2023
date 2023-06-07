using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook1");
            cookie.Values.Add("username",TextBox1.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "Temperory cookie added to client machine";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null )
            {
                string name = cookie.Values["username"].ToString();
                Label1.Text = "username "+ name;
            }
            else
            {
                Label1.Text = "No cookies exist";
            }
        }
    }
}