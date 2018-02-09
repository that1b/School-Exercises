using System;
namespace ExamExercise2RecursiveMethod
{
    class Program
    {
         public static int Func(int n)
        {
            if (n == 1)
                return 1;
            if (n==2)
                return 2;
            if (n == 3)
                return 3;
            else
                return Func(n - 1) + 2 * Func(n - 2) - 2 * Func(n - 3);
        }
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Func(n);
            Console.WriteLine("N{0} = {1}", n, Func(n));
            Console.ReadLine();
        }
    }
}
