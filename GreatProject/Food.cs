using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Food : Item
    {
        private string expiration_date;
        public string Expiration_date
        {
            get { return expiration_date; }
            set { expiration_date = value; }
        }


        public Food( string name, int price,string expiration_date) : base( name, price)
        {
            Expiration_date = expiration_date;
        }

        public bool Fresh_or_not()
        {
            if(String.Compare(Expiration_date,DateTime.Today.ToString("d"))>=0) //01/10/2006
            {
                return true;
            }
            return false;
        }


        public override int price_of_item()
        {
            return 100;// *() тут треба дописать функцію ,яка буде розраховувати термін придатності у інт(чим більше це значення, тим буде менша сплата за зберігання).
        }

        public override string Print_Info()
        {
            return $"{price_of_item()}";
        }
    }
}
