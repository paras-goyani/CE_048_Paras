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
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            //Label1.Text += "in method";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            try
            {
               
                using (con)
                {
                    //Label1.Text += "in using";

                    string name1 = name.Text;
                    string sem1 = sem.Text;
                    string mobile_no1 = mobile_no.Text;
                    string email_id1 = email_id.Text;

                    //Label1.Text += "after string value";
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    

                    string command = "Insert into student(name,sem,mobile_no,email_id) values('"+name1+ "','" + sem1 + "','" + mobile_no1 + "','" + email_id1 + "')";

                    SqlCommand cmd = new SqlCommand(command, con);

                    //Label1.Text += "after sql command";
                    adapter.InsertCommand = new SqlCommand(command, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    //Label1.Text += "after adapter";
                    

                    con.Close();
                    Label1.Text = "record inserted ";
                   



                }
            }
            catch (Exception err)
            {
                //Handle execeptions if any
                Label1.Text = "Error reading the datastore: ";
                Label1.Text += err.Message;
            }

        }
    }
}