using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB71
{
    public partial class update : System.Web.UI.Page
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
                student st = db.students.SingleOrDefault(x => x.sid == int.Parse(TextBox6.Text));
                st.name = TextBox1.Text;
                st.sem = TextBox2.Text;
                st.cpi = int.Parse(TextBox3.Text);
                st.contactno = TextBox4.Text;
                st.emailid = TextBox5.Text;
                db.SubmitChanges();
            }
            Response.Redirect("show.aspx");
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            using (db)
            {
                var data = from student in db.students
                           where student.sid == int.Parse(TextBox6.Text)
                           select student;
                foreach (var i in data)
                {
                    TextBox1.Text = i.name;
                    TextBox2.Text = i.sem;
                    TextBox3.Text = i.cpi.ToString();
                    TextBox4.Text = i.contactno;
                    TextBox5.Text = i.emailid;
                    break;
                }
            }
        }
    }
}