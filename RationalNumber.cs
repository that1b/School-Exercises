using System;
namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            RationalNumber a = new RationalNumber();
            RationalNumber b = new RationalNumber(1, 4);
            RationalNumber c = new RationalNumber(2,6);
            Console.WriteLine("a={0},decimal:{1}", a, a.ToDecimal());
            Console.WriteLine("b={0},decimal:{1}", b, b.ToDecimal());
            if (c != null)
            {
                Console.WriteLine("c={0},decimal:{1}", c, c.ToDecimal());
            }
            Console.ReadLine();
        }
    }
}
