abstract class Hero : Creature
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
        Tools.PrintBattleInfo($"A new hero has been created: {Name}");
        Thread.Sleep(2000);
    }

    public override void Attack(Creature opponent)
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
            Tools.PrintBattleInfo($"{Name} has leveled up to {Level}!");
        } else {
            Tools.PrintBattleInfo($"{Name} has {Experience}/{NextLevelExperience} experience!");
        }
    }
}