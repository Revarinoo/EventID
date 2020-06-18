using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class PaymentTypeRepo
    {
        static EventIDEntities db = new EventIDEntities();

        public static List<PaymentType> getPaymentType()
        {
            return db.PaymentTypes.ToList();
        }

        public static int searchByName(string paymentTypeName)
        {
            var id = (from x in db.PaymentTypes
                      where x.PaymetTypeName == paymentTypeName
                      select x).FirstOrDefault();
            return id.PaymentTypeID;
        }
    }
}