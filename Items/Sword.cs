class Sword : Item
{
    public Sword(string name, Dictionary<ItemAttributesEnum, Object> stats) 
    : base(ItemTypeEnum.Weapon, name, stats)
    {
    }

    public override void Use()
    {
        Tools.PrintBottomLeftCorner($"You have used the sword {this.Name}");
    }
}