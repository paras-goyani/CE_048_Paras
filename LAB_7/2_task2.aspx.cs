using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB71
{
    public partial class task2 : System.Web.UI.Page
    {
        string[] arr = { "Kalathiya", "Kamani", "Bhuva", "Vaghasia", "Vaghela", "Pipaliya", "Devani", "Goyani", "Gediya", "Bhadiyadara", "lol" };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var o = arr.Where(n => n[0] == 'K' || n[0] == 'k');
            Label1.Text = "";
            foreach(var i in o)
            {
                Label1.Text += i + " ";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var o = arr.Where(n => n.Length < 4);
            Label1.Text = "";
            foreach (var i in o)
            {
                Label1.Text += i + " ";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var o = arr.Where(n => n.Length == 3);
            Label1.Text = "";
            foreach (var i in o)
            {
                Label1.Text += i + " ";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var o = arr.OrderBy(n => n);
            Label1.Text = "";
            foreach (var i in o)
            {
                Label1.Text += i + " ";
            }
        }
    }
}