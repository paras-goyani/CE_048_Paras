using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4_e
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Page.IsPostBack == true)
            {
                
                if (state.SelectedValue == "gujarat")
                {
                    city.Items[2].Enabled = false;
                    city.Items[3].Enabled = false;

                    city.Items[0].Enabled = true;
                    city.Items[1].Enabled = true;
                }
                else
                {
                    city.Items[0].Enabled = false;
                    city.Items[1].Enabled = false;

                    city.Items[2].Enabled = true;
                    city.Items[3].Enabled = true;
                }
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            fullname.Visible = false;
            Label2.Text = fullname.Text;

            age.Visible = false;
            Label3.Text = age.Text;

            password.Visible = false;
            Label4.Text = password.Text;

            confirmpassword.Visible = false;
            Label5.Text = confirmpassword.Text;

            female.Visible = false;
            male.Visible = false;

            Label6.Text = Request.Form["gender"];

            mobileno.Visible = false;
            Label7.Text = Request.Form["mobileno"];
            //fullname.Text = fullname.Text;

            string temp = "";
            for (int i = 0; i < hobbies.Items.Count; i++)
            {
                if (hobbies.Items[i].Selected)
                {
                    temp += hobbies.Items[i].Value + ";";
                }
            }

            hobbies.Visible = false;
            Label8.Text = temp;

           


            pan.Visible = false;
            Label11.Text = pan.Text;
        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state.SelectedValue == "gujarat")
            {
                city.Items[2].Enabled = false;
                city.Items[3].Enabled = false;

                city.Items[0].Enabled = true;
                city.Items[1].Enabled = true;
            }
            else
            {
                city.Items[0].Enabled = false;
                city.Items[1].Enabled = false;

                city.Items[2].Enabled = true;
                city.Items[3].Enabled = true;
            }
        }

        protected void pan_verify(object source, ServerValidateEventArgs args)
        {
            if (args.Value == " ")
            {
                args.IsValid = false;
            }
            else
            {
                string strRegex = @"[AB]\d{9}";
                Regex regex = new Regex(strRegex);
                if (regex.IsMatch(args.Value))
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}