using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_19_2017thursday
{
    class Program
    {
       static void Swap(ref int a,ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        static int ReadInt(string prompt)
        {
            int a;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out a);
                if (!valid)
                    Console.WriteLine("Input Number");
            }
            while (!valid);
            return a;
        }
        static void Main(string[] args)
        {
            int x = ReadInt("x= ");
            int y = ReadInt("y= ");
            
            

            Swap(ref x,ref y);
            Console.WriteLine("a={0}, b={1}", x, y);
            Console.ReadLine();

        }
    }
}
