using System;
namespace ExamExercise2RecursiveMethod
{
    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Enter number: ");
                 n = int.Parse(Console.ReadLine());
                int num1 = 1, num2 = 2, num3 = 3;
                int temp;
                if (n == 1 || n == 2 || n == 3)
                    Console.WriteLine("N{0} = {0}", n);
                else
                {
                    for (int i = 3; i < n; i++)
                    {
                        temp = num3;
                        num3 = num3 + 2 * num2 - 2 * num1;
                        num1 = num2;
                        num2 = temp;
                    }
                    Console.WriteLine("N{0} = {1}",n, num3);
                }
            } while (n>0);
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
