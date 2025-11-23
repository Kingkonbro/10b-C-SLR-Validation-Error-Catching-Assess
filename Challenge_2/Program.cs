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
            // Prompt user to enter phone number
            Console.WriteLine("Enter a phone number which must start with 0 and be 11 digits");
            string phoneNumber = Console.ReadLine();

            // Validate phone number
            if ( (validTelephoneNumber(phoneNumber)) == true)
            {
                // Display valid message
                Console.WriteLine("Thank you for following instructions");
            }

            // If phone number is not valid
            else
            {
                // Display invalid message
                Console.WriteLine($"{phoneNumber} is not a valid phone number!");
            }

        }
        static bool validTelephoneNumber(string number)
        {
            bool valid = false;

            // Check if number starts with 0 and is 11 digits long
            if (number.Substring(0, 1) == "0")
            {
                // Check if length is 11
                if ((number.Length) == 12)
                {
                    // Set valid to true
                    valid = true;
                }
            }

            // Return valid
            return valid;
        }
    }
}
