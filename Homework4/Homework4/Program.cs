using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassForArray.ArrGen(20);
            /*try
            {
                int[] array = ClassForArray.GetArrFromFile(@"C:\array.txt");
                foreach(var num in array)
                {
                    Console.WriteLine($"{num}");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("File not found.");
            }*/
            int[] MyArr = ClassForArray.ArrConstruct(10, 1, 1);
            foreach(var i in MyArr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\n{ClassForArray.Sum(MyArr)}");


        }
        class ClassForArray
        {
            int[] MyArray;
            public object Get { get; private set; }

            public static int[] GetArrFromFile(string path)
            {
                string[] newArr = File.ReadAllLines(path);
                int[] temp = new int[newArr.Length];
                for (int i = 0; i < newArr.Length; i++)
                {
                    temp[i] = Convert.ToInt32(newArr[i]);
                }
                return temp;

            }
            public static void ArrGen(int msize)
            {
                int count = 0;
                int[] MyArray = new int[msize];
                Random rnd = new Random();
                int i;
                for (i = 0; i < MyArray.Length; i++)
                {
                    MyArray[i] = rnd.Next(-10000, 10001);
                    Console.WriteLine($"{MyArray[i]}");

                }
                ClassForArray.ArrayDivide(MyArray);
            }
            public static void ArrayDivide(params int[] MyArray)
            {
                int count = 0;
                int i;
                for (i = 0; i < MyArray.Length - 1; i++)
                {
                    int curValue = MyArray[i];
                    int nextValue = MyArray[i + 1];

                    if ((curValue % 3 == 0) && (nextValue % 3 != 0))
                    {
                        count = count + 1;
                        Console.WriteLine($"\n{curValue} {nextValue}");
                    }
                }

                Console.WriteLine($"Total pair with only one number % 3 = {count}");
            }

            public static int[] ArrConstruct(int i, int sValue, int step)
            {
                int[] arr = new int[i];
                arr[0] = sValue;
                for (int j = 1; j < i; j++)
                {
                    arr[j] = arr[j - 1] + step;
                }
                return arr;
            }
            public static int Sum(int[] mass)
            {
                int sum = 0;
                for (int i = 0; i < mass.Length; i++) 
                {
                    sum += mass[i];     
                }
                return sum;
            }
                
             

        }
    }
}
