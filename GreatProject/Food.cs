using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Food : Item
    {
        private DateTime expiration_date;
        public DateTime Expiration_date
        {
            get { return expiration_date; }
            set { expiration_date = value; }
        }

        public Food() : base()
        {
            
        }
        public Food( string name, int price,DateTime expiration_date) : base( name, price)
        {
            Expiration_date = expiration_date;
        }

        public bool Fresh_or_not()
        {
            if((Expiration_date.Equals(DateTime.Today))) //01/10/2006
            {
                return true;
            }
            return false;
        }


        public override int price_of_item()
        {
           TimeSpan result =  (Expiration_date-DateTime.Today);
            return 100*result.Days;
        }

        public override string Print_Info()
        {
            return $"Price:{price_of_item()}\nName:{Name}\nExperation Date:{String.Format("{0:MM/dd/yyyy}", Expiration_date)}";
        }
    }
}
