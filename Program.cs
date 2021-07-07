using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool exit = true; //Variable for exit from menu
            do
            {
                Console.Clear();
                //try  //Check correct input 
                //{
                Console.WriteLine("Choose menu\n1 - Minimum number\n2 - Average multiple 8\n3 - Login/Password checker\n4 - BodyMassIndex\n7 - Secret Password\n0 - Exit\n");   //Menu
                
                //int swPos = Convert.ToInt32(Console.ReadLine());
                //Чтобы не использовать try-catch для проверки корректности ввода можно использовать TryParse таким вот образом:
                if (int.TryParse(Console.ReadLine(), out int swPos))
                {
                    switch (swPos)
                    {
                        case 1:
                            MinNumber();
                            break;
                        case 2:
                            AvgMulti8();
                            break;
                        case 3:
                            Console.WriteLine(LogPassChecker());
                            Console.ReadKey();
                            break;
                        case 4:
                            BodyMassIndex();
                            break;
                        case 7:
                            Password.ReadInput();
                            break;
                        case 0: exit = false; break;
                    }
                }
                //}
                //catch { }
            }
            while (exit);
        }

        static void MinNumber()  //Minnumber function (C) K.O.
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter 3 numbers:");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int z = Convert.ToInt32(Console.ReadLine());

                int minNum = 0;
                Console.Clear();
                if (x < y && x < z)
                {
                    minNum = x;
                }
                else
                {
                    if (y < z)
                        minNum = (y);
                    else
                        minNum = z;
                }
                Console.WriteLine($"Minimum number is: {minNum}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter integer value");
            }
        }

        static void AvgMulti8()
        {
            Console.Clear();
            double result = 0;
            double count = 0;
            int x;
            try
            {
                Console.WriteLine("Enter numbers, 0 - exit");
                do
                {
                    x = int.Parse(Console.ReadLine());
                    if (x > 0 && x % 8 == 0)
                    {
                        result = result + x;
                        count++;
                    }
                }
                while (x != 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only int value");
                Console.ReadKey();
            }
            if (result == 0) 
            {
                //А код где? Или сообщение?
            }
            else
            {
                Console.WriteLine($"Average multiple 8 = {result / count}");
                Console.ReadKey();
            }
        }

        static bool LogPassChecker()
        {
            int count = 0;
            string login;
            string password;
            do
            {
                Console.Clear();
                Console.Write("Enter login: ");
                login = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (login == "root" && password == "GeekBrains")
                    return true;
                else
                    count++;
            }
            while (count != 3);
            return false;
        }

        static void BodyMassIndex()         //again -_-
        {
            double BMIRec;
            double BMI;
            try
            {
                Console.Clear();
                Console.Write("Enter your body height: ");
                double BHeight = Int32.Parse(Console.ReadLine()) * 0.01;
                Console.Write("Enter your body weight: ");
                double Bweight = Double.Parse(Console.ReadLine());
                BMI = Bweight / Math.Pow(BHeight, 2);
                if (BMI >= 18.5 && BMI <= 25)
                {
                    Console.WriteLine("Your weight is ok!");
                }
                else
                {
                    if (BMI < 18.5)
                    {
                        BMIRec = (18.5 - BMI) * Math.Pow(BHeight, 2);
                        Console.WriteLine($"You need to gain {BMIRec:F2} kilograms");
                    }
                    else
                    {
                        BMIRec = (BMI - 25) * Math.Pow(BHeight, 2);
                        Console.WriteLine($"You need to lose {BMIRec:F2} kilograms");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Next time try enter correct value");
            }
            Console.ReadKey();
        }
    }
}
