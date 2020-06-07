using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Factory
{
    public class CartFactory
    {
        public static Cart createCartItem(int userID, int productID, int qty)
        {
            Cart cart = new Cart();
            cart.UserID = userID;
            cart.ProductID = productID;
            cart.Quantity = qty;

            return cart;
        }
    }
}