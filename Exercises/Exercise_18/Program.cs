using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[10];
            Random random = new Random();
            

            for ( int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = random.Next(1, 100);
                Console.WriteLine(arrayInt[i]);

            }
            Console.WriteLine();
            double[] arrayDouble = new double[arrayInt.Length];

            for (int i = 0; i < arrayDouble.Length; i++)
            {
                arrayDouble[i] = 1.0 / (arrayInt[i]);
                
                Console.WriteLine(arrayDouble[i]);
            }

            Console.ReadLine();
            
           
        }
    }
}
