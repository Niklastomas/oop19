using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.Write("Choose between 1, 2 and 3: ");
                int userInput = int.Parse(Console.ReadLine());
            

                switch (userInput)
                {
                    case 1:
                        Console.Write("Input first number: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Input second number: ");
                        int b = int.Parse(Console.ReadLine());
                        if (b != 0)
                        {
                            Console.WriteLine("First number / second number = {0}", a / b);
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }

                        break;

                    case 2:
                        string orginalText = "The quick fox Jumped Over the DOG";

                        string newText = orginalText.Replace("quick", "brown").Insert(30, "lazy ");
                        newText = newText.Substring(0, 1).ToUpper() + newText.Substring(1).ToLower();

                        Console.WriteLine(newText);
                        Console.ReadLine();
                        break;

                    case 3:


                        Console.WriteLine("Default Foreground Color: {0}", Console.ForegroundColor);
                        if (Console.ForegroundColor == ConsoleColor.Blue)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Foreground Color is now: {0}", Console.ForegroundColor);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Foreground Color is now: {0}", Console.ForegroundColor);
                        break;
                }


            }
            
                    

                    
                 
            
        }
    }
}

                    
