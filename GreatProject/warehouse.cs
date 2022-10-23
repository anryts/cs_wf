using System;

namespace GreatProject;

internal class Warehouse
{
    private int _currentNumberOfItems;


    protected Warehouse()
    {
        NameOfWarehouse = "Unknown";
        MaxNumberOfItems = 0;
        _currentNumberOfItems = 0;
    }

    public Warehouse(string name, int maxNumber)
    {
        NameOfWarehouse = name;
        MaxNumberOfItems = maxNumber;
    }

    public string NameOfWarehouse { set; get; }

    public int MaxNumberOfItems { get; set; }

    public WarehouseForFood WarehouseForFood
    {
        set => WarehouseForFood = value;
    }

    public int CurrentNumberOfItems
    {
        get => _currentNumberOfItems;
        set
        {
            try
            {
                if (value <= MaxNumberOfItems)
                    _currentNumberOfItems = value;
            }
            catch
            {
            }
        }
    }


    public void Print()
    {
        Console.WriteLine(
            $"Назва складу: {NameOfWarehouse}\nМаксильна к-сть виробів на складі: {MaxNumberOfItems}\nПоточна к-сть виробів: {_currentNumberOfItems}");
    }
}