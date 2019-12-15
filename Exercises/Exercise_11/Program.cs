using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if(number != 0)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0 && i != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(i + ",");
                }
                Console.WriteLine();

                for(int i = number; i >= 0; i--)
                {
                    if (i % 2 == 0 && i != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(i + ",");
                }

            }
            else
            {
                Console.WriteLine("Error");
                
            }
            Console.ReadLine();
        }
    }
}
