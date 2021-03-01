using System;

namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] PL = new Item[]
            {
                new Item("D1","Pepsi",100),
                new Item("D2","Coke",50),
                new Item("F1", "Pizza", 200),
                new Item("F2","Burger",150)
            };
            Payment Order = new Payment();
        }
        static public void MainMenu(Payment Order, Item[] PL)
        {
            int OptionNumber;
            string UserInput = "";

            while (UserInput != "Exit")
            {
                Console.WriteLine("1 for AddFood");
                Console.WriteLine("2 for CalculateBill");

                if (int.TryParse(UserInput, out OptionNumber))
                {
                    if (OptionNumber == 1)
                    {
                        AddFoodItem(Order);
                    }
                    else if(OptionNumber == 2)
                    {
                        CalculateBill(Order,PL);
                    }
                }
            }
        }
        static public void AddFoodItem(Payment Order)
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
            Order.AddFoodItem(new FoodItem(ItemID, intQuantity));
        }
        static public void CalculateBill(Payment Order, Item[] PL)
        {
            Console.WriteLine(Order.CalculateBill(PL));
        }
    }
}
