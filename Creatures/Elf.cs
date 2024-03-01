class Elf : Hero {
    public Elf(string name)
    : base(name, 600, 15)
    {
        Skills.Add(new Fireball());
        AttackSpeed = 1.2;
        Tools.PrintBattleInfo($"A new elf has been created: {Name}");
        Thread.Sleep(500);
    }
}