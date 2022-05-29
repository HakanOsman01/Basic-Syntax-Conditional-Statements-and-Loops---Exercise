using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxDivisionNumber = 0;
            if (number % 2 == 0 || number % 3 == 0
                || number % 6 == 0 || number % 7 == 0 || number % 10 == 0)
            {

                if (number % 2 == 0)
                {
                    maxDivisionNumber = 2;
                }
                if (number % 3 == 0)
                {
                    maxDivisionNumber = 3;
                }
                if (number % 6 == 0)
                {

                    maxDivisionNumber = 6;
                }
                if (number % 7 == 0)
                {
                    maxDivisionNumber = 7;
                }
                if (number % 10 == 0)
                {
                    maxDivisionNumber = 10;
                }
                if (number % 2 == 0 && number % 3 == 0 && number % 6 == 0)
                {
                    maxDivisionNumber = 6;
                }
                if (number % 2 == 0 && number % 10 == 0)
                {
                    maxDivisionNumber = 10;
                }


                Console.WriteLine($"The number is divisible by {maxDivisionNumber}");

            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}

