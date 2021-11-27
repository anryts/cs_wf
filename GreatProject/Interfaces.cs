using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    interface IPrintable
    {
        string Print(object some_thing);

    }

    interface IWritable
    {

    }

    class Item_ShowOnly_Name : IPrintable                   //приклад
    {
        public string Print(object some_thing)
        {
            Item item = some_thing as Item;
            return $"{item.Name}";
        }
    }
}
