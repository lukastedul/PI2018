using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_labos
{
    class Item
    {
        string Name { get; set; }
        float Price { get; set; }
        int Quantity { get; set; }

        public Item(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "; " + Price.ToString() + "kn " + Quantity.ToString() + "kom";
        }

    }
}
