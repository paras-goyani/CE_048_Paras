using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                //Label2.Text = Session["extra"].ToString();
               

                int count = int.Parse(Session["count"].ToString());
                if (count > 0)
                {
                    int i;
                    int price=0;
                 
                    Label1.Text = "your Selected Item :<br/>";
                    for (i = 0; i < count; i++)
                    {
                        
                        Object temp = Session[i+"name"];
                        Label1.Text += (string)temp +"<br/>";

                        Object temp1 = Session[i+"value"];
                        string exe = (string)temp1;

                        
                        price +=int.Parse( exe) ;
                    }

                    

                    Label1.Text += "your Total Bill = " + price;

                    

                }
                else
                {
                    Label1.Text = "you have selected no item";
                }
            }

            Session.Clear();
            Session.Abandon();

        }
    }
}