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
        public List<Food> List_of_food
        {
            //set { List_of_food += value; }                  //нада дописать перегрузку оператора +=
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
            this.list_of_food = new();
            int temperatury_in_warehouse = 0;
        }
       
    }



}
