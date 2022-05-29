using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int countKayboarTrash = 0;
            double rageMoney = 0.00;
            for (int i = 1; i <= countLostGames; i++)
            {
                if (i % 2 == 0)
                {
                    rageMoney += headSetPrice;
                }
                if (i % 3 == 0)
                {
                    rageMoney += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    rageMoney += keyboardPrice;
                    ++countKayboarTrash;
                    if (countKayboarTrash % 2 == 0 && countKayboarTrash != 0)
                    {
                        rageMoney += displayPrice;
                    }
                }

            }
            Console.WriteLine($"Rage expenses: {rageMoney:f2} lv.");
        }
    }
}