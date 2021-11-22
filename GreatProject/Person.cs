using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    abstract class Person
    {
        protected string name_of_person;

        readonly string id_person;

        Random rd = new();

        public string Name_of_person
        {
            get { return name_of_person; }
            set {

                if (value.Length != 0)
                {
                    name_of_person = value;
                }
                else
                {
                    throw new ZeroLenghtException("Lenght can not = 0","unknown");
                }
            }
        }

       public Person()
        {
            name_of_person = "unknown";
           
        }
        Person (string name, string id_person)
        {
            Name_of_person = name;
            id_person = Convert.ToString(rd.Next(100000,999999));
        }

        public virtual void Print()
        {
            Console.WriteLine($"Ім'я:{Name_of_person}\nID:{id_person}");
        }
    }
}
