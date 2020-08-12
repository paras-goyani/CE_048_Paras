using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Label1.Text = Session["username"].ToString();


            }
            else 
            {
                Response.Redirect("~/ login.aspx");
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String[] EleNames = { "Laptop , price=50000", "Pendrive ,Price = 999", "Smart Phone ,price=9999" };
            String[] EleValues = { "50000", "999", "9999" };

            String[] BooNames = { "Zindagi-Zindagi , price=499", "Mosad ,Price = 600", "Aghor Nagara Vage ,price=589" };
            String[] BooValues = { "499", "600", "589" };

            if (RadioButtonList1.SelectedIndex == 0)
            {
                list.Items.Clear();

                int i = 0;
                for (i = 0; i < 3; i++)
                {
                    list.Items.Add(EleNames[i]);
                    list.Items[0].Value = EleValues[i];
                }

            }

            if (RadioButtonList1.SelectedIndex == 1)
            {
                list.Items.Clear();

                int i = 0;
                for (i = 0; i < 3; i++)
                {
                    list.Items.Add(BooNames[i]);
                    list.Items[0].Value = BooValues[i];
                }

            }

        }

        

        protected void place_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected)
                {
                    Session[j + "name"] = list.Items[i].Text;
                    Session[j + "value"] = list.Items[i].Value;

                    Session["extra"] += list.Items[i].Text;

                    j++;
                }
            }
            Session["count"] = j;
            Response.Redirect("~/order.aspx");
        }
    }
}