using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventID.Handler
{
    public class SignUpHandler
    {
        public static void doRegis(string Name, string Email, string Pass, string confPass, string address, string gender)
        {
            UserRepo.InsertUser(2, Name, Email, Pass, gender, address, "active");
        }
    }
}