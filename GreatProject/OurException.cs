using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class ZeroLenghtException:Exception
    {
       public ZeroLenghtException(string message): base( message)
        {

        }
    }

    class AgeException : Exception
    {
        public AgeException(string message) :base(message)
        {

        }
    }
}
