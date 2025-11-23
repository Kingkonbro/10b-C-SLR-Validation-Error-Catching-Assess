using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phone number which must start with 0 and be 11 digits");
            string phoneNumber = Console.ReadLine();

            if ( (validTelephoneNumber(phoneNumber)) == true)
            {
                Console.WriteLine("Thank you for following instructions");
            }

            else
            {
                Console.WriteLine($"{phoneNumber} is not a valid phone number!");
            }

        }
        static bool validTelephoneNumber(string number)
        {
            bool valid = false;
            if (number.Substring(0, 1) == "0")
            {
                if ((number.Length) == 12)
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}
