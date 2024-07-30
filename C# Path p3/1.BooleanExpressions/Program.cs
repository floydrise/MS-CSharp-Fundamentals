// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

string permission = "Admin";
int level = 56;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }

}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }

    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }

}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

