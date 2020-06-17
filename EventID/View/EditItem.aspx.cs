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
    public partial class EditItem : System.Web.UI.Page
    {
        EventIDEntities dbEntity = new EventIDEntities();
        List<Product> prod = ProductRepo.getProduct();
        List<Model.Image> img = ImageRepo.getImage();
        List<Model.Promotion> promo = PromotionRepo.getPromo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
               
                User us = (User)Session["user"];
                showProduct(us.UserID);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }


        private void showProduct(int id)
        {
            
                prod = ProductRepo.getProduct();
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           where p != null && p.VendorFlag == id
                           select new
                           {
                               p.ProductID,
                               p.ProductName,
                               p.Price,
                               i.ImageName
                           };
                repeaterEditItem.DataSource = list;
                repeaterEditItem.DataBind();
            
            
        }
    }
}