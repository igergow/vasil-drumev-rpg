class Human : Hero{
    public Human(string name)
    : base(name, 100, 10)
    {
        Tools.PrintBattleInfo($"A new human has been created: {Name}");
        Thread.Sleep(2000);
    }

    public void SpecialAttack(Creature opponent)
    {
        var oldHealth = opponent.Health;
        opponent.Health -= Damage;
        Tools.PrintBattleInfo($"{Name} uses special attacks against {opponent.Name} ({opponent.Health}/{oldHealth}) with {Damage} dmg!");
    }
}