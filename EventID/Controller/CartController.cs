using EventID.Handler;
using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Controller
{
    public class CartController
    {
        public static Cart getCartByProductIdAndUserId(int productId, int userId)
        {
            return CartHandler.getCartByProductIdAndUserId(productId, userId);
        }

        public static List<Cart> getCartbyUserId(int userId)
        {
            return CartHandler.getAllCartUser(userId);
        }

        public static void deleteCartUser(int productId, int userId)
        {
            Cart carts = getCartByProductIdAndUserId(productId, userId);
            if (carts == null)
            {
                //NULL
            }
            else
            {
                if (carts.Quantity > 1)
                {
                    CartHandler.decreaseQtyCartProduct(productId, userId);
                }
                else
                {
                    CartHandler.deleteProductCart(productId, userId);
                }
            }
        }
    }
}