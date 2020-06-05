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

        public static List<String> getSubCategoryById(int id)
        {
            List<SubCategory> listsss = getSubCategory();
            List<String> list = new List<String>();

            for (int i = 0; i < listsss.Count(); i++)
            {
                SubCategory sc = db.SubCategories.Where(a => a.ProductCategoryID == id).FirstOrDefault();
                list.Add(sc.SubCategoryName);
            }

            return list;
        }

        public static int getSubCategoryIdByName(string name)
        {
            SubCategory sc = db.SubCategories.Where(x => x.SubCategoryName.Equals(name)).FirstOrDefault();
            return sc.SubCategoryID;
        }
    }
}