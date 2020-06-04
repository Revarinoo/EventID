using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class ProductCategoryRepo
    {
        public static EventIDEntities db = new EventIDEntities();

        public static List<ProductCategory> getProductCategory()
        {
            return db.ProductCategories.ToList();
        }

        public static String getCategoryName(int id)
        {
            ProductCategory pc = db.ProductCategories.Where(a => a.ProductCategoryID.Equals(id)).FirstOrDefault();
            return pc.ProductCategoryName;
        }
    }
}