using System;

namespace T2
{
    public static class nnop
    {
        public static string[] LimWordsLength(string sms, int n)
        { 
            string[] mass = new string[sms.Length];
            string[] resmass = new string[sms.Length];
            for (int i = 0; i < sms.Length; i++)
                if (char.IsPunctuation(sms[i])) sms.Remove(i, 1);
            mass = sms.Split(' ');
            for (int j = 0; j < sms.Length; j++)
                if (mass[j].Length <= n)  resmass[j] = mass[j];
            return resmass;
        }
    }
}
