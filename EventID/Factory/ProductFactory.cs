using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Factory
{
    public class ProductFactory
    {
        public static Product insertProduct (int prodCatId, int vendorId, string name, int price, 
            string desc, string status, int subCatId)
        {
            Product p = new Product();
            p.ProductCategoryID = prodCatId;
            p.VendorFlag = vendorId;
            p.ProductName = name;
            p.Price = price;
            p.Description = desc;
            p.ProductStatus = status;
            p.SubCategoryID = subCatId;
            return p;
        }

        public static Image insertImage (int prodId, string Name)
        {
            Image i = new Image();
            i.ProductID = prodId;
            i.ImageName = Name;
            return i;
        }
    }
}