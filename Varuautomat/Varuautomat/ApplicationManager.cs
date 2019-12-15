using System;
using System.Collections.Generic;
using System.IO;

namespace Varuautomat
{
    class ApplicationManager
    {
        Dictionary<int, Item> BeverageItem = new Dictionary<int, Item>();
        Dictionary<int, Item> SnacksItem = new Dictionary<int, Item>();
        Dictionary<int, Item> FoodItem = new Dictionary<int, Item>();
        List<Item> Receipt = new List<Item>();

      


        public void VendingMachine()
        {
            StartDictionaryBev(BeverageItem);
            StartDictionaryFood(FoodItem);
            StartDictionarySnack(SnacksItem);

            while (true)
            {
                DisplayMainMenu();
               
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                if (input == 1)
                {
                    BuyItems();
                }
                if (input == 2)
                {
                    bool login = Login();

                    if (login)
                    {
                        AddItems();
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input == 3)
                {
                    break;
                }
            }
        }
        public void DisplayMainMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("|     Menu      |");
            Console.WriteLine("| 1 - Buy items |");
            Console.WriteLine("| 2 - Add items |");
            Console.WriteLine("| 3 - Exit      |");
            Console.WriteLine("-----------------");
        }

        public void AddItems()
        {

            int indexFood = 5;
            int indexBevarage = 5;
            int indexSnack = 5;
            while (true)
            {

                Console.WriteLine("1 - Add item \n2 - Main menu");
                int exit = int.Parse(Console.ReadLine());
                Console.Clear();

                if (exit == 2)
                {
                    break;
                }

                Console.Write("Enter product name: ");
                string product = Console.ReadLine();
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter type (Beverage, Snack or Food: ");
                string type = Console.ReadLine();
                type = type.ToLower();
                bool stock = true;


                if (type == "beverage")
                {
                    Beverage bevarage = new Beverage(product, price, type, stock);
                    BeverageItem.Add(indexBevarage, bevarage);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Item added");
                    Console.ResetColor();
                    indexBevarage++;
                    Console.ReadLine();
                    Console.Clear();

                }
                if (type == "snack")
                {
                    Snacks snack = new Snacks(product, price, type, stock);
                    SnacksItem.Add(indexSnack, snack);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Item added");
                    Console.ResetColor();
                    indexSnack++;
                    Console.ReadLine();
                    Console.Clear();

                }

                if (type == "food")
                {
                    Food food = new Food(product, price, type, stock);
                    FoodItem.Add(indexFood, food);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Item added");
                    Console.ResetColor();
                    indexFood++;
                    Console.ReadLine();
                    Console.Clear();


                }

            }

        }
        public void PrintList(Dictionary<int, Item> items)
        {
            foreach (KeyValuePair<int, Item> kvp in items)
            {
                Console.WriteLine($"Index: {kvp.Key} \t Product: {kvp.Value.ProductName} \t Price: {kvp.Value.Price}");
            }

        }


        public void BuyItems()
        {
            Console.Write("1 - Bevarage:\n2 - Snack:\n3 - Food:\nEnter type:  ");
            int input = int.Parse(Console.ReadLine());


            switch (input)
            {
                
                case 1:
                    
                    BuyInfo(BeverageItem);

                    break;

                case 2:
                    BuyInfo(SnacksItem);
                    break;

                case 3:
                    BuyInfo(FoodItem);
                    break;

            }

        }
        public double BuyInfo(Dictionary<int, Item> dictionary)
        {
            int number = 0;
            bool didTheItemExist = false;
            double sum = 0;

            while (true)
            {

                PrintList(dictionary);
                Console.WriteLine("Press 9 to go back");
                Console.Write("Too buy, enter a number : ");
                number = int.Parse(Console.ReadLine());
                if (number == 9)
                {
                    break;
                }
                if (dictionary.ContainsKey(number))
                {
                    Item food;
                    didTheItemExist = dictionary.TryGetValue(number, out food);
                    Console.WriteLine($"Product: {food.ProductName}\tPrice: {food.Price}");
                    sum += food.Price;
                    Receipt.Add(food);

                    dictionary.Remove(number);

                }

                if (didTheItemExist == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Item did not exist!");
                    Console.WriteLine();
                    Console.ResetColor();
                }

                Console.WriteLine("Press 1 to continue shopping or 2 to pay");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (number == 1)
                {
                    Console.Clear();
                    continue;
                    
                }
                if (number == 2)
                {

                    Console.WriteLine("The items you have choosen: ");
                    Console.WriteLine();
                    foreach (var item in Receipt)
                    {
                        Console.WriteLine($"Product: {item.ProductName}\t Price: {item.Price}");
                    }


                    Console.WriteLine($"The total cost: {sum}");
                    Payment(sum);
                    break;
                }

            }
            return sum;

        }
        public void Payment(double sum)
        {
            int cash = 0;
            double change = 0;

            int[] coins = new int[7];
            coins[0] = 200;
            coins[1] = 100;
            coins[2] = 50;
            coins[3] = 20;
            coins[4] = 10;
            coins[5] = 5;
            coins[6] = 1;

            while (true)
            {
                Console.Write("Insert money please (1, 5, 10, 20, 50, 100, 200): ");
                cash = int.Parse(Console.ReadLine());
                change = cash - sum;
                if (cash >= sum)
                {
                    if (cash == 1 || cash == 5 || cash == 10 || cash == 20 || cash == 50 || cash == 100 || cash == 200)
                    {
                        break;
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid amount");
                        Console.ResetColor();
                        continue;
                    }
                }
                
                else
                {
                    Console.WriteLine("Input more money!");
                    continue;
                }
            }
            Console.Write("The change is: ");
      
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= change;)
                {
                    Console.Write(coins[i] + "kr ");
                    change = change - coins[i];
                }
            }
            WriteReceipt(Receipt, cash);         
            ReadReceipt();
            Receipt.Clear();
            Console.ReadLine();
            Console.Clear();

        }
        public static void WriteReceipt(List<Item> list, int insertedMoney)
        {

            string fileName = "MyReceipt.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            double sum = 0;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, fileName)))
            {
                foreach (var item in list)
                {
                    outputFile.WriteLine($"Product: {item.ProductName}\tPrice: {item.Price}kr");
                    sum += item.Price;
                }
                outputFile.WriteLine($"Money inserted: {insertedMoney}kr");
                outputFile.WriteLine($"Change: {insertedMoney - sum}kr");
            }
            Console.WriteLine("\nReceipt saved in the file: {0} located on your Desktop", fileName);
            Console.ReadLine();

        }
        public static void ReadReceipt()
        {
            string fileName = "MyReceipt.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Receipt");
            Console.WriteLine("--------");
            using (StreamReader readFile = new StreamReader(Path.Combine(path, fileName)))
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ResetColor();

        }
        public void StartDictionaryBev(Dictionary<int, Item> dictionary)
        {

            Beverage bevarage = new Beverage("CocaCola", 10, "Bevarage", true);
            Beverage bevarage2 = new Beverage("Fanta", 10, "Bevarage", true);
            Beverage bevarage3 = new Beverage("Sprite", 10, "Bevarage", true);
            Beverage bevarage4 = new Beverage("RedBull", 20, "Bevarage", true);

            dictionary.Add(1, bevarage4);
            dictionary.Add(2, bevarage3);
            dictionary.Add(3, bevarage2);
            dictionary.Add(4, bevarage);
        }
        public void StartDictionaryFood(Dictionary<int, Item> dictionary)
        {
            Food Food = new Food("Banana", 15, "food", true);
            Food Food2 = new Food("Yoghurt", 30, "food", true);
            Food Food3 = new Food("Apple", 15, "food", true);
            Food Food4 = new Food("Sandwich", 25, "food", true);

            dictionary.Add(1, Food);
            dictionary.Add(2, Food2);
            dictionary.Add(3, Food3);
            dictionary.Add(4, Food4);
        }
        public void StartDictionarySnack(Dictionary<int, Item> dictionary)
        {
            Snacks snack = new Snacks("Snickers", 10, "snack", true);
            Snacks snack2 = new Snacks("Marabou", 10, "snack", true);
            Snacks snack3 = new Snacks("Bounty", 10, "snack", true);
            Snacks snack4 = new Snacks("Chips", 20, "snack", true);

            dictionary.Add(1, snack);
            dictionary.Add(2, snack2);
            dictionary.Add(3, snack3);
            dictionary.Add(4, snack4);
        }
        public  bool Login()
        {
            int count = 1;
            bool login = false;

            while (count <= 3)
            {

                string userName;
                string password;
                
                Console.WriteLine("Enter username: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();

                if (userName == "admin" && password == "1234")
                {
                    login = true;
                    return login;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Username or password is wrong");
                    Console.ResetColor();
                    Console.WriteLine($"{count} of 3 tries!");
                    Console.WriteLine();
                    login = false;
                    count++;
                    
                }               
                
            }
            return login;
        }



    }
}

