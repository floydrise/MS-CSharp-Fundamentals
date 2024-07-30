Console.Clear();
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

System.Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
System.Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}\n");
System.Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C}\n{newProduct}\t\t{newReturn:P2}\t{newProfit:C}";

Console.WriteLine(comparisonMessage);
Console.ReadLine();