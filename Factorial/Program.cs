using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
        static int Fact(int n)
        {
            if (n >= 1)
            {
                return n * Fact(n - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
