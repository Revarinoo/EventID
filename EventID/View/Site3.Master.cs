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
            List<Model.Cart> cart = CartRepo.getListCart();
            int value = cart.Count;
            labelCart.Text = value.ToString();
        }
    }
}