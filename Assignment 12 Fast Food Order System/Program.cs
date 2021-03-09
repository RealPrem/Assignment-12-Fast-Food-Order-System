using System;
using System.IO;

namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {

            Item[] PL = new Item[100];
            Payment Order = new Payment();
            LoadFunction(PL);
            MainMenu(Order, PL);
            //AddFoodItem(Order,PL);
            //CalculateBill(Order, PL);


            /*
            Item[] PL = new Item[]
            {
                new Item("D1","Pepsi",100),
                new Item("D2","Coke",50),
                new Item("F1", "Pizza", 200),
                new Item("F2","Burger",150)
            };
            */


        }
        static public void MainMenu(Payment Order, Item[] PL)
        {
            int OptionNumber;
            string UserInput = "";

            while (UserInput != "Exit")
            {
                PrintMenu();
                Console.WriteLine("1 for AddFood");
                Console.WriteLine("2 for CalculateBill");
                UserInput = Console.ReadLine();

                if (int.TryParse(UserInput, out OptionNumber))
                {
                    if (OptionNumber == 1)
                    {
                        AddFoodItem(Order,PL);
                        Clear();
                    }
                    else if(OptionNumber == 2)
                    {
                        CalculateBill(Order,PL);
                        Clear();
                    }
                }
            }
        }
        static public void AddFoodItem(Payment Order, Item[] PL)
        {
            int intQuantity;
            Console.WriteLine("Enter ItemID");
            string ItemID = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            string Quantity = Console.ReadLine();
            while (int.TryParse(Quantity, out intQuantity) == false)
            {
                Console.WriteLine("Enter Quantity Agane");
                Quantity = Console.ReadLine();
            }
            for (int i = 0; i < PL.Length; i += 1)
            {
                if (PL[i] == null)
                {
                    break;
                }
                string Char = ItemID.Substring(0, 1);
                if (Char == "F")
                {
                    Order.AddFoodItem(new FoodItem(ItemID, intQuantity));
                    break;
                }
                else if (Char == "D")
                {
                    Order.AddDrinkItem(new DrinkItem(ItemID, intQuantity));
                    break;
                }
            }
        }
        static public void CalculateBill(Payment Order, Item[] PL)
        {
            Console.WriteLine(Order.CalculateBill(PL));
        }
        static public void PrintMenu()
        {
            int Count = 0;
            StreamReader FileReader = new StreamReader("food.csv");
            string Line = FileReader.ReadLine();
            Console.WriteLine(Line);
            while ((Line = FileReader.ReadLine()) != null)
            {
                string[] Cells = Line.Split(',');
                string Code = Cells[0];
                string Name = Cells[1];
                double Price = Convert.ToDouble(Cells[2]);

                Console.WriteLine("{0} {1} {2} {3}", Count, Code, Name, Price);
                Count += 1;
            }
            Console.WriteLine("---------------------------------------------------------");
        }
        static public void LoadFunction(Item[] PL)
        {
            int Count = 0;
            StreamReader FileReader = new StreamReader("food.csv");
            string Line = FileReader.ReadLine();
            while ((Line = FileReader.ReadLine()) != null)
            {
                string[] Cells = Line.Split(',');
                string Code = Cells[0];
                string Name = Cells[1];
                double Price = Convert.ToDouble(Cells[2]);

                PL[Count] = new Item(Code, Name, Price);
                Count += 1;
            }
        }
        static public void Clear()
        {
            int DelayTime = 2000;
            while (true)
            {
                Console.WriteLine("Press Enter to Clear");
                string Clear = Console.ReadLine();
                if (Clear == "" || Clear != "") // || is OR Statement"
                {
                    Console.WriteLine("CLEARING...");
                    System.Threading.Thread.Sleep(DelayTime);
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
