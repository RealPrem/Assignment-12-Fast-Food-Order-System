using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class FoodItem
    {
        private string ItemID;
        private int Quantity;

        public FoodItem(string ItemID, int Quantity)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
        }
        public string GetItemID()
        {
            return ItemID;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
