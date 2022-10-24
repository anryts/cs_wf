using System.Collections.Generic;
using System.Linq;

namespace GreatProject;

internal delegate string InformAboutAdd(object ex);

internal class warehouse_for_materials : Warehouse
{
    private int _currentNumbersOfProduct;
    public readonly List<Materials> list_of_materials;
    private int _maxNumberOfProduct;

    public warehouse_for_materials()
    {
        list_of_materials = new List<Materials>();
        PropertyForMaxCout = 5;
    }


    public int PropertyForCurrentNumber
    {
        get => list_of_materials.Count;
        set
        {
            _currentNumbersOfProduct = value;
            _currentNumbersOfProduct = list_of_materials.Count();
        }
    }

    public int PropertyForMaxCout
    {
        get => _maxNumberOfProduct;
        set { _maxNumberOfProduct = value; }
    }

    /// <summary>
    /// івент для керування к-сті об'єктів
    /// </summary>
    public event InformAboutAdd OutOfMaxCount; 

    public void Add_to_list_materials(List<Materials> inputList)
    {
        foreach (var temp in inputList)
        {
            if (list_of_materials.Count < PropertyForMaxCout) list_of_materials.Add(temp);
            break;
        }
    }
}

internal class WarehouseForFood : Warehouse
{
    public readonly List<Food> list_of_food;


    public WarehouseForFood()
    {
        list_of_food = new List<Food>();
        var temperaturyInWarehouse = 0;
    }

    public List<Food> ListOfFood
    {
        set => Add_to_list_of_food(value);
        get => ListOfFood;
    }

    public int TemperaturyInWarehouse { get; private set; }

    public void Add_to_list_of_food(List<Food> inputList)
    {
        foreach (var temp in inputList) list_of_food.Add(temp);
    }
}