using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class SubCategoryRepo
    {
        public static EventIDEntities db = new EventIDEntities();

        public static List<SubCategory> getSubCategory()
        {
            return db.SubCategories.ToList();
        }
    }
}