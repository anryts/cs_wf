using System;

namespace GreatProject;

[Serializable]
internal class Food : Item, IPrintable
{
    private DateTime _expirationDate;

    public Food()
    {
    }

    public Food(string name, DateTime expirationDate) : base(name)
    {
        ExpirationDate = expirationDate;
    }


    public DateTime ExpirationDate
    {
        get => _expirationDate;
        set
        {
            if (Fresh_or_not(value))
                _expirationDate = value;
            else
                throw new ExpirationDateException("Invalid expiration date!", this);
        }
    }

    string IPrintable.GetData()
    {
        return $"Food {price_of_item()} {Name} {string.Format("{0:MM/dd/yyyy}", ExpirationDate)}";
    }

    public static bool Fresh_or_not(DateTime value)
    {
        if (value.CompareTo(DateTime.Now) >= 0) return true;
        return false;
    }


    public override int price_of_item()
    {
        var result = ExpirationDate - DateTime.Today;
        return 100 * result.Days;
    }

    public override string Print_Info()
    {
        return
            $"Price:{price_of_item()}\nName:{Name}\nExperation Date:{string.Format("{0:MM/dd/yyyy}", ExpirationDate)}";
    }
}