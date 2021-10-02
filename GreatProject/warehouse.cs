using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class warehouse
    {
       private string name_of_warehouse;
       
   
        public string Name_of_warehouse
        {
            set
            {
                name_of_warehouse = value;   
            }
            get
            {
                return name_of_warehouse;      
            }
        }

        private int max_number_of_items;

        public int Max_number_of_items
        {
            get 
            { 
                return max_number_of_items; 
            }

            set 
            { 
                max_number_of_items = value; 
            }
        }

        private int current_number_of_items;

        public int Current_number_of_items
        {
            get 
            { 
                return current_number_of_items; 
            }
            set 
            {
                try
                {
                    if(value<=max_number_of_items)
                    current_number_of_items = value;
                }
                catch
                {
                    return;
                }
            }
        }


        public warehouse()
        {
            name_of_warehouse = "Unknown";
            max_number_of_items = 0;
            current_number_of_items = 0;
        }
        public warehouse(string name, int max_number, int current_number)
        {
            Name_of_warehouse = name;
            Max_number_of_items = max_number;
            Current_number_of_items = current_number; 
        }

        public void Print()
        {
            Console.WriteLine($"Назва складу: {name_of_warehouse}\nМаксильна к-сть виробів на складі: {max_number_of_items}\nПоточна к-сть виробів: {current_number_of_items}");
        }

    }
}
