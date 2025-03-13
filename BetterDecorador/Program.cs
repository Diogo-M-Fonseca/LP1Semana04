using System;
using System.ComponentModel;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*'));
            Console.WriteLine(Decor("Good Morning!", '.'));
        }
        private static string Decor(string s, char dec, int i)
        {   
            string decs = "";
            foreach (i in decs)
            {
                decs += dec
            }
            return $"{decs} {s} {decs}";
        }
    }
}
