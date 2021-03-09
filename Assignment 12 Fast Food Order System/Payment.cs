using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Payment
    {
        private FoodItem[] FI = new FoodItem[100];
        private DrinkItem[] DI = new DrinkItem[100];
        private int FICount;
        private int DICount;

        public Payment()
        {
            FICount = 0;
            DICount = 0;
        }
        public void AddFoodItem(FoodItem Food)
        {
            FI[FICount] = Food;
            FICount += 1;
        }
        public void AddDrinkItem(DrinkItem Drink)
        {
            DI[DICount] = Drink;
            DICount += 1;
        }
        public FoodItem GetFood(int i)
        {
            return FI[i];
        }
        public DrinkItem GetDrink(int i)
        {
            return DI[i];
        }
        public double FindPrice(Item[] PL, string ItemID)
        {
            double Price = 0;
            for (int i = 0; i < PL.Length; i += 1)
            {
                if (PL[i] == null)
                {
                    break;
                }
                if (PL[i].GetItemID() == ItemID)
                {
                    Price = PL[i].GetPrice();
                }
            }
            return Price;
        }
        public double CalculateBill(Item[] PL)
        {
            double Total = 0;
            for (int i = 0; i < FICount; i += 1)
            {
                string ItemID = FI[i].GetItemID();
                int Quantity = FI[i].GetQuantity();
                double Price = FindPrice(PL, ItemID);
                Total = Total + (Price * Quantity);
            }
            for (int i = 0; i < DICount; i += 1)
            {
                string ItemID = DI[i].GetItemID();
                int Quantity = DI[i].GetQuantity();
                double Price = FindPrice(PL, ItemID);
                Total = Total + (Price * Quantity);
            }
            return Total;
        }
    }
}
