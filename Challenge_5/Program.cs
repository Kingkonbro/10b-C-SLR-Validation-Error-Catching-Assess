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
            enterAttributes();
        }
        static int getNumber()
        {
            int number = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter number between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());

                if ((number >= 0) && (number <= 100))
                {
                    valid = true;
                }

                if (!valid)
                {
                    Console.WriteLine("That number isn't between 0 and 100, please enter again.");
                }

                
            }
            return number;
        }
        static string getName()
        {
            bool valid = false;
            string name = "";
            while (!valid)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                if ((name.Length) > 0)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Name cannot be left blank.");
                }
            }
            return name;
        
        }
        static void enterAttributes()
        {
            int number0 = getNumber();
            int number1 = getNumber();
            string name = getName();
            saveChanges(name, number0, number1);
        }
        static void saveChanges(string name, int number0, int number1)
        {
            try
            {
                string filePath = (Directory.GetCurrentDirectory()) + @"/attributes.csv";
                StreamWriter file = new StreamWriter(filePath, true);
                file.WriteLine($"{name},{number0},{number1}");
                file.Close();
            }
            catch
            {
                Console.WriteLine("The file couldn't be written to.");
            }
        }
    }
}
