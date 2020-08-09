using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4_e
{
  
    public partial class image : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            if (Image1.Visible == true)
            {
                Image1.Visible = false;
            }
            else
            {
                Image1.Visible = true;
            }


        }
    }
}