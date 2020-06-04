using EventID.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Controller
{
    public class SignUpController
    {
        public static bool trySignUp(int roleId, string Name, string Email, string Pass, string confPass, string address, string gender, out string errorMessage)
        {
            errorMessage = "";
            if (Name == "")
            {
                errorMessage = "Name must be filled!";
                return false;
            }
            else if (Email == "")
            {
                if (Email != "")
                {
                    if (Email.Contains("@") == false || Email.Contains(".com") == false)
                    {
                        errorMessage = "Email must contain '@' and '.com'";
                        return false;
                    }
                }
                errorMessage = "Email must be filled!";
                return false;
            }
            else if (address == "")
            {
                errorMessage = "Address must be filled!";
                return false;
            }
            else if (gender == "")
            {
                errorMessage = "You must choose your gender!";
                return false;
            }
            else if (Pass == "")
            {
                errorMessage = "Password must be filled!";
                return false;
            }
            else if (confPass != Pass)
            {
                errorMessage = "Password is not same!";
                return false;
            }
            else
            {
                SignUpHandler.doRegis(roleId, Name, Email, Pass, confPass, address, gender);
                return true;
            }
        }
    }
}
