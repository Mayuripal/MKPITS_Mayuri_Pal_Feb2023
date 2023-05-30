using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int total = 0;
             float   perc = 0;
            total = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text);
            Label1.Text = total.ToString();

            perc = (total * 100 )/300;
            Label2.Text = perc.ToString();

            if(perc <= 45)
            {
                Label3.Text = "D";
            }
            else if (perc >45 || perc <65)
            { 
                Label3.Text= "C";
            }
            else if (perc > 65 || perc < 85)
            {
                Label3.Text = "B";
            }
            else if (perc >85 )
            {
                Label3.Text= "A";
            }

        }
    }
}