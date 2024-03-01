class Dwarf : Hero{
    public Dwarf(string name)
    : base(name, 100, 10)
    {
        Skills.Add(new TouchOfAngel());
        Tools.PrintBattleInfo($"A new dwarf has been created: {Name}");
        Thread.Sleep(500);
    }

    public void SpecialAttack(Creature opponent)
    {
        var oldHealth = opponent.Health;
        opponent.Health -= Damage;
        Tools.PrintBattleInfo($"{Name} uses special attacks against {opponent.Name} ({opponent.Health}/{oldHealth}) with {Damage} dmg!");
    }
}