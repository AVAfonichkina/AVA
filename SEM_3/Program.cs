// Написать программу, которая принимает на вход цифры,
// обозначающую день недели и проверяет,
// является ли этот день выходным.
// 0 1 2 3  4  5  6 // а если ввел 7 (воскресенье), то...
// 7 8 9 10 11 12 13
// 14

string GetInfoByDayOfWeek(int day)
{
    if (day == 6 || day == 7)
        return ("выходной");
    else if (day >= 1 || day <= 5)
        return ("будни");
    else
        return ("ничего не понятно но очень интересно");
}
Console.WriteLine(GetInfoByDayOfWeek(6));

// деление: /, mod, div
// 14 / 5 = 2.8
// 14 mod 5 = 4 (остаток от деления)
// 14 div 5 = 2 (неполное частное)
int number = 123;
int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

// деление: /, mod, div
// 14 / 5 = 2.8
// 14 mod 5 = 4 (остаток от деления)
// 14 div 5 = 2 (неполное частное)
int number = 12345;

while (number >= 100)
{
    number = number / 10;
    Console.WriteLine(number);
}
Console.WriteLine(number % 10);

// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

int number = 123;
if (number < 100)
{
    Console.WriteLine("исло не то");
}
else
{
    while (number >= 100)
    {
        number = number / 10 //надо доделать для этой задачи
    }
    Console.WriteLine(number % 10); // аналогично
}








