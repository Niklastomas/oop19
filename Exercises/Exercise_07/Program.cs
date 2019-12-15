using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double Volume(double radius)
        {
            return (4 * Math.PI * radius * radius * radius) / 3;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = int.Parse(Console.ReadLine());
            

            Console.WriteLine("The area of the circel are: " + Math.Round(Area(radius), 2));
            Console.WriteLine("The volume of the circel are: " + Math.Round(Volume(radius), 2));
            Console.ReadLine();
        }
    }
}
