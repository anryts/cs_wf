using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Item
    {
        
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Item ()
        {
            Price = 0;
            Name = "Unknown";
        }

        public Item ( string name,int price)
        {
            Price = price;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($"Назва товару:{Name}\nЦіна товару:{Price}");
        }
    }
}
