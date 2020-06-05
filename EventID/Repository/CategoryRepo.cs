using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class CategoryRepo
    {
        static EventIDEntities db = new EventIDEntities();

        public static int getCategoryIdByName (string categoryName)
        {
            ProductCategory pc = db.ProductCategories.Where(x => x.ProductCategoryName.Equals(
                categoryName)).FirstOrDefault();
            int catID = pc.ProductCategoryID;
            return catID;
        }
    }
}