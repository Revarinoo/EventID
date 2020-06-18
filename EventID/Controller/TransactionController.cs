using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Controller
{
    public class TransactionController
    {
        public static void CheckOut(int userID, int paymentTypeID)
        {
            List<Cart> cartlist = CartRepo.getListCartByID(userID);
            int transactionID = TransactionRepo.insertHeaderTransaction(userID, paymentTypeID);
            foreach (Cart cart in cartlist)
            {
                TransactionRepo.insertDetailTransaction(transactionID, cart.ProductID, cart.Quantity);
            }
            CartRepo.deleteAllCart(userID);
        }
    }
}