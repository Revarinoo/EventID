using EventID.Controller;
using EventID.Handler;
using EventID.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventID.View
{
    public partial class EditItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User us = (User)Session["user"];
                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    if (us.RoleID != 3)
                    {
                        if(Request.QueryString["ID"] == null)
                        {
                            Response.Redirect("EditItem.aspx");
                        }
                        Response.Redirect("Login.aspx");
                    }
                }
            }
        }


        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(Request.QueryString["ID"]);
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

                bool success = ProductController.tryEditProduct(productID, prodName, prodPrice, categoryID, subcategoryID
                    , desc, imageName, out errormssg);

                if (success)
                {
                    errormsg.Text = "Edit Product success!";
                }
                else if (!success)
                {
                    errormsg.Text = errormssg;
                }
            }
            catch
            {
                errormsg.Text = "Edit Product Failed!";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string errormssg = "";
                int productID = Convert.ToInt32(Request.QueryString["ID"]);
                bool success = ProductController.delete(productID, out errormssg);
                errormsg.Text = errormssg;
                Response.Redirect("EditItem.aspx");
            }
            catch
            {
                errormsg.Text = "Failed!";
            }
        }
    }
}