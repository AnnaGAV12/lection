// В тексте все пробелы нужно заменить на черточки, 
//маленькие буквы "к" на большие "К", 
//а большие "С" заменить на маленькие"с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли пристпом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s [3]//r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);