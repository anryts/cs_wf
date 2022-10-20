using System.Collections.Generic;
using System.Linq;

namespace GreatProject;

internal delegate string inform_about_add(object ex);

internal class warehouse_for_materials : warehouse
{
    private int current_numbers_of_product;
    public List<Materials> list_of_materials;
    private int max_number_of_product;

    public warehouse_for_materials()
    {
        list_of_materials = new List<Materials>();
        Property_for_max_cout = 5;
    }


    public int Property_for_current_number
    {
        get => list_of_materials.Count;
        set => current_numbers_of_product = list_of_materials.Count();
    }

    public int Property_for_max_cout
    {
        get => max_number_of_product;
        set
        {
            if (value is int) max_number_of_product = value;
        }
    }

    public event inform_about_add out_of_max_count; //івент для керування к-сті об'єктів

    public void Add_to_list_materials(List<Materials> input_list)
    {
        foreach (var temp in input_list)
        {
            if (list_of_materials.Count < Property_for_max_cout) list_of_materials.Add(temp);
            break;
        }
    }
}

internal class warehouse_for_food : warehouse
{
    public List<Food> list_of_food;


    public warehouse_for_food()
    {
        list_of_food = new List<Food>();
        var temperatury_in_warehouse = 0;
    }

    public List<Food> List_of_food
    {
        set => Add_to_list_of_food(value);
        get => List_of_food;
    }

    public int Temperatury_in_warehouse { get; private set; }

    public void Add_to_list_of_food(List<Food> input_list)
    {
        foreach (var temp in input_list) list_of_food.Add(temp);
    }
}