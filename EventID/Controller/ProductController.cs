using EventID.Handler;
using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Controller
{
    public class ProductController
    {
        public static bool tryAddProduct (string name, int price, int catId, int subcatId,
            string desc, int vendorid, string imgName, out string errormssg)
        {
            int x;
            errormssg = "";
            if (name.Equals(""))
            {
                errormssg = "Product name must be filled";
                return false;
            }
            else if (price.Equals(null))
            {
                errormssg = "Product price must be filled";
                return false;
            }
            else if (catId.Equals(null))
            {
                errormssg = "You must choose product category";
                return false;
            }
            else if (subcatId.Equals(null))
            {
                errormssg = "You must choose product sub category";
                return false;
            }
            else if (desc.Equals(null))
            {
                errormssg = "Description can not be empty";
                return false;
            }
            else
            {
                x = ProductHandler.addProduct(catId, vendorid, name, price, desc, subcatId);
                ProductHandler.addImage(x, imgName);
                return true;
            }
        }

        public static Product getProductById(int productId)
        {
            return ProductHandler.getProductById(productId);
        }
    }
}