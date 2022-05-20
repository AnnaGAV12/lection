// 1 группа методов: например указать авторство
void Method1()
{
    Console.WriteLine("Автор Ф.И.О. ");
}
//Method1();  //Вызов метода



// 2 группа методов: 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 5); // можно менять местами
//Method21(count: 5, msg: "Текст");


// 3 группа методов
//int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);


// 4 группа методов
//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);


// Вид 4а
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0;i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);