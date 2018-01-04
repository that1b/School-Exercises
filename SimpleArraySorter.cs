using System;

namespace SortedArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            Console.Write("Въведете дължина на масива: ");
            int n = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведи число: ");
                arr[i] = decimal.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                decimal temp;


                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
