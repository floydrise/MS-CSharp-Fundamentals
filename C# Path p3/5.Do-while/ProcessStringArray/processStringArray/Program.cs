string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    while (periodLocation != -1)
    {
        string newSentence = "";
        newSentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(newSentence);
    }
Console.WriteLine(myString);
}