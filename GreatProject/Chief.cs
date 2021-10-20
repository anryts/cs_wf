using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Chief : Person
    {

        class Worker : Person
        {
            static List<Worker> list_of_workers = new List<Worker>();
            static int ammount_of_workers = 0;
            public Worker()
            {
                ammount_of_workers++;
            }

            

        }

        //public int get_ammount_of_workers()
        //{
        //    return Worker.
        //}
      public Chief() : base()
        {

        }
    }
}
