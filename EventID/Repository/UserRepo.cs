using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Repository
{
    public class UserRepo
    {
        public static EventIDEntities db = new EventIDEntities();
        public static void InsertUser(int roleid, string uName, string email, string pass, string gender, string address, string status)
        {
            User u = UserFactory.UserFactory.inputUserToDb(roleid, uName, email, pass, gender, address, status);
            db.Users.Add(u);
            db.SaveChanges();
        }

        public static User checkUser(string email, string pass)
        {
            User user = db.Users.Where(a => a.UserEmail.Equals(email) && a.UserPassword.Equals(pass)).FirstOrDefault();
            return user;
        }

        public static User SearchByID(int ID)
        {
            User user =  (from x in db.Users
                          where x.UserID == ID
                          select x).FirstOrDefault();
            return user;
        }
    }
}