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
            set
            {
                foreach (var item in value)
                {
                    queue_for_food.Enqueue(item);
                }
            }
        }

        public Stack<Materials> PropertyStackMaterials
        {
            get { return stack_for_materials; }
            set
            {
                foreach (var item in value)
                {
                    stack_for_materials.Push(item);
                }
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
