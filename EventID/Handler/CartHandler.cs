using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Handler
{
    public class CartHandler
    {
        public static List<Cart> getAllCartUser(int userId)
        {
            return CartRepo.getCartUser(userId);
        }

        public static Cart getCartByProductIdAndUserId(int productId, int userId)
        {
            return CartRepo.getCartbyProductIdAndUserId(productId, userId);
        }

        public static void deleteProductCart(int productId, int userId)
        {
            CartRepo.deleteProductCart(productId, userId);
        }

        public static void decreaseQtyCartProduct(int productId, int userId)
        {
            CartRepo.deleteQtyProductCart(productId, userId);
        }
    }
}