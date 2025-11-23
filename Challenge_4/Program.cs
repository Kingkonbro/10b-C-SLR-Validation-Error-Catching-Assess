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

            for (int i = 0; i < 4; i++)
            {
                bool validNumber = false;
                while (!validNumber)
                {
                    Console.Write("Number of tickets sold: ");
                    int ticketsSold = Convert.ToInt32(Console.ReadLine());
                    if (rangeCheck(ticketsSold, 0, 120))
                    {
                        validNumber = true;
                        preformances[i] = ticketsSold;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                }
            }
            int total = 0;
            foreach (int sold in preformances)
            {
                total += sold;
            }
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {total/4}");
        }
        static bool rangeCheck(int value, int max, int min)
        {
            bool valid = false;
            if ( (value <= min) && (value >= max) )
            {
                valid = true;
            }

            return valid;
        }
    }
}
