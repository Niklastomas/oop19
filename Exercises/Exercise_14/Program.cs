using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int average = 0;
            int sum = 0;
            List<int> listOfNumbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());

                if (number == -1)
                {
                    foreach (var numbers in listOfNumbers)
                    {
                        sum += numbers;
                    }
                    average = sum / listOfNumbers.Count;
                    Console.WriteLine("Sum of numbers: {0}", sum);
                    Console.WriteLine("Average of number: {0}", average);
                    Console.ReadLine();

                    break;
                }
                listOfNumbers.Add(number);
                Console.ReadLine();
                
                
               

            }

            
        }
    }
}
