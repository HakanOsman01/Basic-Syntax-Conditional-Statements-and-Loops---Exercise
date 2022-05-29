using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double countCoins = 0.00;
            // •	0.1, 0.2, 0.5, 1, and 2
            while (coins != "Start")
            {
                if (coins == "0.1" || coins == "0.2" || coins == "0.5" || coins == "1" || coins == "2")
                {
                    countCoins += Convert.ToDouble(coins);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                coins = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Nuts")
                {
                    if (countCoins >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        countCoins -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    if (countCoins >= 0.70)
                    {
                        Console.WriteLine($"Purchased water");
                        countCoins -= 0.70;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    if (countCoins >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        countCoins -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    if (countCoins >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        countCoins -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Coke")
                {
                    if (countCoins >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        countCoins -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {countCoins:f2}");
        }
    }
}