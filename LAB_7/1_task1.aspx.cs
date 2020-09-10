using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB71
{
    public partial class task1 : System.Web.UI.Page
    {
        List<int> arr;
        protected void Page_Load(object sender, EventArgs e)
        {
            arr = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                arr.Add(i + 1);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var outp = arr.Where(n => n % 2 == 0);
            Label1.Text = "";
            foreach(var i in outp)
            {
                Label1.Text += i.ToString() + " ";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var outp = arr.Where(n => n % 2 == 1);
            Label1.Text = "";
            foreach (var i in outp)
            {
                Label1.Text += i.ToString() + " ";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var outp = arr;
            Label1.Text = "";
            foreach (var i in outp)
            {
                Label1.Text += i.ToString() + " ";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var outp = arr.Max();
            Label1.Text = "";
            Label1.Text += outp.ToString() + " is Maximum and ";
            outp = arr.Min();
            Label1.Text += outp.ToString() + " is Minimum";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var outp = arr.Average();
            Label1.Text = "";
            Label1.Text += outp.ToString() + " is Average";
        }
    }
}