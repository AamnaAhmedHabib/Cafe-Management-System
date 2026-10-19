using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    //Maintains information about the currently logged-in user throughout the Cafe application
    public static class UserSession //same static property can be accessed from anywhere
    {
        public static int CurrentUserID { get; set; }//get: Allows reading the value and set:Allows modifying the value 
        public static string Username { get; set; }
        public static string Role { get; set; } //"admin" or "cashier"

        
    }
}
