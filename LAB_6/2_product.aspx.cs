using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace LAB6
{
    public partial class product : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            con = new SqlConnection();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            foreach (ListItem lt in ListBox2.Items)
            {

                
                if (lt.Selected == true)
                {
                    Label2.Text += lt.Value + " ";
                    try
                    {
                        using (con)
                        {
                            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
                            con.Open();
                            string query = "INSERT INTO [order] (userid, pid) values (@userid, @pid)";
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@userid", Session["username"]);
                            cmd.Parameters.AddWithValue("@pid", lt.Value);
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            
                        }
                    }
                    catch(Exception err)
                    {
                        Label2.Text = "During place order, Error ocuured due to " + err.Message;
                    }
                    
                }
            }
            con.Close();
            Response.Redirect("order.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}