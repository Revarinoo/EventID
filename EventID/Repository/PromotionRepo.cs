using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class PromotionRepo
    {
        static EventIDEntities dbEntity = new EventIDEntities();
        public static List<Promotion> getPromo()
        {
            return dbEntity.Promotions.ToList();
        }
    }
}