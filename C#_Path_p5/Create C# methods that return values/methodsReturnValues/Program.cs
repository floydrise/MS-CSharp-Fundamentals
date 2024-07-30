Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target,roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult;
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.ToLower() == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

string WinOrLose(int target, int roll)
{
    string result = "";
    if(roll > target)
    {
        result = "You win";
        return result;
    }
    else
    {
        result = "You lose";
        return result;
    }
}