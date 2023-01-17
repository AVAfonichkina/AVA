// Задача 2: Напишите программу, которая 
// на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int n1, n2;
Console.WriteLine("Введите первое целое число ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine (n1);
}
else
{
    Console.WriteLine (n2);
}

// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих 
// чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int n1, n2, n3;
Console.WriteLine("Введите первое целое число ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine (n1);
}
else if (n2 > n3 && n2 > n1)
{
    Console.WriteLine (n2);
}
else
{
    Console.WriteLine (n3);
}

// Задача 6: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число ");
string number = Console.ReadLine();
int index = 0;

if (number[index] % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.Write("Нечётное");
}

// Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все 
// чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int N = array.Length;
int index = 0;

while (index < N)
{
    if (array[index] % 2 == 0)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
