// Вид 1
// ничего не возвращают и ничего не принимают
void Method()
{
    Console.WriteLine("Автор...");
}
// Как вызываются подобного рода методы:
Method1();

// Вид 2
// Ничего не возвращают, но могут принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

// пример
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        i++; // инкремент - увеличение, // декремент - уменьшение
    }
}
Method21("Текст", count: 4);
Method21(count: 4, msg: "Новый текст"); // Если используем именованые аргументы, неважно в каком они порядке

// Вид 3
// Что-то возвращает, но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4
// Что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // В Стринг вместо Емпти лежит значение "..."

     while (i < count)
     {
        result = result + text;
        i++;
     }    
     return result;
}
string res = Method4(10, "adfg");
Console.WriteLine(res);

// иии мэйджик! Сейчас вместо 4 вида мы сделаем цикл FOR
string Method4(int count, string text)
{
  
    string result = String.Empty; // В Стринг вместо Емпти лежит значение "..."
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }    
    return result;
}
string res = Method4(10, "adfg");
Console.WriteLine(res);