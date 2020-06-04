using EventID.Controller;
using EventID.Handler;
using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventID.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                if (Request.Cookies.Get("user") != null)
                {
                    HttpCookie cookie = Request.Cookies.Get("user");
                    int id = int.Parse(cookie.Value);

                    EventIDEntities db = new EventIDEntities();
                    User u = UserRepo.SearchByID(id);
                    email.Text = u.UserEmail;
                    password.Attributes["value"] = u.UserPassword;
                    remMe.Checked = true;
                }
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string Email = email.Text.ToString();
            string pass = password.Text.ToString();
            string errorMessage = "";

            User u = UserRepo.checkUser(Email, pass);
            bool success = AuthController.tryLogin(Email, pass, out errorMessage);
            if (!success)
            {
                LoginError.Text = errorMessage;
            }
            else
            {
                Session["user"] = u;
                if (remMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user", u.UserID.ToString());
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Home.aspx");
            }
        }
    }
}