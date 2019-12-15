using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string newStr = str.Substring(65);
            newStr = newStr.Remove(2, 4);
            newStr = newStr.Insert(6, ",6,7,8,9,10");
            
            Console.WriteLine(newStr);
            Console.ReadLine();

        }
    }
}
