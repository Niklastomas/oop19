using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = getIntegers("Enter first number: ");
            int num2 = getIntegers("Enter second number: ");

            Console.WriteLine("Smallest number is " + smallest(num1, num2));
            Console.WriteLine("Biggest number is " + biggest(num1, num2));
            Console.WriteLine("The difference is " + difference(num1, num2));
            Console.WriteLine("The product is " + product(num1, num2));
            Console.WriteLine("The sum is " + sum(num1, num2));
            Console.WriteLine("The division is " + division(num1, num2));

            Console.ReadLine();
            


        }
        static int smallest(int num1, int num2)
        {
            if(num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static int biggest(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static int difference(int num1, int num2)
        {
            return num1 - num2;
        }
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int product(int num1, int num2)
        {
            return num1 * num2;
        }
        static int division(int num1, int num2)
        {
            return num1 / num2;
        }
        static int getIntegers(string text)
        {
            Console.Write(text);
            int num = int.Parse(Console.ReadLine());
           
            return num;
            
        }


    }
}
