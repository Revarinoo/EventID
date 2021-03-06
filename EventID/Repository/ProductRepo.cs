﻿using EventID.Factory;
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
        public static int insertProduct(int catId, int vendorId, string name, int price, string desc
            , int subcatId)
        {
            Product p = ProductFactory.insertProduct(catId, vendorId, name, price, desc, "Available", subcatId);
            db.Products.Add(p);
            db.SaveChanges();
            return p.ProductID;
        }

        public static void UpdateProduct(int productId,int catId, string name, int price, string desc, int subcatId)
        {
            Product p = (Product)db.Products.Where(pr => pr.ProductID == productId).FirstOrDefault();
            p.ProductCategoryID = catId;
            p.ProductName = name;
            p.Price = price;
            p.Description = desc;
            p.SubCategoryID = subcatId;
            db.SaveChanges();
        }

        public static void insertImage(int prodId, string name)
        {
            Image i = ProductFactory.insertImage(prodId, name);
            db.Images.Add(i);
            db.SaveChanges();
        }

        public static void updateImage(int prodId, string name)
        {
            Image i = (Image)db.Images.Where(img => img.ProductID == prodId).FirstOrDefault();
            i.ImageName = name;
            db.SaveChanges();
        }


        public static void deleteProduct(int productID)
        {
            Product p = (Product)db.Products.Where(a => a.ProductID == productID).FirstOrDefault();
            db.Products.Remove(p);
            db.SaveChanges();
        }

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

        public static Product GetProductByID(int id)
        {
            Product prk = db.Products.Where(a => a.ProductID == id).FirstOrDefault();
            return prk;
        }
    }
}