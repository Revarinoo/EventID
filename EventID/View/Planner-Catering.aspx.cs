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
    public partial class Planner_Catering : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 2
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
                         where i.ProductCategoryID == 2
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

        protected void BtnBuffet_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 2 && i.SubCategoryID == 6
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

        protected void BtnFD_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 2 && i.SubCategoryID == 7
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

        protected void BtnDB_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 2 && i.SubCategoryID == 8
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

        protected void BtnCake_Click(object sender, EventArgs e)
        {
            List<Model.Image> productImage = ImageRepo.getImage();
            List<Product> product = ProductRepo.getProduct();
            var filter = from i in product
                         join j in productImage on i.ProductID equals j.ProductID
                         where i.ProductCategoryID == 2 && i.SubCategoryID == 9
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
            Response.Redirect("Planner-Decoration.aspx");
        }

        protected void btnNeed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Planner-Decoration.aspx");
        }
    }
}