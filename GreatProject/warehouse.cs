using System;

namespace GreatProject;

internal class warehouse
{
    private int current_number_of_items;


    public warehouse()
    {
        Name_of_warehouse = "Unknown";
        Max_number_of_items = 0;
        current_number_of_items = 0;
    }

    public warehouse(string name, int max_number)
    {
        Name_of_warehouse = name;
        Max_number_of_items = max_number;
        var wrhs_for_food = new warehouse_for_food();
    }

    public string Name_of_warehouse { set; get; }

    public int Max_number_of_items { get; set; }

    public warehouse_for_food Warehouse_for_food
    {
        set => Warehouse_for_food = value;
    }

    public int Current_number_of_items
    {
        get => current_number_of_items;
        set
        {
            try
            {
                if (value <= Max_number_of_items)
                    current_number_of_items = value;
            }
            catch
            {
            }
        }
    }


    public void Print()
    {
        Console.WriteLine(
            $"Назва складу: {Name_of_warehouse}\nМаксильна к-сть виробів на складі: {Max_number_of_items}\nПоточна к-сть виробів: {current_number_of_items}");
    }
}