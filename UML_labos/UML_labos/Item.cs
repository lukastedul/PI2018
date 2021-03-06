﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_labos
{
    class Item
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

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
