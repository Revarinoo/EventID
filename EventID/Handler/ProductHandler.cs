﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventID.Controller;
using EventID.Handler;
using EventID.Model;
using EventID.Repository;

namespace EventID.Handler
{
    public class ProductHandler
    {
        public static List<String> getSubCategory(int catID)
        {
            return SubCategoryRepo.getSubCategoryById(catID);
        }

        public static int getCategoryId(string categoryName)
        {
            int categoryId = CategoryRepo.getCategoryIdByName(categoryName);
            return categoryId;
        }

        public static int getSubCategoryId(string subcategoryName)
        {
            int subcategoryId = SubCategoryRepo.getSubCategoryIdByName(subcategoryName);
            return subcategoryId;
        }

        public static int addProduct(int catId, int vendorId, string name, int price
            , string desc, int subcatId)
        {
           int x = ProductRepo.insertProduct(catId, vendorId, name, price, desc, subcatId);
            return x;
        }

        public static void EditProduct(int productID ,int catId, string name, int price
            , string desc, int subcatId)
        {
            ProductRepo.UpdateProduct(productID ,catId, name, price, desc, subcatId);
            
        }

        public static void addImage(int prodId, string name)
        {
            ProductRepo.insertImage(prodId, name);
        }

        public static void updateImage(int prodId, string name)
        {
            ProductRepo.updateImage(prodId, name);
        }

        public static void deleteProduct(int productID)
        {
            ProductRepo.deleteProduct(productID);
        }

        public static Product getProductById(int productId)
        {
            return ProductRepo.GetProductByID(productId);
        }
    }
}