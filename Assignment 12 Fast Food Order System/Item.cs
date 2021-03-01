using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Item
    {
        private string ItemID;
        private string Name;
        private double Price;

        public Item(string ItemID, string Name, double Price)
        {
            this.ItemID = ItemID;
            this.Name = Name;
            this.Price = Price;
        }
        public string GetItemID()
        {
            return ItemID;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
        
    }
}
