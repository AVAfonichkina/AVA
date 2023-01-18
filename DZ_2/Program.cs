// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void NumberXXX (int number)
{
    if (number < 100)
     {
         Console.WriteLine("Напишите трёхзначное число");
     }
     else
     {
        while (number >= 100)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
     }    
 }    
NumberXXX(498343);


// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

 void NumberThree (int number)
 {
     if (number < 100)
     {
         Console.WriteLine("Третьей цифры нет");
     }
     else 
     {
         while (number > 999)
         {
             number = number / 10;
         }
         Console.WriteLine(number % 10);
     }
 }
 NumberThree(32679);


// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

 string DayOfWeek(int day)
 {
     if (day == 6 || day == 7)
         return ("выходной");
     else if (day >= 1 || day <= 5)
         return ("будни");
         else
        return ("ничего не понятно но очень интересно");
 }
 Console.WriteLine(DayOfWeek(6));