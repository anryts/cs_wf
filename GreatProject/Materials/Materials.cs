using System;

namespace GreatProject;

[Serializable]
public class Materials : Item, IPrintable
{
    private int _capacity; //об'єм 
    private int _weight; // вага


    public Materials()
    {
    }


    public Materials(string name, int capacity, int weight)
    {
        Name = name;
        Capacity = capacity;
        Weight = weight;
    }


    public int Capacity
    {
        get => _capacity;
        set
        {
            if (value > 0)
                _capacity = value;
            else
                throw new CapacityException("Capacity!<0", this);
        }
    }

    public int Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public string GetData()
    {
        return $"Materials Name:{Name} Capacity:{Capacity}  Weight:{Weight} ";
    }

    /// <summary>
    /// порівняння об'єктів за ціною
    /// </summary>
    /// <param name="ex"></param>
    /// <returns> якщо об'єкт у якого був визваний цей метод, більший вертажться true
    /// </returns>
    public bool CompareTo(Materials ex)
    {
        if (price_of_Materials() > ex.price_of_Materials())
            return true;
        return false;
    }
    
    public double price_of_Materials()
    {
        if (Convert.ToDouble(Capacity / Weight) > 1)
            return Capacity * Weight * 1.5;
        return Capacity * Weight * 2;
    }


    public override string Print_Info()
    {
        return $"Name:{Name} Capacity:{Capacity}  Weight:{Weight} ";
        
    }
}