﻿using System;

namespace GuessANumber
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 8)
            {
                Console.WriteLine("You Win!");
            }

            else
            {
                Console.WriteLine("You Lose.");
            }
            // If they enter 8, output “You Win!”. Otherwise, output “You Lose.”. Do this using an inline if statement.

            Console.ReadLine();
        }
    }
}
