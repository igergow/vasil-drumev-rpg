class NPC : Creature
{
    public NPC(string name) 
        : base(name, 1000000000, 0, 0)
    {
    }

    public void Talk()
    {
        Tools.PrintBattleInfo("Просто си говоря!");
        Thread.Sleep(5000);
    }

    public override void Attack(Creature opponent)
    {
        Tools.PrintBattleInfo($"Howdy, ${opponent.Name}! I'm peace maker!");
        Thread.Sleep(5000);
    }
}