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
                            Environment.Exit(0);
                        }
                    }
            }
        }

        static void ProcessSalaries(int count)
        {
            int sal1 = ReadInt("Ange lön 1: ");
            int sal2 = ReadInt("Ange lön 2: ");
            int sal3 = ReadInt("Ange lön 3: ");
            int[] salary = {sal1, sal2, sal3};
            
        }

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
