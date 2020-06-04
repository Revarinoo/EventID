using EventID.Handler;
using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Controller
{
    public class AuthController
    {
        public static bool tryLogin(string Email, string password, out string errorMessage)
        {
            errorMessage = "";
            if(Email == "" || password == "")
            {
                errorMessage = "Email or password is empty!";
                return false;
            }
            else
            {
                bool success = LoginHandler.isLogin(Email, password);
                if (!success)
                {
                    errorMessage = "Email or Password invalid!";
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
    }
}