using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Login
    {
        // Ask the DB to return a user with the given credentials, or null.

        public static User login(string name, string pass)
        {
            List<string> userParts = UserDB.login(name, pass);

            if (userParts == null)
            {
                return null;
            }
            else
            {
                return new User(userParts[0]);
            }
        }
    }
}
