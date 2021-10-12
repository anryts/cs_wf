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

        public override void Print()
        {
            base.Print();
        }
    }
}
