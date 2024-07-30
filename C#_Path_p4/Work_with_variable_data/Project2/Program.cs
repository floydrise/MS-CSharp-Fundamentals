string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string [] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);
for (int i = 0; i < orderIDs.Length; i++)
{
    if (orderIDs[i].Length == 4)
    {
        System.Console.WriteLine(orderIDs[i]);
    }
    else
    {
        System.Console.WriteLine($"{orderIDs[i]} - Error");
    }
}