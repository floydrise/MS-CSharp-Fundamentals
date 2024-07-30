const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Quantity display
const string openingSpan = "<span>";
const string closingSpan = "</span>";
int spanCountBeginning = input.IndexOf(openingSpan);
int spanCountEnding = input.IndexOf(closingSpan);
spanCountBeginning += openingSpan.Length;
int spanLength = spanCountEnding - spanCountBeginning;
quantity = input.Substring(spanCountBeginning, spanLength);

//Output display
output = input;
const string openingDiv = "<div>";
const string closingDiv = "</div>";
int divCountBeginning = output.IndexOf(openingDiv);
int divCountEnding = output.IndexOf(closingDiv);
divCountBeginning += openingDiv.Length;
int divLength = divCountEnding - divCountBeginning;
/* string input1 = input;
input1 = input1.Replace("&trade", "&reg"); */
output = output.Substring(divCountBeginning, divLength);
output = output.Replace("&trade;", "&reg;");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");