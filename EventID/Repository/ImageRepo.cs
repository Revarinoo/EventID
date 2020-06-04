using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class ImageRepo
    {
        static EventIDEntities dbEntity = new EventIDEntities();
        public static List<Image> getImage()
        {
            return dbEntity.Images.ToList();
        }
    }
}