using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    [Serializable]
    class Materials : Item, IPrintable
    {
        private int capacity;                           //об'єм 
        private int weight;                            // вага
        string type_of_materials;                  


        public int Capacity
        {
            get { return capacity; }
            set {
                if (value > 0)
                {
                    capacity = value;
                }
                else
                {
                    throw new CapacityException("Capacity!<0", this);
                }
            }
        }
        public string Type_of_materials
        {
            get { return type_of_materials; }
            set { type_of_materials = value; }
        }
       

        public Materials() :base()
        {

        }


        public Materials(string name, int capacity, int weight)
        {
            Name = name;
            Capacity = capacity;
            Weight = weight;
            
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


       


        public int CompareTo(Materials ex)                  //порівнюю за ціною
        {
            if (this.price_of_item()>ex.price_of_item())
            {
                return 1;
            }
            else if(this.price_of_item() < ex.price_of_item())
            {
                return -1;
            }
            return 0;
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

        public override string Print_Info()
        {
            return $"Name:{Name} Capacity:{Capacity}  Weight:{Weight} Type:{Type_of_materials}";
        }

        string IPrintable.GetData()
        {
            return $"Materials Name:{Name} Capacity:{Capacity}  Weight:{Weight} Type:{Type_of_materials}";
        }
    }
}
