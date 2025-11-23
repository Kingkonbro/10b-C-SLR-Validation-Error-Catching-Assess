using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] preformances = new int[4];

            // Loop to get number of tickets sold for 4 performances
            for (int i = 0; i < 4; i++)
            {
                bool validNumber = false;
                while (!validNumber)
                {
                    // Prompt user to enter number of tickets sold
                    Console.Write("Number of tickets sold: ");
                    int ticketsSold = Convert.ToInt32(Console.ReadLine());

                    // Check if number is between 0 and 120
                    if (rangeCheck(ticketsSold, 0, 120))
                    {
                        // Set validNumber to true and store tickets sold
                        validNumber = true;
                        preformances[i] = ticketsSold;
                    }

                    // If number is not in range, display invalid message
                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                }
            }

            int total = 0;

            // Calculate total tickets sold 
            foreach (int sold in preformances)
            {
                total += sold;
            }

            // Display total and average
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {total/4}");
        }
        static bool rangeCheck(int value, int max, int min)
        {
            bool valid = false;

            // Check if value is between min and max
            if ( (value <= min) && (value >= max) )
            {
                // Set valid to true
                valid = true;
            }

            // Return valid
            return valid;
        }
    }
}
