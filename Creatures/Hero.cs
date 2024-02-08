abstract class Hero : Creature
{
    public override double AttackSpeed { get {
        if (rightHand != null)
        {
            if(rightHand.Attributes.ContainsKey(ItemAttributesEnum.AttackSpeed))
            {
                return base.AttackSpeed + (double) rightHand.Attributes[ItemAttributesEnum.AttackSpeed];
            }
        }
        return base.AttackSpeed;    
    } }
    public int BattleNumber { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int NextLevelExperience { get {
        return 1000 * Level;
    } }
    public List<Item> Stash { get; set; }
    public Item rightHand { get; set; }
    public Item chest { get; set; }
    public List<Skill> Skills { get; set; }
    public Hero(string name, int health, int damage) 
        : base(name, health, damage, 0)
    {
        Level = 1;
        Experience = 0;
        Stash = new List<Item>();
        Skills = new List<Skill>();
        Tools.PrintBattleInfo($"A new hero has been created: {Name}");
        Thread.Sleep(500);
    }

    public void AddToStash(Item item)
    {
        Tools.PrintBattleInfo($"Adding {item} to stash");
        Thread.Sleep(2000);
        Stash.Add(item);
    }

    public void UseItem(Item item)
    {
        if(item.itemTypeEnum == ItemTypeEnum.WEAPON)
        {
            rightHand = item;
            Tools.PrintBattleInfo($"Equipping {item} to right hand");
            Thread.Sleep(2000);
        } else if (item.itemTypeEnum == ItemTypeEnum.ARMOR)
        {
            chest = item;
            Tools.PrintBattleInfo($"Equipping {item} to body");
            Thread.Sleep(2000);
        } else {
            item.Use();
        }
    }

    public void ThrowItem(Item item)
    {
        Tools.PrintBattleInfo($"Throwing {item} from stash");
        Thread.Sleep(2000);
        Stash.Remove(item);
    }

    public override void Attack(Creature opponent)
    {
        int additionalDamage = 0;
        if (rightHand != null)
        {
            if(rightHand.Attributes.ContainsKey(ItemAttributesEnum.Damage))
            {
                additionalDamage += (int) rightHand.Attributes[ItemAttributesEnum.Damage];
            }
        }
        Experience += (int) Damage;
        base.Attack(opponent, additionalDamage);
    }

    public void ResetHealth()
    {
        Health = DefaultHealth;
    }

    public void UseSkill(Skill skill, Creature opponent)
    {
        if (Skills.Contains(skill))
        {
            Tools.PrintBattleInfo($"{Name} is using {skill.Name} skill!");
        } else {
            Tools.PrintBattleInfo($"{Name} does not know {skill.Name} skill!");
        }
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