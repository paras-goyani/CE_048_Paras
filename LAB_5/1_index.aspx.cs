using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab51
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            if (Label1.Text == "")
            {
                Label1.Text = "enter some text which you want to store in cookie";
            }
            else
            {
                HttpCookie name = new HttpCookie("per");
                name.Value = t1.Text;
                name.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Add(name);

                Label1.Text = "cokkie is created";
            }

            

        }

        protected void retrive_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["per"] != null)
            {
                t2.Text = Request.Cookies["per"].Value;
            }
            else
            {
                t2.Text = "cookie not available";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["per"];
            if (Request.Cookies["per"] != null)
            {
                name.Expires = DateTime.Now.AddMinutes(-1);

                Response.Cookies.Add(name);
                t3.Text = "cookie is deleted";
            }
            else
            {
                t3.Text = "cookie not available";
            }
        }
    }
}