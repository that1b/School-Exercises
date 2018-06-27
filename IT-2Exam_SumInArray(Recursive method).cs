using System;
namespace RekursiqTolga
{
    class Program
    {
        public static Random r = new Random();
        public static int Recursion(int[] array, int highIndx) // Calculating the sum of elements in array
        {
            if (highIndx == 1)
                return array[0];
            else
            {
                return array[highIndx - 1] + Recursion(array, highIndx - 1);
            }
        }
        public static void FillArray(int[] array) // Filling array with elements(positive integers)
        {
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 21);
            }
        }
        static void Main()
        {
            int[] a = new int[r.Next(1, 11)];
            FillArray(a);
            Console.WriteLine("Array: " + string.Join(" ", a));
            Console.WriteLine("Sum in array: " + Recursion(a, a.Length));
            Console.ReadLine();            
        }
    }
}
