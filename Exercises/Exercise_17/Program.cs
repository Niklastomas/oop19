using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();

            text = text.ToLower();
            text = text.Replace("a");
            char[] temp = text.ToCharArray();
            Array.Reverse(temp);
            string textReversed = new string(temp);

            if (text == textReversed)
            {
                Console.WriteLine("It's a palindrome string!");
            }
            else
            {
                Console.WriteLine("It's not a palindrome string!");
            }
            Console.ReadLine();
        }
    }
}
