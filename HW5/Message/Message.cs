using System;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Message
{
    public static class Messaga
    {
        public static string[] LimWordsLength(string sms, int n)
        {
            int i = 0;
            string[] mass = new string[sms.Length];
            int count = 0;
            //for (i = 0; i < sms.Length; i++)
            //{
            //    mass[i] = "";
            //    resmass[i] = "";
            //}
            for (i = 0; i < sms.Length; i++)
                if (char.IsPunctuation(sms[i]))                   //Delete punctuation from string
                {
                    sms = sms.Remove(i, 1);
                    i--;
                }
            mass = sms.Split(' ');                                //fill massive with split string method
            for (i = 0; i < mass.Length; i++)
                if (mass[i].Length <= n) count++;             //Found 
            string[] resmass = new string[count];
            count = 0;
            for (i = 0; i < mass.Length; i++)
                if (mass[i].Length <= n)
                {
                    resmass[count] = mass[i];
                    count++;
                }
            return resmass;
        }
        public static string DelWordsEndsOf(string text, char sym)
        {
            string newText = "";
            Regex reg = new Regex($@"\b[a-zA-Z0-9]*{sym}\b");
            newText = reg.Replace(text, "");
            return newText;
        }
        public static string LongestWord(string text)
        {
            string res = "";
            string temp = "";
            string[] mass = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]))
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            mass = text.Split(' ');
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j].Length > res.Length) temp = mass[j];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == temp.Length) res += $"{mass[i]} ";
            }
            return res;
        }
        public static Dictionary<string, int> FreqAnalize(string[] words, string text)
        {
            string key = "";

            string[] myStr = new string[text.Length];
            myStr = text.Split(' ');
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < myStr.Length; j++)
                {
                    if (words[i] == myStr[j]) count++;
                }
                dic.Add(words[i], count);
            }
            return dic;

        }

    }
}
