abstract class Monster : Creator
{
    public Monster(string name, int health, int damage) 
        : base(name, health, damage, 0)
    {
        Tools.PrintBattleInfo($"A new monster has been created: {Name}");
        Thread.Sleep(500);
    }

    public override string ToString()
    {
        return $"Monster {Name} has {Health} health and {Damage} damage";
    }
}