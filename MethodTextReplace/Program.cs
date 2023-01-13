
string Text = "Hello, my dudes";

string ReplaceText(string Text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = Text.Length;
    for(int i = 0; i < length; i++)
    {
        if(Text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{Text[i]}";
    }


    return result;
}
string newText = ReplaceText(Text, ' ', '-');
Console.WriteLine(newText);