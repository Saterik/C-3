// Вид 1
void Method1()
{
    Console.WriteLine(" Автор ...");

}
//Method1(); (Для демонстрации тключил вызов метода)




//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//вид2.1
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method3(msg: "Текст", count: 4);   //Выводит слово Текст 4 раза


//вид 3

int Method3()
{
    return DateTime.Now.Year;
}
//it year = Method3();
//Console.WriteLine(year);

// Вид4
string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;

while (i < count)
{
    result = result + text;
    i++;
}
return result;
}
string res = Method4(10, "asdf ");
Console.WriteLine(res);

