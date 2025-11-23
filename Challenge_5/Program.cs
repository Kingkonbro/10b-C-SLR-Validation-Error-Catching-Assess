using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls the subroutine enterAttributes
            enterAttributes();
        }
        static int getNumber()
        {
            int number = 0;
            bool valid = false;

            while (!valid)
            {
                // Prompt user to enter number between 0 and 100
                Console.Write("Enter number between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());

                // Check if number is between 0 and 100
                if ((number >= 0) && (number <= 100))
                {
                    // Set valid to true if number is in range
                    valid = true;
                }

                // If number is not in range, prompt user to enter again
                if (!valid)
                {
                    Console.WriteLine("That number isn't between 0 and 100, please enter again.");
                }

                
            }
            // Return the valid number
            return number;
        }
        static string getName()
        {
            bool valid = false;
            string name = "";

            while (!valid)
            {
                // Prompt user to enter name
                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                // Check if name is not blank
                if ((name.Length) > 0)
                {
                    // Set valid to true if name is not blank
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Name cannot be left blank.");
                }
            }
            // Return the valid name
            return name;
        
        }
        static void enterAttributes()
        {
            // Call getNumber twice to get two valid numbers
            int number0 = getNumber();
            int number1 = getNumber();
            // Call getName to get a valid name
            string name = getName();
            // Call saveChanges to save the name and numbers to a CSV file
            saveChanges(name, number0, number1);
        }
        static void saveChanges(string name, int number0, int number1)
        {
            // Try to write the name and numbers to attributes.csv
            try
            {
                // Get the file path for attributes.csv in the current directory
                string filePath = (Directory.GetCurrentDirectory()) + @"/attributes.csv";

                // Open the file in append mode
                StreamWriter file = new StreamWriter(filePath, true);

                // Write the name and numbers to the file in CSV format
                file.WriteLine($"{name},{number0},{number1}");

                // Close the file
                file.Close();
            }
            // Catch any exceptions that occur during file writing
            catch
            {
                // Print an error message if the file couldn't be written to
                Console.WriteLine("The file couldn't be written to.");
            }
        }
    }
}
