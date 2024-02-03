abstract class Monster : Creator
{
    public Monster(string name, int health, int damage) 
        : base(name, health, damage, 0)
    {
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new monster has been created: {Name}");
        Thread.Sleep(500);
    }

    public override string ToString()
    {
        return $"Monster {Name} has {Health} health and {Damage} damage";
    }
}