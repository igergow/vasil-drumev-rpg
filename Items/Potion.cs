abstract class Potion : Item
{
    public Potion(string name, Dictionary<ItemAttributesEnum, Object> stats)
    : base(ItemTypeEnum.POTION, name, stats) {}
    public override void Use()
    {
        Tools.PrintBattleInfo($"You have used {Name} potion!");
        Thread.Sleep(5000);
    }
}