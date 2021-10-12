using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
   abstract class Item
    {
      
        protected int price;
        protected string name;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
       

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

        public virtual void Print()
        {
            Console.WriteLine($"Назва товару:{Name}\nЦіна товару:{Price}");
        }
    }
}
