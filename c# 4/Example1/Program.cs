string Method(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    
    return result;
}

string text = Method(10, "1");
Console.WriteLine(text);