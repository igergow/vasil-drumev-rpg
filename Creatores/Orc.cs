class Orc : Monster {
    public Orc(string name)
    : base(name, 100, 10)
    {
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new ork has been created: {name}");
        Thread.Sleep(500);
    }
}