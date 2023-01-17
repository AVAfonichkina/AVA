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
    Console.WriteLine ("Большее число: ");
    Console.WriteLine (n1);
    Console.WriteLine ("Меньшее число: ");
    Console.WriteLine (n2);
}
else
{
    Console.WriteLine ("Большее число: ");
    Console.WriteLine (n2);
    Console.WriteLine ("Меньшее число: ");
    Console.WriteLine (n1);
}

