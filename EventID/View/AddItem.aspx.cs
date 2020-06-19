using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventID.Controller;
using EventID.Handler;
using EventID.Model;
using EventID.Repository;
using System.IO;

namespace EventID.View
{
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["role"] == null)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    if (!Session["role"].Equals(3))
                    {
                        Response.Redirect("Home.aspx");
                    }
                }
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string prodName = ProductName.Text.ToString();
                int prodPrice = Int32.Parse(ProductPrice.Text.ToString());
                int categoryID = ProductHandler.getCategoryId(ProductCategory.Text.ToString());
                int subcategoryID = ProductHandler.getSubCategoryId(ProductSubCategory.SelectedValue.ToString());
                string desc = ProductDesc.Text.ToString();
                string imageName = img1.FileName.ToString();
                string errormssg = "";
                if (img1.HasFile)
                {
                    string SavePath = Server.MapPath("./Assets/");
                    if (!Directory.Exists(SavePath))
                    {
                        Directory.CreateDirectory(SavePath);
                    }
                    img1.SaveAs(SavePath + imageName);
                }

                bool success = ProductController.tryAddProduct(prodName, prodPrice, categoryID, subcategoryID
                    , desc, Convert.ToInt32(Session["id"]), imageName, out errormssg);

                if (success)
                {
                    errormsg.Text = "Add Product success!";
                }
                else if (!success)
                {
                    errormsg.Text = errormssg;
                }
            }
            catch
            {
                errormsg.Text = "Add Product Failed!";
            }
        }
    }
}