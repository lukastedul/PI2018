using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_labos
{
    class BillItem : Item
    {
        public BillItem(string name, float price, int quantity) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "; " + Price.ToString() + "kn " + Quantity.ToString() + "kom";
        }

        public string Ispis()
        {
            return "";
        }
    }
}
