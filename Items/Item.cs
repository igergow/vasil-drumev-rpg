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

    public abstract void Use();
}