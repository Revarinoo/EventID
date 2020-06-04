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
    public partial class Planner_Photography : System.Web.UI.Page
    {
        List<Model.Image> productImage = ImageRepo.getImage();
        List<Product> product = ProductRepo.getProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 6
                         group j by j.ProductID into ij
                         select new
                         {
                             ij.FirstOrDefault().Product.ProductName,
                             ij.FirstOrDefault().Product.Price,
                             ij.FirstOrDefault().ImageName
                         };
            rptrProducts.DataSource = filter;
            rptrProducts.DataBind();
        }

        protected void BtnAll_Click(object sender, EventArgs e)
        {
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 6
                         group j by j.ProductID into ij
                         select new
                         {
                             ij.FirstOrDefault().Product.ProductName,
                             ij.FirstOrDefault().Product.Price,
                             ij.FirstOrDefault().ImageName
                         };
            rptrProducts.DataSource = filter;
            rptrProducts.DataBind();
        }

        protected void BtnFB_Click(object sender, EventArgs e)
        {
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 6 && i.SubCategoryID == 18
                         group j by j.ProductID into ij
                         select new
                         {
                             ij.FirstOrDefault().Product.ProductName,
                             ij.FirstOrDefault().Product.Price,
                             ij.FirstOrDefault().ImageName
                         };
            rptrProducts.DataSource = filter;
            rptrProducts.DataBind();
        }

        protected void BtnAB_Click(object sender, EventArgs e)
        {
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 6 && i.SubCategoryID == 19
                         group j by j.ProductID into ij
                         select new
                         {
                             ij.FirstOrDefault().Product.ProductName,
                             ij.FirstOrDefault().Product.Price,
                             ij.FirstOrDefault().ImageName
                         };
            rptrProducts.DataSource = filter;
            rptrProducts.DataBind();
        }

        protected void BtnSO_Click(object sender, EventArgs e)
        {
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 6 && i.SubCategoryID == 20
                         group j by j.ProductID into ij
                         select new
                         {
                             ij.FirstOrDefault().Product.ProductName,
                             ij.FirstOrDefault().Product.Price,
                             ij.FirstOrDefault().ImageName
                         };
            rptrProducts.DataSource = filter;
            rptrProducts.DataBind();
        }
        protected void btnNeed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");//add to cart
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");//add to cart
        }
    }
}