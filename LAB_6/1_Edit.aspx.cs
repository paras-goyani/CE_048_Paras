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
    public partial class Edit : System.Web.UI.Page
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
                        rdr.Close();
                        if (temp == 0)
                            extra.Text = "no record found";
                    }
                }
                catch (Exception err)
                {
                    //Handle execeptions if any
                    lname.Text = "Error reading the datastore: ";
                    lname.Text += err.Message;
                }
            
        }

        protected void fetch_Click(object sender, EventArgs e)
        {
            if (temp > 0)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;

                try
                {

                    using (con)
                    {

                        int id1 = int.Parse(id.SelectedValue);

                        string command = "Select * from student WHERE id='" + id1 + "'";

                        SqlCommand cmd = new SqlCommand(command, con);
                        con.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();

                        rdr.Read();

                        lname.Visible = true;
                        name.Visible = true;
                        lmobile_no.Visible = true;
                        mobile_no.Visible = true;
                        lemail_id.Visible = true;
                        email_id.Visible = true;
                        lsem.Visible = true;
                        sem.Visible = true;
                        sedit.Visible = true;

                        name.Text = rdr["name"].ToString();
                        sem.SelectedValue = rdr["sem"].ToString();
                        mobile_no.Text = rdr["mobile_no"].ToString();
                        email_id.Text = rdr["email_id"].ToString();


                        rdr.Close();
                        con.Close();

                    }
                }
                catch (Exception err)
                {
                    //Handle execeptions if any
                    lname.Text = "Error reading the datastore: ";
                    lname.Text += err.Message;
                }
            }
            else 
            {
                extra.Text = "no record found";
            }
        }

        protected void sedit_Click(object sender, EventArgs e)
        {

            string command;
            int id1 = int.Parse(id.SelectedValue);
            command = "Update student Set ";
            command += "name=@name,mobile_no=@mobile_no, sem=@sem, email_id=@email_id where id='"+id1+"'";
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            SqlCommand cmd = new SqlCommand(command, con);

            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@mobile_no", mobile_no.Text);
            cmd.Parameters.AddWithValue("@sem", sem.SelectedValue);
            cmd.Parameters.AddWithValue("@email_id", email_id.Text);
            

            int updated = 0;
            try
            {
                using (con)
                {
                    con.Open();
                    updated = cmd.ExecuteNonQuery();
                    complete.Text = updated.ToString() + " record updated.";
                }
            }
            catch (Exception err)
            {
                
            }

            
        }
    }
}