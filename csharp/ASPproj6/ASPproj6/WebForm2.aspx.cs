using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPproj6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Rajasthan");
                    break;
                case "Nepal":
                    DropDownList2.Items.Add("Bagmati");
                    DropDownList2.Items.Add("Gandaki");
                    break;

            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            switch (DropDownList2.Text)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Mumbai");
                    break;
                case "Rajasthan":
                    DropDownList3.Items.Add("Jaipur");
                    DropDownList3.Items.Add("Ajmer");
                    break;
                case "Bagmati":
                    DropDownList3.Items.Add("Khatmandu");
                    DropDownList3.Items.Add("Bidur");
                    break;
                case "Gandaki":
                    DropDownList3.Items.Add("Pokhara");
                    DropDownList3.Items.Add("Waling");
                    break;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("City : " + DropDownList3.Text + "<br>");
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    sb.Append("Course : "+li.Value +"<br>");
                }
            }
            sb.Append("Center : " + ListBox1.SelectedItem.ToString() + "<br>");
            
            Label1.Text = sb.ToString();
        }
    }
}