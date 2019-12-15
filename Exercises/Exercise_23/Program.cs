using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            int rnd;
            int count = 0;

            while (count < 7)
            {
                rnd = random.Next(1, 41);
                

                if (!numbers.Contains(rnd))
                {
                    numbers.Add(rnd);
                    count++;
                    
                }
 
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

        }
            

            
            

    }
    
}
