using System;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s2 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s2 += s[i];
            }
            if (s == s2)
            {
                Console.WriteLine("Фраза является палиндромом");
            }
            else
            {
                Console.WriteLine("Фраза не является палиндромом");
                Console.WriteLine(s2);
                Console.ReadKey();
            }



        }
    }
}