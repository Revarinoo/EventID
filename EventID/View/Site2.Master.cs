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
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Model.Cart> cart = CartRepo.getListCart();
            int value = cart.Count;
            labelCart.Text = value.ToString();
            if(Session["user"] != null)
            {
                btnLogin2.Visible = false;
                btnRegister2.Visible = false;
            }
            else
            {
                btnLogout2.Visible = false;
            }
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegis2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogout2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HttpCookie cookie = Response.Cookies.Get("user");
            cookie.Expires = DateTime.Now.AddHours(-2);
            Response.Redirect("Home.aspx");
        }
    }
}