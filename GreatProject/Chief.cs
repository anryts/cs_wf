using System.Collections.Generic;

namespace GreatProject;

internal class Chief : Person
{
    private static HashSet<string> all_items_in_warehouse = new();


    public Chief()
    {
        PaswordProperty = "";
    }

    public Queue<Food> PropertyQueueFood { get; } = new();

    public Stack<Materials> PropertyStackMaterials { get; } = new();

    public string PaswordProperty { get; set; }

    public void Add_to_Stack(List<Materials> some_list)
    {
        foreach (var item in some_list) PropertyStackMaterials.Push(item);
    }

    public void Add_to_Queue(List<Food> some_list)
    {
        foreach (var item in some_list) PropertyQueueFood.Enqueue(item);
    }
}