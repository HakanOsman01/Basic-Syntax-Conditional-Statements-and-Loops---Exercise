using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else
                {
                    price = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else
                {
                    price = 16.00;
                }
            }
            else
            {
                if (day == "Friday")
                {
                    price = 15.00;
                }
                else if (day == "Saturday")
                {
                    price = 20.00;
                }
                else
                {
                    price = 22.50;
                }
            }
            double totalPrice = price * countPeople;
            if (type == "Students" && countPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (type == "Business" && countPeople >= 100)
            {
                totalPrice = totalPrice - (price * 10);
            }
            else if (type == "Regular" && (countPeople >= 10 && countPeople <= 20))
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}