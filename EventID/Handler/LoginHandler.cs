using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Handler
{
    public class LoginHandler
    {
        public static Boolean isLogin(string email, string password)
        {
            User user = UserRepo.checkUser(email, password);
            return (user == null) ? false : true; 
        }
        
    }
}