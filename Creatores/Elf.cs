class Elf : Hero {
    public Elf(string name)
    : base(name, 600, 15)
    {
        AttackSpeed = 1.2;
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new elf has been created: {Name}");
        Thread.Sleep(500);
    }
}