using EventID.Factory;
using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class CartRepo
    {
        static EventIDEntities db = new EventIDEntities();
        public static List<Cart> getListCart()
        {
            return db.Carts.ToList();
        }

        public static List<Cart> getListCartByID(int userID)
        {
            var data = (from x in db.Carts
                        where x.UserID == userID
                        select x);
            return data.ToList();
        }

        public static bool existCartbyProductIdAndUserId(int productId, int userId)
        {
            Cart carts = getCartbyProductIdAndUserId(productId, userId);
            if (carts == null)
            {
                return false;
            }
            return true;
        }

        public static void doInsertProductToCart(int userID, int productID, int qty)
        {
            Cart carts = CartFactory.createCartItem(userID, productID, qty);
            db.Carts.Add(carts);
            db.SaveChanges();
        }

        public static void updateCart(int userID, int productID, int quantity)
        {
            Cart carts = db.Carts.Where(a => a.ProductID == productID && a.UserID==userID).FirstOrDefault();
            carts.Quantity = quantity;
            db.SaveChanges();
        }

        public static Cart getCartbyProductIdAndUserId(int productId, int userId)
        {
            Cart carts = db.Carts.Where(a => a.ProductID == productId && a.UserID == userId).FirstOrDefault();
            return carts;
        }

        public static List<Cart> getCartUser(int id)
        {
            return db.Carts.Where(a => a.UserID == id).ToList();
        }

        public static void deleteProductCart(int productId, int userId)
        {
            Cart carts = getCartbyProductIdAndUserId(productId, userId);
            db.Carts.Remove(carts);
            db.SaveChanges();
        }

        public static void deleteQtyProductCart(int productId, int userId)
        {
            Cart carts = getCartbyProductIdAndUserId(productId, userId);
            carts.Quantity--;
            db.SaveChanges();
        }
    }
}