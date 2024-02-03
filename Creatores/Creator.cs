abstract class Creator {
    public string Name { get; private set; }
    public double Health { get; set; }
    public double DefaultHealth { get; set; }
    public double Damage { get; set; }
    public int Defense { get; private set; }

    public double AttackSpeed { get; set; }

    public Creator(string name, int health, int damage, int defense)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Defense = defense;
        AttackSpeed = 1;
        DefaultHealth = health;
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new creator has been created: {Name}");
        Thread.Sleep(500);
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nHealth: {Health}\nDamage: {Damage}\nDefense: {Defense}";
    }

    public virtual void Attack(Creator opponent)
    {
        var oldHealth = opponent.Health;
        opponent.Health -= Damage;
        var h = opponent.Health < 0 ? 0 : opponent.Health;
        // Get cursor position
        var x = Console.CursorLeft;
        var y = Console.CursorTop;

        Creator selectedHero = this;
        Creator opponentHero = opponent;

        if (opponent is Hero)
        {
            selectedHero = opponent;
            opponentHero = this;
        }

        var health_bar = $"{selectedHero.Name} [";
        var health_bar_length = (int) (selectedHero.Health / selectedHero.DefaultHealth * 20);

        for (int i = 0; i < health_bar_length; i++)
        {
            health_bar += "█";
        }
        for (int i = 0; i < 20 - health_bar_length; i++)
        {
            health_bar += " ";
        }
        health_bar += "]";

        var health_bar2 = "[";
        var health_bar2_length = (int) (opponentHero.Health / opponentHero.DefaultHealth * 20);

        for (int i = 0; i < health_bar2_length; i++)
        {
            health_bar2 += "█";
        }
        for (int i = 0; i < 20 - health_bar2_length; i++)
        {
            health_bar2 += " ";
        }
        health_bar2 += $"] {opponentHero.Name}";

        // Console.SetCursorPosition((Console.WindowWidth - 22 - selectedHero.Name.Length - 1 < 0) ? 0 : Console.WindowWidth - 22 - selectedHero.Name.Length - 1, 1);
        Console.WriteLine(health_bar);
        // Console.SetCursorPosition(0, 1);
        Console.WriteLine(health_bar2);
        // Console.SetCursorPosition(x, y);

        // Console.SetCursorPosition(0, ((Hero) selectedHero).BattleNumber + 3);
        Console.WriteLine($"{Name} attacks {opponent.Name}!");
        // Console.SetCursorPosition(x, y);
    }
}