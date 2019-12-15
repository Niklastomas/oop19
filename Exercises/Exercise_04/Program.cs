using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string orginalText = "The quick fox Jumped Over the DOG";
            
            string newText = orginalText.Replace("quick", "brown").Insert(30, "lazy ");
            newText = newText.Substring(0, 1).ToUpper() + newText.Substring(1).ToLower();

            Console.WriteLine(newText);
            Console.ReadLine();
            
        }
    }
}
