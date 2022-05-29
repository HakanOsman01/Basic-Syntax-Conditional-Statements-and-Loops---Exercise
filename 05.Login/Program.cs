using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = string.Empty;
            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }
            string entry = Console.ReadLine();
            int count = 0;
            bool isUserBlock = true;
            while (entry != password)
            {

                count++;
                if (count == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    isUserBlock = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                entry = Console.ReadLine();
            }
            if (isUserBlock)
            {
                Console.WriteLine($"User {user} logged in.");
            }

        }
    }
}