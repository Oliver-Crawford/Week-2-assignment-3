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
            int intM = 0;
            int intN = 0;
            int[,] array;
            int smallestRowIndex = 0;
            int smallestRowSum = int.MaxValue;
            int tempSum = 0;
            Console.WriteLine("Please input number N that's greater than 0.");
            
            while (intN <= 0)
            {
                intN = sanitizeIntInput();
                if (intN <= 0)
                {
                    Console.WriteLine($"{intN} isn't greater than 0, try again");
                }
            }
            Console.WriteLine("Please input number M that's greater than 0.");
            while (intM <= 0)
            {
                intM = sanitizeIntInput();
                if (intM <= 0)
                {
                    Console.WriteLine($"{intM} isn't greater than 0, try again");
                }
            }
            array = new int[intM, intN];
            for(int i = 0; i < intM; i++)
            {
                for(int a = 0; a < intN; a++)
                {
                    Console.WriteLine($"Input a number for position {i}, {a}");
                    array[i, a] = sanitizeIntInput();
                }
            }
            Console.WriteLine("The array: ");
            for (int i = 0; i < intM; i++)
            {
                for (int a = 0; a < intN; a++)
                {
                    if (a == 0)
                    {
                        Console.Write($"{array[i, a]}");
                    } else
                    {
                        Console.Write($", {array[i, a]}");
                    }
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < intM; i++)
            {

                for (int a = 0; a < intN; a++)
                {
                    tempSum += array[i, a];
                }
                if (tempSum < smallestRowSum)
                {
                    
                    smallestRowIndex = i;
                    smallestRowSum = tempSum;
                }
                tempSum = 0;
            }
            Console.WriteLine($"The index of the row with the smallest sum of all elements is: {smallestRowIndex}");
            Console.ReadLine();
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
