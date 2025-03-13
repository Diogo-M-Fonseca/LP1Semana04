using System;

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

            return $"{dec*i} {s} {dec+i}";
        }
    }
}
