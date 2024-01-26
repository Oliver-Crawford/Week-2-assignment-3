using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_assignment___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write an application which let user input 2 numbers N, M.
             * Then, create an array which has M row and Ncolumn and input the elements for those arrays.
             * Find the row which has the smallest sum of allelements among all rows in the array. */
            Console.WriteLine("Please input number N.");
            int intN = sanitizeIntInput();
            Console.WriteLine("Please input number M.");
            int intM = sanitizeIntInput();
            
        }
        static int sanitizeIntInput()
        {
            bool isInt = false;
            string input;
            int inputInt = 0;
            while (!isInt)
            {
                input = Console.ReadLine();
                isInt = int.TryParse(input, out inputInt);
                if (!isInt)
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
            return inputInt;
        }
    }
}
