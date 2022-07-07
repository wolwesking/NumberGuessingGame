using System;

namespace A_Number_Guessing_Game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(0, 100);

            bool win = false;
            int Gnum;

            Console.WriteLine("Number Guessing game: ");
            while (win == false)
            {

                string num = Console.ReadLine();

                if (int.TryParse(num, out Gnum))
                {

                    if (Gnum < number)
                    {
                        Console.WriteLine("Higher");

                    }
                    else if (Gnum > number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (Gnum == number)
                    {
                        Console.WriteLine("You WIN!!!!");
                        win = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
                Console.Write("Next Guess: ");
            }
        }
    }
}

// Created by wolwesking 7/7/22 12:05PM