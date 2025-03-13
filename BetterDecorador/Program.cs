using System;
using System.ComponentModel;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*', 2));
            Console.WriteLine(Decor("Good Morning!", '.', 2));
        }
        private static string Decor(string s, char dec, int i)
        {   
            string decs = "";
            int n;
            for (n= 0; n < i; n++)
            {
                decs += dec;
            }
            return $"{decs} {s} {decs}";
        }
    }
}
