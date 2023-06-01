using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPproj8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("User name : "+TextBox1.Text+"<br>");
            sb.Append("Password : "+TextBox2.Text+"<br>");
            sb.Append("Age : "+TextBox4.Text+"<br>");
            sb.Append("Email : "+TextBox5.Text+"<br>");
            sb.Append("Date of Birth : "+TextBox6.Text+"<br>");
           if(Page.IsValid)
           { Label1.Text = sb.ToString(); }
           else { Label1.Text = "Page is not valid "; }
            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string val = args.Value;
            int len = args.Value.Length;
            // Response.Write(&quot;len &quot; + len);
            if (len == 10)
            {
                string d = val.Substring(0, 2);
                // Response.Write(&quot;dd &quot; + d);
                int dd = Convert.ToInt32(d);
                if (dd  > 31)

                {
                    args.IsValid = false;
                }
                else
                {
                    string m = val.Substring(3, 2);
                    //Response.Write(&quot; mm & quot; +m);
                    int mm = Convert.ToInt32(m);
                    if (mm > 12)
                    {
                        args.IsValid = false;
                    }
                    else
                    {
                        string y = val.Substring(6, 4);
                        // Response.Write(&quot;yy &quot; + y);
                        //int mm = Convert.ToInt32(y);
                        int yl = y.Length;
                        if (yl == 4)
                        {
                            args.IsValid = true;
                        }
                        else
                        {
                            args.IsValid = false;
                        }
                    }
                }
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}