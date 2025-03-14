using System;
using System.ComponentModel;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// collect input from console and put it in a array
        /// if the array length is ==3 then is collects the input 
        /// then he converts them into the appropriate type of variable
        /// and prints the result
        /// </summary>
        /// <param name="args"></param>
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
            else
            {
                Console.WriteLine(Decor());
            }
        }
        /// <summary>
        /// creates phrase with given requisites
        /// </summary>
        /// <param name="s">a string representing the phrase</param>
        /// <param name="dec">a char representing the symbols in the start and end of the phrase</param>
        /// <param name="i">an int representing the amount of times the symbol will be repeated</param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns a message when no arguments are presented
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
