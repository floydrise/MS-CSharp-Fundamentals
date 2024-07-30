Console.WriteLine("Enter number between 5 and 10");
string? readResult;
bool validNumber = false;
int numericValue = 0;


do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        if (int.TryParse(readResult, out numericValue) && numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }

        else if (int.TryParse(readResult, out numericValue) && numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
        }

        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }

    }


} while (validNumber == false);
Console.WriteLine($"Input value ({numericValue}) has been accepted");