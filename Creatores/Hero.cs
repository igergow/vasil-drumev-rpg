abstract class Hero : Creator
{
    public int BattleNumber { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int NextLevelExperience { get {
        return 1000 * Level;
    } }
    public Hero(string name, int health, int damage) 
        : base(name, health, damage, 0)
    {
        Level = 1;
        Experience = 0;
        // Console.SetCursorPosition(0, 3);
        Console.WriteLine($"A new hero has been created: {Name}");
        Thread.Sleep(500);
    }

    public override void Attack(Creator opponent)
    {
        Experience += (int) Damage;
        base.Attack(opponent);
    }

    public void ResetHealth()
    {
        Health = DefaultHealth;
    }

    public void LevelUp()
    {
        if (Experience >= NextLevelExperience)
        {
            ResetHealth();
            Experience = Experience - NextLevelExperience;
            Level++;
            Damage *= 1.1;
            Console.WriteLine($"{Name} has leveled up to {Level}!");
        } else {
            Console.WriteLine($"{Name} has {Experience}/{NextLevelExperience} experience!");
        }
    }
}