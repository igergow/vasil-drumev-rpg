abstract class Creature {
    public string Name { get; private set; }
    public double Health { get; set; }
    public double DefaultHealth { get; set; }
    public double Damage { get; set; }
    public int Defense { get; private set; }

    public double AttackSpeed { get; set; }

    public Creature(string name, int health, int damage, int defense)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Defense = defense;
        AttackSpeed = 1;
        DefaultHealth = health;
        Tools.PrintBattleInfo($"A new creature has been created: {Name}");
        Thread.Sleep(2000);
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nHealth: {Health}\nDamage: {Damage}\nDefense: {Defense}";
    }

    public virtual void Attack(Creature opponent)
    {
        var oldHealth = opponent.Health;
        opponent.Health -= Damage;
        var h = opponent.Health < 0 ? 0 : opponent.Health;

        Creature selectedHero = this;
        Creature opponentHero = opponent;

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
        Tools.PrintTopLeftCorner("".PadRight(Console.WindowWidth - 1, ' '));

        Tools.PrintTopLeftCorner(health_bar);
        Tools.PrintTopRightCorner(health_bar2);

        Tools.PrintBattleInfo($"{selectedHero.Name} attacks {opponent.Name} ({h}/{oldHealth}) with {Damage} dmg!");
    }
}