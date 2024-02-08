class Orc : Monster {
    public Orc(string name)
    : base(name, 100, 10)
    {
        Tools.PrintTopRightCorner($"A new orc has been created: {name}");
        Thread.Sleep(2000);
    }
}