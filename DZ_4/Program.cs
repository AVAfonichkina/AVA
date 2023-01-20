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
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
  }

// 2. Создание массива
// int[] <- (int)
int[] CreateArray(int size)
  {
    return new int[size];
  }

// 3. Заполнение массива 0 и 1
// void <- (int[])
void GetCubes(int[] colNumber)
  {
    int count = colNumber.Length;
    for (int i = 0; i < count; i++) 
      colNumber[i] = Random.Shared.Next(2);
  }

// 4. Печать массива
// string <- (int[])
string ArrayToString(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++) result += array[i];
    return result;
}
 
// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])
// 76543210
// 10110100 = 1*2^7 + 0*2^6 + 1*2^5 + 1*2^4 + 0*2^3 + 0*2^2 + 1*2^2 + 0*2^1 + 0*2^0
//        2

int ConvertToDuo(int[] array)
{
int result = 0;
for (int i = 0, p = array.Length - 1; 
    i <array.Length || p >= 0; i++, p--) 
    result += array[i] * IntPow(2, p);
return result;
}    

int IntPow(int number, int pow)
{
  if (pow == 0) return 1;
  if (pow == 1) return number;
  int result = number;
  for (int i = 1; i < pow; i++) result = result * number;
  return result;
}

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
  return $"{String.Join("", bin)} >> {dec}";
}
int length = GetNumberByUser("Введите любое целое число - длину двоичного числа: ");
Console.WriteLine();
int [] binaryNumber = CreateArray(length);
GetCubes(binaryNumber);
Console.WriteLine("Двоичное число: " + ArrayToString(binaryNumber));
int dec = ConvertToDuo(binaryNumber);
Console.WriteLine(GoodPrint(binaryNumber, dec));

//ДОПОЛНИТЕЛЬНАЯ ПОЛНЫЙ ЦИКЛ РЕШЕНИЯ С РАЗБИВКОЙ НА МЕТОДЫ КАК В ПРЕДЫДУЩЕЙ ЗАДАЧЕ
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
