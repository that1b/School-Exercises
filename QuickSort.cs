using System;
namespace QuickSort
{
    class Program
    {
        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];
            while (i <= j)
            {
                while (elements[i] < pivot)
                { i++; }
                while (elements[j] > pivot)
                { j--; }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
                Quicksort(elements, left, j);

            if (i < right)
                Quicksort(elements, i, right);

        }

        static void Main(string[] args)
        {
            var r = new Random();
            // Create an unsorted array of int elements
            int[] unsorted = new int[r.Next(1, 11)];

            // Filling the unsorted array with random elements
            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = r.Next(1, 101);
            }

            // Print the unsorted array
            Console.Write("Unsorted version: ");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            Console.Write("Sorted version(Quick sort): ");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
