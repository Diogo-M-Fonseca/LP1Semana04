using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            int i = int.Parse(Console.ReadLine());
        }
        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return GetSpecial(n-1) + 2 * (n-2);
        }
    }
}
