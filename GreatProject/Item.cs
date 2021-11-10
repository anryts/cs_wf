using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
   abstract class Item
    {
      
        //protected int price;
        protected string name;
        //public int Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}
       public virtual int price_of_item()
        {
            return 10;
        }
        
        public string Name
        {
            get { return name; }
            set {

              
                if (value.Length != 0)
                {
                    name = value;
                }
                else
                {
                    throw new ZeroLenghtException("Lenght can not = 0","unknow");
                }
                      
                
            }
        }

        public Item ()
        {
            //Price = 0;
            Name = "Unknown";
        }

        public Item ( string name)
        {
            //Price = price;
            Name = name;
        }

        public virtual string Print_Info()
        {
            return $"{Name},{price_of_item()}";
        }
    }
}
