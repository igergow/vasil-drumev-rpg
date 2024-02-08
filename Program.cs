using System.Threading;
Console.Clear();
Console.WriteLine("Моля изберете герой:");
Console.WriteLine("1. Джудже");
Console.WriteLine("2. Елф");
Console.WriteLine("3. Човек");

var heroType = int.Parse(Console.ReadLine());

Hero hero;
if (heroType == 1) {
    hero = new Dwarf("Джудже");
} else if (heroType == 2) {
    hero = new Elf("Елф");
} else {
    hero = new Human("Човек");
}

Console.Clear();

for (int i = 0; i < 10; i++)
{
    hero.BattleNumber = i;
    Monster monster;
    Random random = new Random();
    var opponentType = random.Next(1, 100);
    if (opponentType % 2 == 1)
    {
        monster = new Goblin($"Goblin-{i}");
    } else {
        monster = new Orc($"Orc-{i}");
    }
    
    int timer = 0;
    while(monster.IsAlive() && hero.IsAlive())
    {
        timer += 1;
        if (timer % (int)(1 / monster.AttackSpeed * 1000) == 0)
        {
            monster.Attack(hero);
        }
        if (hero.IsAlive())
        {
            if (timer % (int)(1 / hero.AttackSpeed * 1000) == 0)
            {
                if (hero is Dwarf)
                {
                    var dwarf = (Dwarf) hero;
                    dwarf.SpecialAttack(monster);
                } else {
                    hero.Attack(monster);
                }
            }
        }
        Thread.Sleep(1);
    }

    var x = Console.CursorLeft;
    var y = Console.CursorTop;
    if (monster.IsAlive())
    {
        Tools.PrintBattleInfo($"{monster.Name} wins!");
        break;
    }
    else
    {
        hero.LevelUp();
        Tools.PrintBattleInfo($"{hero.Name} gained {hero.Experience}/{hero.NextLevelExperience} XP!");
        Thread.Sleep(10000);
        Tools.PrintBattleInfo($"{hero.Name} has {hero.Health} health left!");
        Thread.Sleep(10000);
    }
}