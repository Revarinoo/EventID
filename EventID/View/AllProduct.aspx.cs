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
    public partial class AllProduct : System.Web.UI.Page
    {
        List<Product> product = ProductRepo.getProduct();
        List<Model.Image> img = ImageRepo.getImage();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null && Request.QueryString["subcat"] == null)
            {
                Load_Venue();
                Load_Catering();
                Load_Decoration();
            }
            else if(Request.QueryString["id"] != null)
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                showProduct(id);
            }
            else if (Request.QueryString["id"] != null && Request.QueryString["subcat"].Equals("0"))
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                LblClick.Visible = true;
                LblClick.Text = ProductCategoryRepo.getCategoryName(id);
                showProduct(id);
            }

        }

        private void showProduct(int id)
        {
            List<Product> prod = new List<Product>();
            List<Model.Image> img = new List<Model.Image>();
            if (id == 7)
            {
                LblClick.Visible = true;
                LblClick.Text = "All Category";
                prod = ProductRepo.getProduct();
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           where p != null
                           select new
                           {
                               p.ProductID,
                               p.ProductName,
                               p.Price,
                               i.ImageName
                           };
                repeaterClick.DataSource = list;
                repeaterClick.DataBind();
            }
            else
            {
                prod = ProductRepo.getProductById(id);
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           where p != null
                           select new
                           {
                               p.ProductID,
                               p.ProductName,
                               p.Price,
                               i.ImageName
                           };
                repeaterClick.DataSource = list;
                repeaterClick.DataBind();
            }
            buttonControl();
        }

        protected void Load_Venue()
        {
            LblVenue.Text = "Venue";
            

            var listVenue = from x in product join z in img
                            on x.ProductID equals z.ProductID
                            where x != null && x.ProductCategoryID == 1
                            select new
                            {
                                x.ProductID,
                                x.ProductName,
                                x.Price,
                                z.ImageName
                            };
            repeaterVenue.DataSource = listVenue;
            repeaterVenue.DataBind();
        }

        protected void Load_Catering()
        {
            LblCatering.Text = "Catering";

            var listCatering = from x in product join z in img
                                on x.ProductID equals z.ProductID
                               where x != null && x.ProductCategoryID == 2
                               select new
                               {
                                   x.ProductID,
                                   x.ProductName,
                                   x.Price,
                                   z.ImageName
                               };
            repeaterCatering.DataSource = listCatering;
            repeaterCatering.DataBind();
        }

        protected void Load_Decoration()
        {
            LblDecoration.Text = "Decoration";

            var listDecoration = from x in product join z in img
                                on x.ProductID equals z.ProductID
                                 where x != null && x.ProductCategoryID == 3
                                 select new
                                 {
                                     x.ProductID,
                                     x.ProductName,
                                     x.Price,
                                     z.ImageName
                                 };
            repeaterDecoration.DataSource = listDecoration;
            repeaterDecoration.DataBind();
        }

        //protected void AllCategory_Click(object sender, ImageClickEventArgs e)
        //{
        //    LblClick.Visible = true;
        //    LblClick.Text = "All Category";

        //    var list = from x in product join z in img
        //               on x.ProductID equals z.ProductID
        //               where x != null
        //               select new
        //               {
        //                   x.ProductName,
        //                   x.Price,
        //                   z.ImageName
        //               };
        //    repeaterClick.DataSource = list;
        //    repeaterClick.DataBind();
        //    buttonControl();
        //}

        protected void buttonControl()
        {
            LblVenue.Visible = false;
            repeaterVenue.Visible = false;
            LblCatering.Visible = false;
            repeaterCatering.Visible = false;
            LblDecoration.Visible = false;
            repeaterDecoration.Visible = false;
            SeeMoreVBtn.Visible = false;
            SeeMoreCBtn.Visible = false;
            SeeMoreDBtn.Visible = false;
        }



        protected void btnSeeMore_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductSeeMore.aspx");
        }
    }
}