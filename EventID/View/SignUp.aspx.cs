using EventID.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventID.View
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string Name = name.Text.ToString();
            string Email = email.Text.ToString();
            string Pass = password.Text.ToString();
            string confPass = conf_pass.Text.ToString();
            string Address = address.Text.ToString();
            string Gender = gender.Text.ToString();
            string errorMessage = "";
            bool success = SignUpController.trySignUp(Name, Email, Pass, confPass, Address, Gender, out errorMessage);
            if (!success)
            {
                regError.Text = errorMessage;
            }
            else
            {
                regError.Text = "Sign up success, please go to Login page";
            }
        }
    }
}