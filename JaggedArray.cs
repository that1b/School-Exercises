using System;
class JaggedArray
{
    static void Main(string[] args)
    {
        int[][] jaggedA = new int[2][];
        jaggedA[0] = new int[3] { 1, 2, 3 };
        jaggedA[1] = new int[1] { 4 };
        foreach (var arr in jaggedA)
        {
            foreach (var element in arr)
            Console.Write("{0} ", element);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
