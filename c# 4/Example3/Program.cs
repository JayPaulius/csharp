Console.WriteLine("Введите текст");
string text = Console.ReadLine();

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += newValue;
        else result += text[i];
    }

    return result;
}

string newText = Replace(text, ' ', '-');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');

Console.WriteLine(newText);



// string text = "к С к С к С";
// char[] text2 = text.ToArray();
// for (int i = 0; i < text.Length; i++)
// {
//     if (text2[i] == ' ')
//         text2[i] = '-';
//     else if (text2[i] == 'к')
//         text2[i] = 'К';
//     else if (text2[i] == 'С')
//         text2[i] = 'с';
// }
// text = new string(text2);
// Console.WriteLine(text);
