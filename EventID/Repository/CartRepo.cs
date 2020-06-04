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

        public static void insertCart(int ProductID, int Quantity)
        {
            Cart cart = CartFactory.createCartItem(ProductID, Quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            Cart cart = db.Carts.Where(a => a.CartID == id).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}