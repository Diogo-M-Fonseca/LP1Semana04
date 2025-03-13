using System;
using System.ComponentModel;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string s = args[0];
                string c = args[1];
                string il = args[2];

                char dec = char.Parse(c);
                int i = int.Parse(il);

                Console.WriteLine(Decor(s,dec,i));
            }
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
