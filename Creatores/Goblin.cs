class Goblin : Monster {
    public Goblin(string name)
    : base(name, 190, 5)
    {
        AttackSpeed = 2;
        Tools.PrintBattleInfo($"A new goblin has been created: {Name}");
        Thread.Sleep(500);
    }
}