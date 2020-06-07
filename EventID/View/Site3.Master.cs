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
    public partial class Site3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int value;
            labelCart.Text = 0.ToString();
            if (Session["user"] != null)
            {
                User us = (User)Session["user"];
                List<Model.Cart> cart = CartRepo.getListCartByID(us.UserID);
                value = cart.Count;
                labelCart.Text = value.ToString();
            }
        }
    }
}