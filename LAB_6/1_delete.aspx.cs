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
    public partial class delete : System.Web.UI.Page
    {
        int temp = 0;
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
                        while (rdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = rdr["id"].ToString();
                            id.Items.Add(item);
                            temp += 1;
                        }
                        if(temp == 0)
                        Label1.Text = "no record found ";
                        rdr.Close();

                    }
                }
                catch (Exception err)
                {
                    //Handle execeptions if any
                    Label1.Text = "Error reading the datastore: ";
                    Label1.Text += err.Message;
                }
            

        }

        protected void delete_record_Click(object sender, EventArgs e)
        {
            if (temp > 0)
            {
                int id1 = int.Parse(id.SelectedValue);
                string command;
                command = "Delete from student  Where id=@id";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
                SqlCommand cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@id", id.SelectedValue);

                int deleted = 0;
                try
                {
                    using (con)
                    {
                        con.Open();
                        deleted = cmd.ExecuteNonQuery();
                        Label1.Text = "id = " + id1 + " record deleted.";
                        
                    }
                }
                catch (Exception err)
                {
                    //Handle execeptions if any
                    Label1.Text = "Error deleting from the datastore: ";
                    Label1.Text += err.Message;
                }
            }
            else
            {
                Label1.Text = "no record found";
            }
            
        }
    }
}