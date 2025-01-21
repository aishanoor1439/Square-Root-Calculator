using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Square Root Calculator!");

            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            try
            {
                double number = Convert.ToDouble(input);

                if (number < 0)
                {
                    Console.WriteLine("Error: Cannot compute square root of a negative number.");
                }
                else
                {
                    double result = Math.Sqrt(number);
                    Console.WriteLine("The square root of {0} is {1}", number, result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
        }
    }
}
