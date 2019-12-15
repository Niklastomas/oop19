using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input numbers: ");
            string numberInput = Console.ReadLine();
            string [] splitted  = numberInput.Split(',');
            int[] numbers = new int[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                numbers[i] = int.Parse(splitted[i]);
            }

            int biggest = 0;
            int smallest = 0;
            int sum = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (smallest == 0)
                {
                    smallest = numbers[i];
                }
                if(numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];

                }
            }
            int average = sum / numbers.Length;
            Console.WriteLine($"Biggest number is {biggest}");
            Console.WriteLine($"Smallest number is {smallest}");
            Console.WriteLine($"The average is {average}");
            Console.ReadLine();


            


        }
    }
}
