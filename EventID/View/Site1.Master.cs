using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventID.View
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Model.Cart> cart = CartRepo.getListCart();
            int value = cart.Count;
            labelCart.Text = value.ToString();
            if (Session["user"] != null)
            {
                btnLogin1.Visible = false;
                btnRegister1.Visible = false;

                if (Session["role"].Equals(3))
                {
                    addItem1.Visible = true;
                }
                else
                {
                    addItem1.Visible = false;
                }
            }
            else
            {
                btnLogout1.Visible = false;
                addItem1.Visible = false;
            }

        }
        protected void btnLogin1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegis1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogout1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HttpCookie cookie = Response.Cookies.Get("user");
            cookie.Expires = DateTime.Now.AddHours(-2);
            Response.Redirect("Home.aspx");
        }

        protected void addItem1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddItem.aspx");
        }
    }
}