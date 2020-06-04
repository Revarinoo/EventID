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
    public partial class ProductSeeMore : System.Web.UI.Page
    {
        public static EventIDEntities db = new EventIDEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null && Request.QueryString["subcat"] == null)
            {
                SeeMoreCardTitle.Text = "All Category";
                showProduct(0);
                showButton(0);
            }
            else if (Request.QueryString["id"] != null && Request.QueryString["subcat"].Equals("0"))
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                SeeMoreCardTitle.Text = ProductCategoryRepo.getCategoryName(id);
                showProduct(id);
                showButton(id);
            }
            else if (Request.QueryString["id"] != null && !Request.QueryString["subcat"].Equals("0"))
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                int Subcat = Int32.Parse(Request.QueryString["subcat"]);

                showButton(id);
                SeeMoreCardTitle.Text = ProductCategoryRepo.getCategoryName(id);
                showProductWithSubCategory(id, Subcat);
            }
        }

        private void showProductWithSubCategory(int id, int Subcat)
        {
            List<Product> prod = ProductRepo.getProductById(id);
            List<Model.Image> img = ImageRepo.getImage();

            var list = from p in prod
                       join i in img on p.ProductID equals i.ProductID
                       where p != null && p.SubCategoryID == Subcat
                       select new
                       {
                           p.ProductName,
                           p.Price,
                           i.ImageName
                       };
            repeaterProdSeeMore.DataSource = list;
            repeaterProdSeeMore.DataBind();
        }

        private void showProduct(int id)
        {
            List<Product> prod = new List<Product>();
            List<Model.Image> img = new List<Model.Image>();
            if (id == 0)
            {
                prod = ProductRepo.getProduct();
                img = ImageRepo.getImage();
                var list = from p in prod
                           join i in img on p.ProductID equals i.ProductID
                           where p != null
                           select new
                           {
                               p.ProductName,
                               p.Price,
                               i.ImageName
                           };
                repeaterProdSeeMore.DataSource = list;
                repeaterProdSeeMore.DataBind();
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
                               p.ProductName,
                               p.Price,
                               i.ImageName
                           };
                repeaterProdSeeMore.DataSource = list;
                repeaterProdSeeMore.DataBind();
            }
        }

        private void showButton(int id)
        {
            if (id == 0)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = false;
                SeeMoreCardBtnEvent.Visible = false;
                SeeMoreCardBtnProm.Visible = false;
                SeeMoreCardBtnConcert.Visible = false;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
            else if (id == 1)
            {
                SeeMoreCardBtnBallroom.Visible = true;
                SeeMoreCardBtnHotel.Visible = true;
                SeeMoreCardBtnHall.Visible = true;
                SeeMoreCardBtnResto.Visible = true;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = false;
                SeeMoreCardBtnEvent.Visible = false;
                SeeMoreCardBtnProm.Visible = false;
                SeeMoreCardBtnConcert.Visible = false;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
            else if (id == 2)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = true;
                SeeMoreCardBtnWstr.Visible = true;
                SeeMoreCardBtnChi.Visible = true;
                SeeMoreCardBtnIta.Visible = true;
                SeeMoreCardBtnBday.Visible = false;
                SeeMoreCardBtnEvent.Visible = false;
                SeeMoreCardBtnProm.Visible = false;
                SeeMoreCardBtnConcert.Visible = false;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
            else if (id == 3)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = true;
                SeeMoreCardBtnEvent.Visible = true;
                SeeMoreCardBtnProm.Visible = true;
                SeeMoreCardBtnConcert.Visible = true;
                SeeMoreCardBtnSeminar.Visible = true;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
            else if (id == 4)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = false;
                SeeMoreCardBtnEvent.Visible = false;
                SeeMoreCardBtnProm.Visible = false;
                SeeMoreCardBtnConcert.Visible = false;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = true;
                SeeMoreCardBtnDMC.Visible = true;
                SeeMoreCardBtnGMC.Visible = true;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
            else if (id == 5)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = false;
                SeeMoreCardBtnEvent.Visible = false;
                SeeMoreCardBtnProm.Visible = false;
                SeeMoreCardBtnConcert.Visible = false;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = true;
                SeeMoreCardBtnGroup.Visible = true;
                SeeMoreCardBtnBand.Visible = true;
            }
            else if (id == 6)
            {
                SeeMoreCardBtnBallroom.Visible = false;
                SeeMoreCardBtnHotel.Visible = false;
                SeeMoreCardBtnHall.Visible = false;
                SeeMoreCardBtnResto.Visible = false;
                SeeMoreCardBtnIdn.Visible = false;
                SeeMoreCardBtnWstr.Visible = false;
                SeeMoreCardBtnChi.Visible = false;
                SeeMoreCardBtnIta.Visible = false;
                SeeMoreCardBtnBday.Visible = true;
                SeeMoreCardBtnEvent.Visible = true;
                SeeMoreCardBtnProm.Visible = true;
                SeeMoreCardBtnConcert.Visible = true;
                SeeMoreCardBtnSeminar.Visible = false;
                SeeMoreCardBtnSMC.Visible = false;
                SeeMoreCardBtnDMC.Visible = false;
                SeeMoreCardBtnGMC.Visible = false;
                SeeMoreCardBtnSolo.Visible = false;
                SeeMoreCardBtnGroup.Visible = false;
                SeeMoreCardBtnBand.Visible = false;
            }
        }

        protected void SeeMoreCardBtnAll_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Request.QueryString["id"]).Equals(null) || Int32.Parse(Request.QueryString["id"]).Equals(0)) Response.Redirect("ProductSeeMore.aspx");
            else
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                Responses(id, 0);
            }
        }

        protected void SeeMoreCardBtnBallroom_Click(object sender, EventArgs e)
        {
            Responses(1, 1);
        }

        protected void SeeMoreCardBtnHotel_Click(object sender, EventArgs e)
        {
            Responses(1, 2);
        }

        protected void SeeMoreCardBtnHall_Click(object sender, EventArgs e)
        {
            Responses(1, 3);
        }

        protected void SeeMoreCardBtnResto_Click(object sender, EventArgs e)
        {
            Responses(1, 4);
        }

        protected void SeeMoreCardBtnIdn_Click(object sender, EventArgs e)
        {
            Responses(2, 5);
        }

        protected void SeeMoreCardBtnWstr_Click(object sender, EventArgs e)
        {
            Responses(2, 6);
        }

        protected void SeeMoreCardBtnChi_Click(object sender, EventArgs e)
        {
            Responses(2, 7);
        }

        protected void SeeMoreCardBtnIta_Click(object sender, EventArgs e)
        {
            Responses(2, 8);
        }

        protected void SeeMoreCardBtnBday_Click(object sender, EventArgs e)
        {
            Responses(3, 9);
        }

        protected void SeeMoreCardBtnEvent_Click(object sender, EventArgs e)
        {
            Responses(3, 10);
        }

        protected void SeeMoreCardBtnProm_Click(object sender, EventArgs e)
        {
            Responses(3, 11);
        }

        protected void SeeMoreCardBtnConcert_Click(object sender, EventArgs e)
        {
            Responses(3, 12);
        }

        protected void SeeMoreCardBtnSeminar_Click(object sender, EventArgs e)
        {
            Responses(3, 13);
        }

        protected void SeeMoreCardBtnSMC_Click(object sender, EventArgs e)
        {
            Responses(3, 14);
        }

        protected void SeeMoreCardBtnDMC_Click(object sender, EventArgs e)
        {
            Responses(3, 15);
        }

        protected void SeeMoreCardBtnGMC_Click(object sender, EventArgs e)
        {
            Responses(3, 16);
        }

        protected void SeeMoreCardBtnSolo_Click(object sender, EventArgs e)
        {
            Responses(3, 17);
        }

        protected void SeeMoreCardBtnGroup_Click(object sender, EventArgs e)
        {
            Responses(3, 19);
        }

        protected void SeeMoreCardBtnBand_Click(object sender, EventArgs e)
        {
            Responses(3, 20);
        }

        private void Responses(int x, int y)
        {
            Response.Redirect("ProductSeeMore.aspx?id=" + x + "&subcat=" + y);
        }
    }
}