using System.Collections.Generic;

namespace GreatProject;

internal class Chief : Person
{
    private static HashSet<string> _allItemsInWarehouse = new();


    public Chief()
    {
        PasswordProperty = "";
    }

    public Queue<Food> PropertyQueueFood { get; } = new();

    public Stack<Materials> PropertyStackMaterials { get; } = new();

    public string PasswordProperty { get; set; }

    public void Add_to_Stack(List<Materials> someList)
    {
        foreach (var item in someList) PropertyStackMaterials.Push(item);
    }

    public void Add_to_Queue(List<Food> someList)
    {
        foreach (var item in someList) PropertyQueueFood.Enqueue(item);
    }
}