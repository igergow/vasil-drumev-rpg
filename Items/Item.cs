abstract class Item {
    public ItemTypeEnum itemType { get; set;}
    public string Name { get; set; }
    public Dictionary<string, Object> Stats { get; set; }

    public Item(ItemTypeEnum itemType, string name, Dictionary<string, Object> stats)
    {
        this.itemType = itemType;
        this.Name = name;
        this.Stats = stats;
    }

    public abstract void Use();
}