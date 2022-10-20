using System.Collections.Generic;

namespace GreatProject;

internal class CompareMaterials : IComparer<Materials>
{
    public int Compare(Materials p1, Materials p2)
    {
        if (p1.price_of_Materials() > p2.price_of_Materials())
            return 1;
        if (p1.price_of_Materials() < p2.price_of_Materials()) return -1;
        return 0;
    }
}

internal class CompareFood : IComparer<Food>
{
    public int Compare(Food p1, Food p2)
    {
        if (p1.price_of_item() > p2.price_of_item())
            return 1;
        if (p1.price_of_item() < p2.price_of_item()) return -1;
        return 0;
    }
}

internal class CompareFather : IComparer<Item>
{
    public int Compare(Item p1, Item p2)
    {
        if (p1.price_of_item() > p2.price_of_item())
            return 1;
        if (p1.price_of_item() < p2.price_of_item()) return -1;
        return 0;
    }
}
