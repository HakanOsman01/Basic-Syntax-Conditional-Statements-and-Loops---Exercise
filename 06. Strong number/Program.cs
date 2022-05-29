using System;

namespace _6._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 1;
            int realSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int curentDigith = number[i] - '0';
                for (int j = 1; j <= curentDigith; j++)
                {

                    sum *= j;

                }
                realSum += sum;
                sum = 1;

            }
            int realNumber = Convert.ToInt32(number);
            if (realNumber == realSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
