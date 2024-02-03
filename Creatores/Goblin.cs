class Goblin : Monster {
    public Goblin(string name)
    : base(name, 190, 5)
    {
        AttackSpeed = 2;
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new goblin has been created: {name}");
        Thread.Sleep(500);
    }
}