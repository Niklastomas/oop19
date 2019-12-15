using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: " );
            int number = int.Parse(Console.ReadLine());
            
          
            
                

            for (int i = 1; i < number; i++)
            {
                int sum = 0;
                int j = 1;

                while (j < i)
                {

                    if(i % j == 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                        j++;
                    }
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
                

                
                




            }
            Console.ReadLine();
        }
    }
}
