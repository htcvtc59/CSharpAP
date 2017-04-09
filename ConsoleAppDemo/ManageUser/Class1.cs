using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageUser
{
    public class User
    {
        public string HelloUser(string user)
        {
            return "Hello " + user;
        }
        public bool AuthenticateUser(string user, string password)
        {
            if (user == "anadi" && password == "anadi")
                return true;
            else
                return false;
        }
    }
}
