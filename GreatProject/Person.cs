using System;

namespace GreatProject;

internal class Person
{
    private readonly string _idPerson;

    private readonly Random _rd = new();
    private string _nameOfPerson;

    protected Person()
    {
        _nameOfPerson = "unknown";
        _idPerson = Convert.ToString(_rd.Next(100000, 999999));
    }

    private Person(string name)
    {
        NameOfPerson = name;
        _idPerson = Convert.ToString(_rd.Next(100000, 999999));
    }

    public string NameOfPerson
    {
        get => _nameOfPerson;
        set
        {
            if (value.Length != 0)
            {
                _nameOfPerson = value;
            }
            //throw new ZeroLenghtException("Lenght can not = 0", this);
        }
    }

    public virtual void Print()
    {
        Console.WriteLine($"Ім'я:{NameOfPerson}\n" +
                          $"ID:{_idPerson}");
    }
}