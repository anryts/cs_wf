using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class ZeroLenghtException:Exception
    {

	   public string Value
        {
            get;
        }

       public ZeroLenghtException(string message,string value): base( message)
        {
            Value = value;
        }

        public ZeroLenghtException(string message, Exception InnerException, string value): base(message,InnerException)
        {
            Value  = value;
        }
    }

    class ExpirationDateException : Exception
    {
        /*
         Треба ще переробити поле ExpirationDate.
         */
    }

    class AgeException : Exception
    {
        public AgeException(string message) :base(message)
        {

        }

    public AgeException (string message, Exception InnerException) :base(message, InnerException)
        {

        }
    }
}
