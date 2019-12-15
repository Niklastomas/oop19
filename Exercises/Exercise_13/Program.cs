using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 500);
            

            while (true)
            {
                Console.Write("Guess a number between 1 - 500: ");
                int userGuess = int.Parse(Console.ReadLine());

                if(userGuess < random)
                {
                    Console.WriteLine("Guess is too small!");
                }
                else if (userGuess > random)
                {
                    Console.WriteLine("Guess is too big!");
                }
                else
                {
                    Console.WriteLine("You guessed {0} and that was correct!",userGuess);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
