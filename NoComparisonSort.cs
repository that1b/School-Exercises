using System;
namespace Sorting_With_No_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var arr = new int[r.Next(1, 11)];
            var max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 101);
            }
            Console.Write("Array: ");
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            var count = new int[max + 1];


            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            Console.Write("Sorted version: ");
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write(" {0}",i);
                }
            }
            Console.ReadLine();
        }
    }
}
