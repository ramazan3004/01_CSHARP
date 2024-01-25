// Считать с консоли строку, состояшую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromString(string s)
{
    string Letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        Letters = Letters + e;
    }
    return Letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);
