using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPproj4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2, res = 0;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);

            string op = TextBox3.Text;
             
            switch (op)
            {
                case "+":
                    res=num1 + num2;
                    break;
                case "-":
                    res=num1 - num2;
                    break;
                case "*":
                    res=num1 * num2;
                    break;
                case "/":
                    res=num1 / num2;
                    break;
               
            }
            Label1.Text = res.ToString();
        }
    }
}