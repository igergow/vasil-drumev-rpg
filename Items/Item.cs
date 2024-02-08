public abstract class Item 
{
    public ItemTypeEnum itemTypeEnum { get; set; }
    public string Name { get; set; }
    public Dictionary<ItemAttributesEnum, Object> Attributes { get; set; }

    public Item(ItemTypeEnum type, string name, Dictionary<ItemAttributesEnum, Object> stats)
    {
        itemTypeEnum = type;
        Name = name;
        Attributes = stats;        
    }

    public override string ToString()
    {
        string result = "";
        result += $"Item: {Name} ({itemTypeEnum}) ";
        foreach (var attr in Attributes)
        {
            result += $" {attr.Key}: {attr.Value} ";
        }
        return result;
    }

    public abstract void Use();
}