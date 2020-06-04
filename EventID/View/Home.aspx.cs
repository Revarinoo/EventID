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
    public partial class Home : System.Web.UI.Page
    {
        EventIDEntities dbEntity = new EventIDEntities();
        List<Product> prod = ProductRepo.getProduct();
        List<Model.Image> img = ImageRepo.getImage();
        protected void Page_Load(object sender, EventArgs e)
        {
            CallImg1();
            CallImg2();
            CallImg3();
            CallImg4();
            CallImg5();
            CallImg6();
        }

        protected void CallImg1()
        {
            Model.Image img1 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44250
                          select x).FirstOrDefault();
            Product name1 = (from x in dbEntity.Products
                             where x.ProductID == 44250
                             select x).FirstOrDefault();
            Image1.ImageUrl = "./Assets/" + img1.ImageName;
            Label1.Text = name1.ProductName;
        }

        protected void CallImg2()
        {
            Model.Image img2 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44252
                          select x).FirstOrDefault();
            Product name2 = (from x in dbEntity.Products
                             where x.ProductID == 44252
                             select x).FirstOrDefault();
            Image2.ImageUrl = "./Assets/" + img2.ImageName;
            Label2.Text = name2.ProductName;
        }

        protected void CallImg3()
        {
            Model.Image img3 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44255
                          select x).FirstOrDefault();
            Product name3 = (from x in dbEntity.Products
                             where x.ProductID == 44255
                             select x).FirstOrDefault();
            Image3.ImageUrl = "./Assets/" + img3.ImageName;
            Label3.Text = name3.ProductName;
        }

        protected void CallImg4()
        {
            Model.Image img4 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44256
                          select x).FirstOrDefault();
            Product name4 = (from x in dbEntity.Products
                             where x.ProductID == 44256
                             select x).FirstOrDefault();
            Image4.ImageUrl = "./Assets/" + img4.ImageName;
            Label4.Text = name4.ProductName;
        }

        protected void CallImg5()
        {
            Model.Image img5 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44257
                          select x).FirstOrDefault();
            Product name5 = (from x in dbEntity.Products
                             where x.ProductID == 44257
                             select x).FirstOrDefault();
            Image5.ImageUrl = "./Assets/" + img5.ImageName;
            Label5.Text = name5.ProductName;
        }

        protected void CallImg6()
        {
            Model.Image img6 = (from x in img
                          join z in prod
                          on x.ProductID equals z.ProductID
                          where z.ProductID == 44258
                          select x).FirstOrDefault();
            Product name6 = (from x in dbEntity.Products
                             where x.ProductID == 44258
                             select x).FirstOrDefault();
            Image6.ImageUrl = "./Assets/" + img6.ImageName;
            Label6.Text = name6.ProductName;
        }
    }
}