using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Materials : Item
    {
        private int capacity;                   //об'єм 
        private int weight;                     // вага

        public int Capacity
        {
            get { return capacity; }
            set {
                if (capacity > 0)
                {
                    capacity = value;
                }
                else
                {
                    throw new CapacityException("Capacity!<0", 0);
                }
            }
        }

       

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public double price_of_Materials()
        {
            if ((Convert.ToDouble(Capacity / Weight)) > 1)          //вартість об'єкту повинна розраховуватись від його густини, чим більша густина тим більша ціна, якось так)
            {
                return Capacity * Weight * 1.5;
            }
            else
                return Capacity * Weight * 2;
        }
    }
}
