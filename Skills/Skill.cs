class Skill
{
    public string Name { get; set; }
    public EffectTypeEnum Type { get; set; }
    public Object Value { get; set; }

    public Skill(string name, EffectTypeEnum type, Object value)
    {
        Name = name;
        Type = type;
        Value = value;
    }

    public void Use()
    {
        Tools.PrintBattleInfo($"You have used {Name} skill!");
        Thread.Sleep(5000);
    }

    public override string ToString()
    {
        return $"Skill: {Name} ({Type}) {Value}";
    }
}