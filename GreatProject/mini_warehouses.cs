using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{

    class warehouse_for_materials : warehouse
    {
        public List<Materials> list_of_materials;
        int current_numbers_of_product;
        int max_number_of_product;

        public event EventHandler out_of_max_count;                     //івент для керування к-сті об'єктів

        public int Property_for_current_number { get { return current_numbers_of_product; } set { current_numbers_of_product = list_of_materials.Count(); } }

        public int Property_for_max_cout
            {
                get {return max_number_of_product;}
                set { if(value is int)max_number_of_product = value; }
            }
        public void Add_to_list_of_food(List<Materials> input_list)
        {
            foreach (Materials temp in input_list)
            {
                if (list_of_materials.Count < this.Max_number_of_items)
                {
                    this.list_of_materials.Add(temp);
                }
                else
                {
                    if(out_of_max_count !=null)
                    {
                        out_of_max_count(this, null);
                    }
                }
            }
        }

        public warehouse_for_materials()
        {
            list_of_materials = new();
            Property_for_max_cout = 5;
        }
    }
    
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
