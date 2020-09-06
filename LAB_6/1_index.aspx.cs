using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_student_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/insert.aspx");
        }

        protected void edit_student_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Edit.aspx");
        }

        protected void delete_student_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/delete.aspx");
        }

        protected void show_student_details_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/show.aspx");
        }
    }
}