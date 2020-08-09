using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4_e
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Equals("admin") && password.Text.Equals("admin"))
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Label3.Text = "incorrect crendential";
            }
        }
    }
}