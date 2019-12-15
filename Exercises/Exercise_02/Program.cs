using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = getToday();
            DateTime tomorrow = getTomorrow();
            DateTime yesterday = GetYesterday();
            DateTime.Now.AddDays(0);



            Console.WriteLine("Todays date is {0}", today);
            Console.WriteLine("Tomorrows date is {0}", tomorrow);
            Console.WriteLine("Yesterdays date was {0}", yesterday);
            Console.ReadLine();


        }
        static DateTime GetYesterday()
        {

            return DateTime.Now.AddDays(-1);
        }
        static DateTime getToday()
        {
            return DateTime.Now.AddDays(0);

        }
        static DateTime getTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
    

