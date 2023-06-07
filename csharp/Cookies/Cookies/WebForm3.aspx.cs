using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null)
            {
                string name = cookie.Values["username"].ToString();
                Label2.Text = "username " + name;
            }
            else
            {
                Label2.Text = "No cookies exist";
            }
        }
    }
}