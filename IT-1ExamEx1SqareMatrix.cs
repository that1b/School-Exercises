using System;
namespace ITExam1Matrix
{
    class StartUp
    {
        public static void Fill_Matrix(decimal[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (i > j)
                        array[i, j] = i + j;
                    else if (i < j)
                        array[i, j] = 4 * j + i * i * i;
                    else
                        array[i, j] = 0;
                }
            }
        }
 
        static decimal SumOfPositiveElements_EvenIndexes(decimal[,] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if ((i % 2 == 0 || j % 2 == 0) && array[i, j] > 0)
                        sum += array[i, j];
                }
            }
            return sum;
        }
 
        static decimal ProductOfNonZeroElements_OddIndexes(decimal[,] array)
        {
            decimal product = 1;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if ((i % 2 == 1 || j % 2 == 1) && array[i, j] != 0)
                        product *= array[i, j];
                }
            }
            return product;
        }
 
       public static void PositionOfMinPositiveElement(decimal[,] array)
        {
            int posRow = 0;
            int posCol = 0;
            decimal temp = decimal.MaxValue;
 
            for(int i = 0;i<array.GetLength(0);++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] > 0 && array[i, j] < temp)
                    {
                        temp = array[i, j];
                        posRow = i;
                        posCol = j;
                    }  
                }
            }
            Console.WriteLine($"The minimal positive element in the matrix is {temp} on position [{posRow},{posCol}].");
        }
 
         public static void HighestNegativeElement(decimal[,] array)
         {
            decimal temp = decimal.MinValue;
            for(int i =0;i<array.GetLength(0);++i)
            {
                for(int j = 0;j<array.GetLength(1);++j)
                {
                    if (array[i, j] < 0 && array[i, j] > temp)
                        temp = array[i, j];
                }
            }
            if (temp == decimal.MinValue)
                Console.WriteLine("No negative elements in the matrix.");
            else
                Console.WriteLine($"The highest negative element in the matrix: {temp}.");
         }
 
        public static void Print_Matrix(decimal[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input size for the square matrix: ");
            int size = int.Parse(Console.ReadLine());
            decimal[,] sq_Matrix = new decimal[size, size];
 
            Console.WriteLine("Filling Array...");
            Fill_Matrix(sq_Matrix);
            Print_Matrix(sq_Matrix);
            Console.WriteLine();
            Console.Write("The sum of all positive elements in the matrix" +
                            " with at least one even index: ");
            Console.WriteLine(SumOfPositiveElements_EvenIndexes(sq_Matrix));
            Console.Write("The product of all non zero elements in the matrix" +
                            " with at least one odd index: ");
            Console.WriteLine(ProductOfNonZeroElements_OddIndexes(sq_Matrix));
            PositionOfMinPositiveElement(sq_Matrix);
            HighestNegativeElement(sq_Matrix);
            Console.Write("Press any key to close the application.");
            Console.ReadKey();
        }
    }
}
