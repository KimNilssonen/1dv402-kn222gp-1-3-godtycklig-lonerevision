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
            while(true)
            { 
                int read;
           
                    read = ReadInt("Ange antal löner att mata in: ");

                if (read >= 2)
                {
                    ProcessSalaries(read);
                    break;
                }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDu måste mata in minst två löner för att göra en beräkning!\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Tryck valfri tangent för ny beräkning - Esc avslutar.\n");
                        Console.ResetColor();

                        if(Console.ReadKey(true).Key != ConsoleKey.Escape)
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    }
            }
        }

        // 2. Uträkning och presentation av löner.
        static void ProcessSalaries(int count)
        {

            // Skapa arrays.
            int[] salaries = new int[count];
            int[] unsortSalaries = new int[count];

            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt("Ange lön nummer " + (i + 1) + ": ");
            }


            Array.Sort(salaries);
            int median = salaries.Length / 2;
            int salAverage = (int)salaries.Average();
            int salDifference = salaries.Max() - salaries.Min();
            
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Medianlön    : {0, 5:c0}", median);
            Console.WriteLine("Medellön     : {0, 5:c0}", salAverage);
            Console.WriteLine("Lönespridning: {0, 5:c0}", salDifference);
            Console.WriteLine("-------------------------\n");

        }

        // 3. Inmatning från tangentbord.
        static int ReadInt(string prompt)
        {
            while (true)
            {
                try
                {
                    int input;
                    Console.Write(prompt);
                    input = int.Parse(Console.ReadLine());
                    return input;
                }
                   
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kan inte tolka '{0}' som ett heltal.", "dummy");
                    Console.ResetColor();
                }
                
            }

        }

    }
}
