Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string? readResult;
bool validEntry = false;
string role1 = "Administrator";
string role2 = "Manager";
string role3 = "User";
role1 = role1.ToLower();
role2 = role2.ToLower();
role3 = role3.ToLower();

do
{
    readResult = Console.ReadLine();
    readResult = readResult?.Trim();
    readResult = readResult?.ToLower();

    if (readResult != null)
    {

        if (readResult == role1 || readResult == role2 || readResult == role3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, {readResult}, is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }


} while (validEntry == false);

Console.WriteLine("Your input value has been accepted.");