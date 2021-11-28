using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Food : Item, IPrintable
    {
        private DateTime expiration_date;
       public DateTime Expiration_date
        {
            get { return expiration_date; }
            set
            {
                 if (Fresh_or_not(value))
                    {
                        expiration_date = value;
                    }
                    else
                    {
                        throw new ExpirationDateException("Invalid expiration date!",this);
                    }             
            }
        }

        public Food() : base()
        {
            
        }
        public Food( string name,DateTime expiration_date) : base( name)
        {
            Expiration_date = expiration_date;
        }

        static public bool Fresh_or_not(DateTime value)
        {
            if(value.CompareTo(DateTime.Now)>=0) 
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

        string IPrintable.GetData()
        {
            return $"Food {price_of_item()} {Name} {String.Format("{0:MM/dd/yyyy}", Expiration_date)}";
        }
    }
}
