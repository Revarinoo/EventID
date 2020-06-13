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
    public partial class Promotion : System.Web.UI.Page
    {
        EventIDEntities dbEntity = new EventIDEntities();
        List<Product> prod = ProductRepo.getProduct();
        List<Model.Image> img = ImageRepo.getImage();
        List<Model.Promotion> promo = PromotionRepo.getPromo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null && Request.QueryString["subcat"] == null)
            {
                lblPromo.Text = "All Category";
                showProduct(0);
            }
            else if (Request.QueryString["id"] != null && Request.QueryString["subcat"].Equals("0"))
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                lblPromo.Text = ProductCategoryRepo.getCategoryName(id);
                showProduct(id);
            }

        }

        private void showProduct(int id)
        {
            List<Model.Promotion> promo = PromotionRepo.getPromo();
            List<Product> prod = new List<Product>();
            List<Model.Image> img = new List<Model.Image>();
            if (id == 0)
            {
                prod = ProductRepo.getProduct();
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           join z in promo on p.ProductID equals z.ProductID
                           where p != null
                           select new
                           {
                               p.ProductID,
                               p.ProductName,
                               p.Price,
                               i.ImageName,
                               z.Discount,
                               newPrice = p.Price - ((p.Price * z.Discount) / 100)
                           };
                repeaterPromotion.DataSource = list;
                repeaterPromotion.DataBind();
            }
            else
            {
                prod = ProductRepo.getProductById(id);
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           join z in promo on p.ProductID equals z.ProductID
                           where p != null
                           select new
                           {
                               p.ProductID,
                               p.ProductName,
                               p.Price,
                               i.ImageName,
                               z.Discount,
                               newPrice = p.Price - ((p.Price * z.Discount) / 100)
                           };
                repeaterPromotion.DataSource = list;
                repeaterPromotion.DataBind();
            }
        }
    }
}