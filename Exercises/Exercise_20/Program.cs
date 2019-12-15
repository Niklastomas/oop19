using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Hur stor ska arrayen vara?");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] numbers = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 100);
                Console.WriteLine(numbers[i]);
                
            }
            Console.WriteLine();

            int [] numbers2 = new int[size];
            Array.Copy(numbers, 0, numbers2, 0, numbers.Length);

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            

            for( int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers2[i]);

                }
                if(numbers2[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers2[i]);
                }
            }
            evenNumbers.Sort();
            evenNumbers.Reverse();
            oddNumbers.Sort();
            
            foreach (var number in oddNumbers)
            {

                Console.Write(number + " ");

            }
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");

            }
               
            Console.ReadLine();



        }
    }
}
