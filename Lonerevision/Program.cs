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

                    // If you write less than two, this message will appear.
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou have to enter atleast two salaries to make a calculation!\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Press any key to do a new calculation - Esc to exit.\n");
                        Console.ResetColor();
                    }

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
            int firstMedian = salaries.Length / 2;
            int secondMedian = firstMedian - 1;
            int median = salaries[firstMedian + secondMedian / 2];

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

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to do a new calculation - Esc to exit.\n");
            Console.ResetColor();
        }

        // 3. Reads the keyboard.
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input;
                input = Console.ReadLine();
                try
                {
                    int number = int.Parse(input);
                    return number;
                }
                   
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Can not translate '{0}' as a integer.", input);
                    Console.ResetColor();
                }
                
            }

        }

    }
}
