﻿// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

bool Palindrome(int val1)
{
    int val2 = 0;
    int t = val1;
    while (val1 > 0)
    {
        int f = val1 % 10;
        val1 = val1 / 10;
        val2 = val2 * 10 + f;
    }
    return t == val2;
}
Console.WriteLine(Palindrome(14112));


// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) 
                    + (y1 - y2) * (y1 - y2) 
                    + (z1 - z2) * (z1 - z2));
}
int x1 = 0;
int x2 = 8;
int y1 = 0;
int y2 = 6;
int z1 = 0;
int z2 = 0;

Console.WriteLine(GetDistance(x1, x2, y1, y2, z1, z2));



// Задача 23
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// int n = 5;

for (int i = 0; i < n; i++) // конечно этот способ мне куда больше нравится.
{
  Console.WriteLine(i*i*i);
}

// "не колхозный способ":

int GetNumberByUser()
{
  Console.WriteLine("напишите любое целое число от 1 д N");
  return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    return new int[size + 1];
}

void GetCube(int[] collectionNumber)
{
   int count = collectionNumber.Length;
   for (int i = 1; i < count; i++)
   {
     collectionNumber[i] = i * i * i;
   }
}

void Print(int[] numbers)
{
  //string output = String.Empty; // делаем так, чтобы обнулить output на всякий 
  int size = numbers.Length;
  for (int i = 1; i < size; i++)
  {
    Console.WriteLine(numbers[i]);
    //output = output + $"{i}^3 = {numbers[i]}\n"; Все методы "для красоты" пока что отложим..
  }
  //return output;
}

int sizego = GetNumberByUser();
int[] arrCube = CreateArray(sizego);
GetCube(arrCube);
Print(arrCube);