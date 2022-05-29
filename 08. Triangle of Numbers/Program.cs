using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}