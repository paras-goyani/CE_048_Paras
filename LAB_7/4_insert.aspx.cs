using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB71
{
    public partial class insert : System.Web.UI.Page
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
                student st = new student
                {
                    name = TextBox1.Text,
                    sem = TextBox2.Text,
                    cpi = int.Parse( TextBox3.Text),
                    contactno = TextBox4.Text,
                    emailid = TextBox5.Text
                };
                db.students.InsertOnSubmit(st);
                db.SubmitChanges();
            }
            Response.Redirect("show.aspx");
        }
    }
}