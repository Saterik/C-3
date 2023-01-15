// Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками
// Маленькие буквы к заменить большими буквами К
//А большие С заменить маленькими с

string text = "- Я думаю, - сказал князь, улыбаясь - что, "
            + "ежели вас псолали вместо нашего милого Винценгероде,"
            + " вы бы сказали приступом согласие Прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]-- r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    


    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText , 'к', 'К');
Console.WriteLine(newText);
