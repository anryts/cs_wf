using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Chief : Person
    {

        private string pasword;


        private Queue<Food> queue_for_food = new();
        private Stack<Materials> stack_for_materials = new();

        public Queue<Food> PropertyQueueFood
        {
            get { return queue_for_food; }
            
        }

        public Stack<Materials> PropertyStackMaterials
        {
            get { return stack_for_materials; }
            
        }
        static HashSet<string> all_items_in_warehouse = new();
       public void Add_to_Stack (List<Materials> some_list)
        {
            foreach (Materials item in some_list)
            {
                this.PropertyStackMaterials.Push(item);


            }
        }

      public  void Add_to_Queue (List <Food> some_list)
        {
            foreach (Food item in some_list)
            {
                this.PropertyQueueFood.Enqueue(item);
               
            }
        }

        public string PaswordProperty
        {
            get { return pasword; }
            set { pasword = value; }
        }
       

        public Chief() : base()
        {
            PaswordProperty = "";
        }
    }
}
