using EventID.Factory;
using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class TransactionRepo
    {
        static EventIDEntities dbEntity = new EventIDEntities();
        public static int insertHeaderTransaction(int userID, int paymentTypeID)
        {
            HeaderTransaction ht = TransactionFactory.addHeaderTransaction(userID, paymentTypeID);
            dbEntity.HeaderTransactions.Add(ht);
            dbEntity.SaveChanges();
            return ht.TransactionID;
        }

        public static void insertDetailTransaction(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = TransactionFactory.addDetailTransaction(transactionID, productID, quantity);
            dbEntity.DetailTransactions.Add(dt);
            dbEntity.SaveChanges();
        }
    }
}