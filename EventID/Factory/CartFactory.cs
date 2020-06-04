using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Factory
{
    public class CartFactory
    {
        public static Cart createCartItem(int ProductID, int Quantity)
        {
            Cart cart = new Cart();
            cart.ProductID = ProductID;
            cart.Quantity = Quantity;
            return cart;
        }
    }
}