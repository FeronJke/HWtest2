using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework3
{
    public struct Complex
    {
        public double re;
        public double im;

        public static Complex GetComplex()//Input Complex num to standard stream
        {
            Complex x;
            bool checkRe;
            bool checkIm;
            //Console.Clear();
            do
            {
                Console.WriteLine("Enter complex: ");
                checkRe = double.TryParse(Console.ReadLine(), out x.re);
                checkIm = double.TryParse(Console.ReadLine(), out x.im);
            }
            while (!checkRe || !checkIm);
            return (x);


        }
        public static void WriteComplex(Complex x) //Output Complex num to standard stream

        {
            Console.WriteLine($"[{x.re:F0} , {x.im:F0}i]");
            Console.ReadKey();
        }
        public static Complex Plus(Complex x, Complex y) //Complex 1 + Complex 2

        {
            x.re = x.re + y.re;
            x.im = x.im + y.im;
            return (x);
        }

        public static Complex Multi(Complex x, Complex y) //Complex 1 * Complex 2
        {
            Complex Mult;
            Mult.re = x.re * y.re - x.im * y.im;
            Mult.im = x.im * y.re + x.re * y.im;
            return (Mult);
        }

        public static Complex Minus(Complex x, Complex y) //Complex 1 - Complex 2
        {
            x.re = x.re - y.re;
            x.im = x.im - y.im;
            return (x);
        }

        public static Complex Divide(Complex x, Complex y) //Complex 1 / Complex 2
        {
            Complex Cdiv;
            Cdiv.re = (x.re * y.re + x.im * y.im) / (Math.Pow(y.re, 2) + Math.Pow(y.im, 2));
            Cdiv.im = (x.im * y.re - x.re * y.im) / (Math.Pow(y.re, 2) + Math.Pow(y.im, 2));
            return (Cdiv);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter complex numbers: ");  //U don't see that -_-
            Complex x = Complex.GetComplex();
            Complex y = Complex.GetComplex();*/
          
        
        bool exit = true;
        int swPos;
            do
            {
                Console.Clear();

                Console.WriteLine("Choose operation\n1 - Complex sum\n2 - Complex multi \n3 - Complex minus\n4 - Complex divide\n0 - Exit\n");   //Menu
                bool check = int.TryParse(Console.ReadLine(), out swPos);
                if (check)
                {

                    switch (swPos)
                    {
                        case 1:
                            Console.Clear();
                            Complex.WriteComplex(Complex.Plus(Complex.GetComplex(),Complex.GetComplex()));
                            break;
                        case 2:
                            Console.Clear();
                            Complex.WriteComplex(Complex.Multi(Complex.GetComplex(), Complex.GetComplex()));
                            break;
                        case 3:
                            Console.Clear();
                            Complex.WriteComplex(Complex.Minus(Complex.GetComplex(), Complex.GetComplex()));
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Complex.WriteComplex(Complex.Divide(Complex.GetComplex(), Complex.GetComplex()));
                            break;



                        case 0: exit = false; break;
                    }
                }
            }
            while (exit);
}
        /*static int CheckInput()
        {
            int x;
            bool check;
            do
            {
                Writel
                check = (int.TryParse(Console.ReadLine(), out x));
                return (x);
            }
            while (x != 0);
        }
        */
    }
  
    //uint num = 0;
    //uint result = 0;
    //Console.WriteLine("Enter natural numbers:");
    //do
    //{ 
    //    uint.TryParse(Console.ReadLine(), out num);
    //    if (num % 2 != 0)
    //        result = result + num;
    //}
    //while (num != 0);
    //Console.WriteLine($"Sum of all odd numbers = {result}");
    //Console.ReadKey();
}
