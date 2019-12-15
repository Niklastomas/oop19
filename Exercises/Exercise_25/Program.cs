using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ReadInt("Enter a number: ");
            int y = ReadInt("Enter a second number");

            Console.WriteLine($"{x} / {y} = {Divided(x, y)}");
            Console.ReadLine();
        }
        static int ReadInt(string text)
        {
            int number;

            while (true)
            {
                Console.WriteLine(text);
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Try again!");
                    continue;
                    
                }
                return number;
                

            }
        }
        static int Divided(int a, int b)
        {
            int divided = 0;
            try
            {
                divided = a / b;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cant divide by zero");
                
                
            }
            return divided;
        }
    }
}
