using System;

namespace _9._Padawan_Equipment__
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobers = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double totalMoneyNeed = 0.00;
            int percantage = (int)Math.Ceiling(countStudents * 0.10);
            totalMoneyNeed += priceLightSabers * (countStudents + (percantage)) +
                (priceBelts * countStudents) + (priceRobers * countStudents);
            for (int i = 1; i <= countStudents; i++)

            {
                if (i % 6 == 0)
                {
                    totalMoneyNeed -= priceBelts;
                }
            }
            if (money >= totalMoneyNeed)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeed:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoneyNeed - money:f2}lv more.");
            }
        }
    }
}