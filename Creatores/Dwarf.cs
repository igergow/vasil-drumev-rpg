class Dwarf : Hero{
    public Dwarf(string name)
    : base(name, 100, 10)
    {
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new dwarf has been created: {Name}");
        Thread.Sleep(500);
    }

    public void SpecialAttack(Creator opponent)
    {
        var oldHealth = opponent.Health;
        opponent.Health -= Damage;
        Console.WriteLine($"{Name} uses special attacks against {opponent.Name} ({opponent.Health}/{oldHealth}) with {Damage} dmg!");
    }
}