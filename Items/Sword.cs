class Sword : Item
{
    public Sword(string name, Dictionary<string, Object> stats) 
    : base(ItemTypeEnum.Weapon, name, stats)
    {
    }

    public override void Use()
    {
        Console.WriteLine($"You have used the sword {this.Name}");
    }
}