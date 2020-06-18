using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction addHeaderTransaction(int userID, int paymentTypeID)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.UserID = userID;
            ht.PaymentTypeID = paymentTypeID;
            ht.TransactionDate = DateTime.Now;
            return ht;
        }

        public static DetailTransaction addDetailTransaction(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = new DetailTransaction();
            dt.TransactionID = transactionID;
            dt.ProductID = productID;
            dt.Quantity = quantity;
            return dt;
        }
    }
}