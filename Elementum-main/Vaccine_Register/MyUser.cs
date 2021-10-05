using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vaccine_Register
{
    class MyUser
    {
        public string Username { get; set; }

        public string Password { get; set; }

        private static string error = "Please Input Correct Details";

        public static void ShowError()
        {
         
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) {
                return false;
            }
            if (user1.Username != user2.Username) {
                error = "Username does not Exist!";
                return false;
            }
            else if (user1.Password != user2.Password) {
                error = "Username and Password does not Match!";
                return false;
            }
            return true;
        }
    }
}
