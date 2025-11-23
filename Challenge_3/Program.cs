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
                Console.Write("Enter password: ");
                string pass = Console.ReadLine();

                if (checkLength(pass) && checkForUpper(pass) && checkForLower(pass) && checkForNumber(pass))
                {
                    Console.WriteLine("Password accepted");
                    valid = true;
                }

                else
                {
                    Console.WriteLine("Please make sure that the password has 8 to 15 characters, at least one upper and lower case letter and a digit");
                }
            }
        }
        static bool checkLength(string value)
        {
            bool valid = false;
            if ( ((value.Length) >= 8) && ((value.Length) <= 15))
            {
                valid = true;
            }

            return valid;
        }
        static bool checkForUpper(string value)
        {
            bool valid = false;
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    valid = true;
                }
            }
            return valid;
        }
        static bool checkForLower(string value)
        {
            bool valid = false;
            foreach (char c in value)
            {
                if (char.IsLower(c))
                {
                    valid = true;
                }
            }
            return valid;
        }
        static bool checkForNumber(string value)
        {
            bool valid = false;
            foreach (char c in value)
            {
                if (char.IsNumber(c))
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}
