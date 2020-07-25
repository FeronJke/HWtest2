using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using Message;
using System.Collections.Generic;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myMass = { "ar", "suf", "lim" };
            #region 1
            //string[] massive = new string[50];
            //Console.WriteLine("Enter login: ");
            //Console.WriteLine(LoginCheck(Console.ReadLine()));

            //massive = Messaga.LimWordsLength(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //for (int i = 0; i < massive.Length; i++)
            //{
            //    Console.WriteLine(massive[i]);
            //}

            //Console.WriteLine("Input string, after enter symbol:");
            //Console.WriteLine(Messaga.DelWordsEndsOf(Console.ReadLine(), char.Parse(Console.ReadLine())));

            //Console.WriteLine(Messaga.LongestWord(Console.ReadLine()));
            //static bool LoginCheck(string login)
            #endregion 1
            Dictionary<string, int> myDic = Messaga.FreqAnalize(myMass, Console.ReadLine());
            foreach (KeyValuePair<string, int> kvp in myDic)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }


            //{
            //    Regex reg = new Regex(@"\b[a-zA-Z]{1}[a-zA-Z0-9]{1,9}\b");
            //    return reg.IsMatch(login);
            //}
        }
    }
}
