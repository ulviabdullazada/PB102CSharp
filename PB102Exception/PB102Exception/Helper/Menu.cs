using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PB102Exception.Helper
{
    class Menu
    {
        public static void GetMenu()
        {
            Console.WriteLine($@"
1.Create new user
2.Exit Program
");
            //Console.WriteLine("1.Create new user\n2.Exit Program");
        }
    }
}
