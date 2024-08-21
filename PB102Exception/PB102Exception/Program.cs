//try
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(20 / num);
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("0-a bolmek qadagandir.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Deyer duzgun daxil olunmayib");
//}

using PB102Exception.Exceptions;
using PB102Exception.Helper;
using PB102Exception.Models;
using PB102Exception.Services;
bool isContinue = true;
RegisterStart:
try
{
    do
    {
        Console.Clear();
        Menu.GetMenu();
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Sira ile Ad, Soyad, Username ve Password daxil edin");
                User user = new User
                {
                    Name = Console.ReadLine(),
                    Surname = Console.ReadLine(),
                    Username = Console.ReadLine(),
                    Password = Console.ReadLine()
                };
                Console.WriteLine(AuthService.Register(user));
                break;
            case 2:
                isContinue = false;
                break;
            default:
                break;
        }
    } while (isContinue);
}
catch (BaseException ex)
{
    Console.WriteLine(ex.Message);
    goto RegisterStart;
}
catch (Exception)
{
    return;
}
