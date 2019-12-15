using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal: ");
            double userInput = double.Parse(Console.ReadLine());
            
            Console.WriteLine("The square root of the number = {0} ", Math.Round(Math.Sqrt(userInput), 2));
            Console.WriteLine("The number raised to the power of 2 = {0}", Math.Round(Math.Pow(userInput, 2), 2));
            Console.WriteLine("The number raised to the power of 10 = {0}", Math.Round(Math.Pow(userInput, 10), 2));
            Console.ReadLine();


        }
    }
}
