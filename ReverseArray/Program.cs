using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            
            
        }
        private static void Run()
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseArray(numbers, 0, numbers.Length - 1);
            foreach (var n in numbers)
                Console.Write(n + " ");

        }

        private static void ReverseArray(int[] data, int low, int high)
        {
            if (low < high)
            {
                int temp = data[low];
                data[low] = data[high];
                data[high] = temp;

                ReverseArray(data, low + 1, high - 1);
            }
        }
    }
}
