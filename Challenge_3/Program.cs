using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {
                // Prompt user to enter password
                Console.Write("Enter password: ");
                string pass = Console.ReadLine();

                // Check password validity
                if (checkLength(pass) && checkForUpper(pass) && checkForLower(pass) && checkForNumber(pass))
                {
                    // If password is valid, accept it
                    Console.WriteLine("Password accepted");
                    valid = true;
                }

                // If password is not valid
                else
                {
                    // Prompt user to enter again
                    Console.WriteLine("Please make sure that the password has 8 to 15 characters, at least one upper and lower case letter and a digit");
                }
            }
        }
        static bool checkLength(string value)
        {
            bool valid = false;

            // Check if length is between 8 and 15
            if ( ((value.Length) >= 8) && ((value.Length) <= 15))
            {
                // Set valid to true if length is valid
                valid = true;
            }

            // Return valid
            return valid;
        }
        static bool checkForUpper(string value)
        {
            bool valid = false;

            // Check for uppercase letters
            foreach (char c in value)
            {
                // If uppercase letter found
                if (char.IsUpper(c))
                {
                    // Set valid to true
                    valid = true;
                }
            }

            // Return valid
            return valid;
        }
        static bool checkForLower(string value)
        {
            bool valid = false;

            // Check for lowercase letters
            foreach (char c in value)
            {
                // If lowercase letter found
                if (char.IsLower(c))
                {
                    // Set valid to true
                    valid = true;
                }
            }

            // Return valid
            return valid;
        }
        static bool checkForNumber(string value)
        {
            bool valid = false;

            // Check for numeric characters
            foreach (char c in value)
            {
                // If numeric character found
                if (char.IsNumber(c))
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
