using System;

namespace HW6
{
    public delegate double Fun(double x,double a);
    class Program
    {
        public static void Table(Fun F, double x, double b,double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }


        public static double HWFunc1(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }
        public static double HWFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {

            Table(HWFunc1, -2, 2, 2);  
            Table(delegate (double x, double a)
            {
                return a * Math.Pow(x, 2);
            }, -2, 2, 2);

            Table(HWFunc2, -2, 2, 2);
            Table(delegate (double x, double a)
            {
                return a * Math.Sin(x);
            }, -2, 2, 2);


        }
    }
}
