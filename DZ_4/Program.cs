// Задача 777:
// using static Library;
// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)
int GetNumberByUser(string text)
  {
    Console.Write(int ...);
    return Convert.ToInt32(Console.ReadLine());
  }

// 2. Создание массива
// int[] <- (int)
int[] CreateArray(int size)
  {
    return new int[size + 1];
  }


// 3. Заполнение массива 0 и 1
// void <- (int[])
void GetCubes(int[] colNumber)
  {
    int count = colNumber.Length;

    for (int i = 0; i < count; i++)
    {
      colNumber[i] = Random.Shared.Next(2);
    }
  }

// 4. Печать массива
// string <- (int[])
string Print(int[] numbers)
{
    string output = String.Empty;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine(numbers[i]);
    }
}
 
// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 76543210
// 10110100 = 1*2^7 + 0*2^6 + 1*2^5 + 1*2^4 + 0*2^3 + 0*2^2 + 1*2^2 + 0*2^1 + 0*2^0
//        2

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
    return $"{String.Join("", bin)} >> {dec}";
}
Console.WriteLine(GoodPrint(new int[] { 1, 0, 1, 1, 1, 1, 0 }, 56));

//ДОПОЛНИТЕЛЬНАЯ ПОЛНЫЙ ЦИКЛ РЕШЕНИЯ С РАЗБИВКОЙ НА МЕТОДЫ КАК В ПРЕДЫДУЩЕЙ ЗАДАЧЕ
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12