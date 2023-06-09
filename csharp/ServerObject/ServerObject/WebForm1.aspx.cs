using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform 1");
            Server.Execute("Webform2.aspx");
            Response.Write("Welcome back to webform 1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform 1");
            Server.Transfer("Webform2.aspx");
            Response.Write("Welcome back to webform 1");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<H1> is an example of a Heading tag </ H1 > "));

            //if not written in html encode
            //Response.Write("<H1> is an example of a Heading tag </ H1 > ");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost / code / webform2.aspx"));
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("John Saunders");

            Response.Redirect("webform3.aspx?name=" + name);
            // name will be shown on address /url bar
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("John Saunders");

            String password = Server.UrlEncode("king");

            Response.Redirect("webform3.aspx?name = " + name + " & password = " + password);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath("/webform3.aspx"));
        }
    }
    
}