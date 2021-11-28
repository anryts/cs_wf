using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{

     class warehouse_for_food : warehouse
    {

        public List<Food> list_of_food;

        public void Add_to_list_of_food(List<Food> input_list)
        {
            foreach(Food temp in input_list)
            {
                this.list_of_food.Add(temp);
            }
        }
        public List<Food> List_of_food
        {
            set { this.Add_to_list_of_food(value); }                  
            get { return List_of_food; }
        }


        int temperatury_in_warehouse;

        public int Temperatury_in_warehouse
        {
            get { return temperatury_in_warehouse; }
            private set { temperatury_in_warehouse = value; }
        }

        public warehouse_for_food()
        {
            list_of_food = new();
            int temperatury_in_warehouse = 0;

        }
    }
}
