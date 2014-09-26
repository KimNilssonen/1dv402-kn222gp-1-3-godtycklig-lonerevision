using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Make a loop to enter salaries, using the method, ReadInt.
            while(true)
            {
                
                int read;
           
                    read = ReadInt("Enter the amount of salaries: ");


                if (read >= 2)
                {
                    ProcessSalaries(read);
                    
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress any key to do a new calculation - Esc to exit.\n");
                Console.ResetColor();


                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        // 2. Calculation and presentation of salaries.
        static void ProcessSalaries(int count)
        {

            // Create arrays.
            int[] salaries = new int[count];
            int[] unsortSalaries = new int[count];

            // Counting the arrays.
            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt("Enter salary number " + (i + 1) + ": ");
            }

            // Calculates and presents salaries.
            unsortSalaries = (int[])salaries.Clone();

            // Median
            Array.Sort(salaries);
            int median;

            if(salaries.Length % 2 == 0)
            {
                int firstMedian = salaries.Length / 2;
                int secondMedian = firstMedian - 1;
                median = (salaries[firstMedian] + salaries[secondMedian]) / 2;
            }

            else
            {
                median = salaries[salaries.Length/2];
            }

            int salAverage = (int)salaries.Average();
            int salDifference = salaries.Max() - salaries.Min();

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Median salary  : {0, 10:c0}", median);
            Console.WriteLine("Average salary : {0, 10:c0}", salAverage);
            Console.WriteLine("Salary spread  : {0, 10:c0}", salDifference);
            Console.WriteLine("----------------------------------\n");


            // Presents the salaries entered, in the order you entered them.
            for (int i = 0; i < count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("{0,10} ", unsortSalaries[i]);
            } 
        }

        // 3. Reads the keyboard.
        static int ReadInt(string prompt)
        {
            while (true)
            {
                // Makes a string which gets the value from the keyboard. I'm using this later in the "WriteLine".
                Console.Write(prompt);
                string input;
                input = Console.ReadLine();
                try
                {
                    // Making an int that gets the value of input and then returns that int.
                    int number = int.Parse(input);
                    if (number < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou have to enter atleast two salaries to make a calculation!\n");
                        Console.ResetColor();
                    }
                    

                    return number;
                }
                   
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Can not translate '{0}' as a integer.\n", input);
                    Console.ResetColor();
                }
                
            }

        }

    }
}
