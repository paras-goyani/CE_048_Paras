using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if(username.Text=="a" && pass.Text=="a")
            {
                Session["username"] = username.Text;
                Session["pass"] = pass.Text;
                Response.Redirect("home.aspx");
            }
            else
            {
                Label1.Text = "username or password is incorrect !!";
            }
        }
    }
}