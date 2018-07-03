using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
   public class User
    {
        private string username;

    
        // Create a User object with a given name and access level;
        
        public User(string name)
        {
            this.username = name;
        }

       
        // Return the user's name.
      
        public string Name
        {
            get { return this.username; }
        }
    }
}
