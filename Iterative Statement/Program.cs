//Author: Ethan Leary
//Date: 1/29/2021
//Description: Write a iterative statement that displays the number of times a user enters an integer value.
using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1-100");
            
            string inputstr = Console.ReadLine();
            int input = int.Parse(inputstr);
            int number;
            if (input <= 1)
            {
                Console.WriteLine("Please pick an integer between 1-100.");
            }
            else if (input >= 100)

            {
                Console.WriteLine("Please pick an integer between 1-100.");
            }
            else
            {
                for (number = 1; number <= input; number++)
                {

                    Console.WriteLine("You have entered " + input + ". This is the current integer value in the loop " + number);
                }
            }
            Console.ReadKey(true);
        }
    }
}
