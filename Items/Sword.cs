
class Sword : Item
{
    public Sword(string name, Dictionary<ItemAttributesEnum, object> stats)
     : base(ItemTypeEnum.WEAPON, name, stats)
    {}

    public override void Use()
    {
        Tools.PrintBottomLeftCorner($"Using {Name} with stats {Attributes.ToString()}");
    }
}