string pangram = "The quick brown fox jumps over the lazy dog";

string [] message = pangram.Split(' ');
string [] newMessage = new string [message.Length];

for (int i = 0; i < message.Length; i++)
{
    char [] messageChars = message[i].ToCharArray();
    Array.Reverse(messageChars);
    newMessage[i] = new string(messageChars);
}

string printMessage = string.Join(' ', newMessage);
System.Console.WriteLine(printMessage);

