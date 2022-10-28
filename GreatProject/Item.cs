using System;

namespace GreatProject;

[Serializable]
public abstract class Item
{
    //protected int price;
    protected string name;

    protected Item()
    {
        //Price = 0;
        Name = "Unknown";
    }

    protected Item(string name)
    {
        //Price = price;
        Name = name;
    }

    public string Name
    {
        get => name;
        set
        {
            if (value.Length != 0)
                name = value;
            else
                throw new ZeroLenghtException("Lenght can not = 0", this);
        }
    }

    //public int Price
    //{
    //    get { return price; }
    //    set { price = value; }
    //}
    public virtual int price_of_item()
    {
        return 10;
    }

    public virtual string Print_Info()
    {
        return $"{Name},{price_of_item()}";
    }
}