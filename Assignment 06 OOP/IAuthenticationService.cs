using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password);
        public bool AuthorizeUser(string userName, string role);
    }

    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "UserNameOld" && password == "PassWordOld")
                return true;
            else
                return false;
        }

        public bool AuthorizeUser(string userName, string role)
        {
            if (userName == " Name" && role == "Role")
                return true;
            else
                return false;
        }
    }
}
