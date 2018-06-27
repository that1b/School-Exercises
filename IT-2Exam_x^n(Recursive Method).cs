using System;
namespace that1b
{
    class Exercise
    {
        static int Func(int x, int n)
        {
            if (x == 0)
                return 0;
            else if (n == 1)
                return x;
            else if (n == 0)
                return 1;
            else
                return x * Func(x, n - 1);
        }
       static void Main()
        {
            bool answer = true;
            char input;
            do
            {
                Console.Write("Input number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Input degree:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}^{1}={2}", a, b, Func(a, b));
                Console.Write("Do you wish to continue?(type 'y' if so or type 'n' to exit):");
                input = Char.Parse(Console.ReadLine());
                if(input == 'n')
                {
                    answer = false;
                }

            } while (answer);
        }
    }
}
