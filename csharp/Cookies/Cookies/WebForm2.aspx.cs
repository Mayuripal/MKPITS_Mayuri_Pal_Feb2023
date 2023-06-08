using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temperory cookie
            HttpCookie cookie1 = new HttpCookie("cook2");
            cookie1.Values.Add("username : " ,TextBox1.Text);
            //cookie1.Values.Add("email : " ,TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 3, 0);
            cookie1.Expires = dt.Add(ts);
            Label1.Text = "Permanent cookies added to client machine";
            Response.Cookies.Add(cookie1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrive cookie from client machine
            HttpCookie cookie1 =Request.Cookies["cook2"];
            if (cookie1 != null)
            {
                string name = cookie1.Values["username"].ToString();
                //string email = cookie1.Values["email"].ToString();

                Label1.Text =name;
                //Label1.Text = "email : " + email;
            }
            else
            {
                Label1.Text = "No permanent cookies exist";
            }
        }
    }
}