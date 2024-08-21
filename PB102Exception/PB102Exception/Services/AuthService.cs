using PB102Exception.Exceptions;
using PB102Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB102Exception.Services
{
    class AuthService
    {
        public static User[] Users = new User[0];

        public static int Register(User user)
        {
            if (!(user.Username.Length > 3 && user.Username.Length < 16)) throw new UsernameInvalidException("Username uzunlugu 3-16 araliginda olmalidir.");
            if (user.Password.Length <= 3) throw new PasswordInvalidException("Password-un uzunlugu 3-den boyuk olmalidir");

            Array.Resize(ref Users, Users.Length+1);
            Users[Users.Length - 1] = user;

            return Users.Length;
        }
    }
}
