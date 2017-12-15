using System;
    class Program
    {
        static int Fact(int num)
        {
            {
                if (num == 1)
                    return 1;
            }
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}",n,Fact(n));
            Console.ReadLine();
        }
    }
