// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// Считывание данных от пользователя 
// 1. Считать int число
// int <- string
// 2. Считать double число
// double <- string


string GetNumberByUser(int[] array)
{
  return $"[{String.Join(",", array)}]";;
}

int ReadArrayLength(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

// Создать массив
// 1. int-чисел
// int[] <- int 
// 2. double-чисел
// double[] <- int  
int[] CreateArray(int length)
{
  return new int[length];
}

// Заполнить массив
// 1. Случайным образом
// int[] <- (int, min, max)
// double[]<- (int)
// 2. с клавиатуры
// int[] <- (void)
// double[]<- (void)

void FillArray(int[] array)
{
  Random completion = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = completion.Next(1, 10);
  }
}

// Найти произведения
//  int[] <- int[]
//  double[] <- double[]
//  res[i] = a[i] * a[N - 1 - i]

int[] ProductOfNumbers(int[] array)
{
  int[] result;
  int size = array.Length / 2; 
  if (array.Length % 2 == 1) 
  {
    size++; 
  }
result = new int[size];

  for (int i = 0; i < size; i++) 
  {
    result[i] = array[i] * array[array.Length - 1 - i];
  }
  if (array.Length % 2 == 1)  
  {
    result[size - 1] = array[array.Length / 2];
  }
  return result; 
}

// Распечатать новый массив
//  string <- int[]
//  ТЕКСТОВЫЙ ФАЙЛ <- int[]

int length = ReadArrayLength("Введите длину массива (N): ");
int[] array = CreateArray(length);
FillArray(array);
int[] result = ProductOfNumbers(array);
Console.WriteLine(GetNumberByUser(array) + " -> " + 
GetNumberByUser(result));
