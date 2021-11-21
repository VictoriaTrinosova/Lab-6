using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            string[] stringArray = s.Split();
            int maxlen = 0, index = 0;
            for (int i=0; i<stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxlen)
                {
                    maxlen = stringArray[i].Length;
                    index = i;
                    
                }
                
            }
            Console.Write("Самое длинное слово: {0}", stringArray[index]);
            Console.ReadKey();
        }
    }
}
