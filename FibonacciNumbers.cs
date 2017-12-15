using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(0);
            else if (n == 2)
                Console.WriteLine(1);
            else
            {
                int prev1 = 1;
                int prev2 = 0;
                int fibonacci = 1;
                for (int i = 3; i <= n; i++)
                {
                    fibonacci = prev1 + prev2;
                    Console.WriteLine("{1} = {0}", fibonacci,i);
                    prev2 = prev1;
                    prev1 = fibonacci;
                }
                Console.WriteLine(fibonacci);

            }
            Console.ReadLine();
        }
    }
}
