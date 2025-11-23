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
            Console.WriteLine("Input a positive value");
            numberCheck (Convert.ToInt32(Console.ReadLine()));
        }
        static void numberCheck(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("Thank you for following instructions");
            }

            if (num < 0)
            {
                Console.WriteLine($"{num} is not a positive number!");
            }
        }
    }
}
