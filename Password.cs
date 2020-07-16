using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public static class Password
    {
        public static void ReadInput()
        {
            Console.Clear();
            Console.Write("Input password and press enter: ");

            int inputLength = 0;
            string password = "";
            ConsoleKeyInfo key;

            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter) break;
                else
                {
                    password += key.KeyChar.ToString();
                    inputLength++;
                    Console.Clear();
                    Console.Write("Input password and press enter: ");
                    for (int i = 0; i < inputLength; i++)
                    {
                        Console.Write("*");
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Your password is {password}");
            Console.ReadKey();
        }
    }
}
