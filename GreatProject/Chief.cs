using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Chief : Person
    {

       public void copying_to_Chief(Chief some_other)
        {
            this.name_of_person = some_other.name_of_person;
        }
       
      public Chief() : base()
        {
            //метод видалення об'єкта.
            void kill_method(List<Item> some_list)
            {
                some_list[some_list.Count - 1] = null;
            }
        }
    }
}
