using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from student";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        GridViewStudent.DataSource = rdr;
                        GridViewStudent.DataBind();
                    }
                    else
                    {
                        lblInfo.Text = "no record found";
                    }
                    
                }
            }
            catch (Exception err)
            {
            
                lblInfo.Text = "Error reading the datastore: ";
                lblInfo.Text += err.Message;
            }
           
        }
    }
}