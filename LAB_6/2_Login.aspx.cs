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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    string query = "select * from [user]";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read()){
                        if(sdr["password"].ToString() == TextBox2.Text && sdr["userid"].ToString() == TextBox1.Text)
                        {
                            Session["username"] = TextBox1.Text;
                            Response.Redirect("product.aspx");
                        }
                    }
                    Label1.Text = "Invalid username or password.";
                    con.Close();
                }
            }
            catch(Exception err)
            {
                Label1.Text = "Error occured due to " + err.Message;
            }
        }
    }
}