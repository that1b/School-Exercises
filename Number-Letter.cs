using System;
namespace Exercise1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете едно трицифрено число");
            string vhod = Console.ReadLine();
            Console.WriteLine("Вие въведохте числото {0} ", vhod);
            char bukva = '0';
            char bukva2 = '9';
            int bukvaAsChislo = bukva;
            int bukva2AsChislo = bukva2;
            Console.WriteLine("Буква1: {0} Буква2: {1}",
                                bukvaAsChislo, bukva2AsChislo);
            

            int digit0 = vhod[0] - '0';
            int digit1 = vhod[1] - '0';
            int digit2 = vhod[2] - '0';
      




            Console.WriteLine("Първата цифра на вашето число е {0}", digit0);

            int sumDigits = digit0 + digit1 + digit2;
            Console.WriteLine("Сумата е равна на {0}", sumDigits);

            char bukva3 = (char)('а' + sumDigits - 1);
            Console.WriteLine("Буквата = {0}", bukva3);
            Console.Read();
        }
    }
}
