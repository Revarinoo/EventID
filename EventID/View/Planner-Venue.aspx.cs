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
    public partial class Planner_Venue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1
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
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1
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

        protected void BtnBallroom_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1 && i.SubCategoryID == 1
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

        protected void BtnAF_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1 && i.SubCategoryID == 3
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

        protected void BtnResort_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1 && i.SubCategoryID == 4
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

        protected void BtnRC_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 1 && i.SubCategoryID == 5
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

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Planner-Catering.aspx");
        }

        protected void btnNeed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Planner-Catering.aspx");
        }
    }
}