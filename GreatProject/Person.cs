﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class Person
    {
        private string name_of_person;
        private uint age_of_person;

        public uint Age_of_person
        {
            get { return age_of_person; }
            set { age_of_person = value; }
        }


        public string Name_of_person
        {
            get { return name_of_person; }
            set { name_of_person = value; }
        }

       public Person()
        {
            name_of_person = "unknown";
            age_of_person = 0;
        }
        Person (string name, uint age)
        {
            Name_of_person = name;
            Age_of_person = age;
        }

        public void Print()
        {
            Console.WriteLine($"Ім'я:{Name_of_person}\nВік:{Age_of_person}");
        }
    }
}