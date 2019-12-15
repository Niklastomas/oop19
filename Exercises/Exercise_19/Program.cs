using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[6];
            coins[0] = 100;
            coins[1] = 50;
            coins[2] = 20;
            coins[3] = 10;
            coins[4] = 5;
            coins[5] = 1;

            int price = 0;
            int cash = 0;
            int change = 0;

            Console.Write("Enter price: ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine($"It costs {price}");
            Console.Write("How much cash do u want to hand over?: ");
            cash = int.Parse(Console.ReadLine());

            change = cash - price;
            Console.WriteLine($"The change is {change}");

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 0; j <= change; j++)
                {
                    if (coins[i] <= change)
                    {

                        Console.Write(coins[i] + "kr ");
                        change = change - coins[i];

                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();



            
        }
    }
}
