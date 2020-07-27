using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Task2
{
    class Program
    {
        public delegate double MyFunc(double x);
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return Math.Cos(x);
        }
        public static void SaveFunc(string fileName, double a, double b, double h, MyFunc F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double d;
            double[] Mass = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                Mass[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return Mass;
        }
        public static void Input(out int x1, out int x2)
        {
            bool fch, sch;
            do
            {

                Console.Clear();
                Console.WriteLine("Input function segment: ");
                Console.Write("x1: ");
                fch = Int32.TryParse(Console.ReadLine(), out x1);
                Console.Write("x2: ");
                sch = Int32.TryParse(Console.ReadLine(), out x2);
            }
            while ((fch && sch) != true);

        }



        public static void Main(string[] args)
        {
            MyFunc[] Func = { F1, F2 };
            int x1, x2;
            Console.WriteLine("Choose\n0: F1 func (x * x - 50 * x + 10)\n1: F2(Cos(x) func");
            int choice = Convert.ToInt32(Console.ReadKey().Key);
            if (choice == 49) choice = 1;           //Simple readkey translation -_-
            else choice = 0;
            Input(out x1, out x2);
            SaveFunc("data.bin", x1, x2, 0.5, Func[choice]);
            double fmin = double.MaxValue;
            double[] arr = Load("data.bin", out fmin);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine($"\nFunction min: {fmin}");
                Console.ReadKey();
        }
    }
}
