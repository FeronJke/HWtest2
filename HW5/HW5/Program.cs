using System;
using System.Text.RegularExpressions;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login: ");
            Console.WriteLine(LoginCheck(Console.ReadLine()));

            static bool LoginCheck(string login)
            {
                Regex reg = new Regex(@"[a-zA-Z]{1}[a-zA-Z0-9]{1,9}");
                if (login.Length > 10)
                    return false;
                return reg.IsMatch(login);
            }
    }
}
