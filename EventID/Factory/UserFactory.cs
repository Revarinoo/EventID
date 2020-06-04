using EventID.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.UserFactory
{
    public class UserFactory
    {
        public static User inputUserToDb(int roleid, string uName, string email, string pass, string gender, string address, string status)
        {
            User u = new User();
            u.RoleID = roleid;
            u.UserName = uName;
            u.UserEmail = email;
            u.UserPassword = pass;
            u.UserGender = gender;
            u.UserAddress = address;
            u.UserStatus = status;
            return u;
        }
    }
}