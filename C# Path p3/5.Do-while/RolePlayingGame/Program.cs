Random dice = new();
int heroHealth = 10;
int monsterHealth = 10;

do
{

    int roll = dice.Next(1, 11);
    monsterHealth -= roll;

    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;
    {
        roll = dice.Next(1, 11);
        heroHealth -= roll;

        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");
    }

} while (monsterHealth > 0 && heroHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero won!" : "Monster won!");
