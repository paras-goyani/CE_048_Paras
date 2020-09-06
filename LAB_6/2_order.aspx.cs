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
    public partial class order : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            Label1.Text = "Welcome " + Session["username"];

            try
            {
                using (con)
                {
                    con.Open();
                    string query = "SELECT Product.pid, Product.pname, Product.description, Product.cost FROM Product INNER JOIN [order] ON Product.pid = [order].pid and [order].userid = @userid";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@userid", Session["username"]);
                    cmd.CommandText = query;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    int total = 0;
                    while (rdr.Read())
                    {
                        Label3.Text += "Product ID: " + rdr["pid"].ToString() + " Product Name: " + rdr["pname"].ToString() + " Cost: " +
                            rdr["cost"].ToString() + "<br>";
                        total += int.Parse(rdr["cost"].ToString());
                    }
                    Label2.Text = "Order Total : " + total.ToString();
                }
            }
            catch(Exception err)
            {
                Label2.Text = "Error occured due to " + err.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}