using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class ProductRepo
    {
        static EventIDEntities db = new EventIDEntities();
        public static List<Product> getProduct()
        {
            return db.Products.ToList();
        }

        public static bool check(int x, int y)
        {
            if (x.Equals(y))
            {
                return true;
            }
            return false;
        }

        public static List<int> getProdCatId(int id)
        {
            List<Product> allProd = getProduct();
            List<int> ehe = new List<int>();

            for (int x = 0; x < allProd.Count(); x++)
            {
                Product y = allProd[x];
                if (check(id, y.ProductCategoryID).Equals(true))
                {
                    ehe.Add(y.ProductID);
                }
            }
            return ehe;
        }

        public static List<Product> getProductById(int id)
        {
            List<int> allList = getProdCatId(id);
            List<Product> list = new List<Product>();

            for (int i = 0; i < allList.Count(); i++)
            {
                int x = allList[i];
                Product p = db.Products.Where(a => a.ProductID == x).FirstOrDefault();
                list.Add(p);
            }

            return list;
        }
    }
}