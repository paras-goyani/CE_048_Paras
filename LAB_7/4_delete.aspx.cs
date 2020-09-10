using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB71
{
    public partial class delete : System.Web.UI.Page
    {
        DataClasses2DataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataClasses2DataContext();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (db)
            {
                student st = db.students.SingleOrDefault(x => x.sid == int.Parse(TextBox1.Text));
                db.students.DeleteOnSubmit(st);
                db.SubmitChanges();
            }
            Response.Redirect("show.aspx");
        }
    }
}