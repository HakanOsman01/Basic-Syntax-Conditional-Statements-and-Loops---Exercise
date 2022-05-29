using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            double totalMoney = 0.00;
            for (int i = 1; i <= countOrders; i++)
            {
                double pricePerCapsula = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulaCount = int.Parse(Console.ReadLine());
                double price = ((days * capsulaCount) * pricePerCapsula);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalMoney += price;

            }
            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}
