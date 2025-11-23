using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a positive value
            Console.WriteLine("Input a positive value");
            numberCheck (Convert.ToInt32(Console.ReadLine()));
        }
        static void numberCheck(int num)
        {
            // Check if number is positive
            if (num >= 0)
            {
                // Display thank you message
                Console.WriteLine("Thank you for following instructions");
            }

            // If number is not positive
            if (num < 0)
            {
                // Display that number is not positive
                Console.WriteLine($"{num} is not a positive number!");
            }
        }
    }
}
