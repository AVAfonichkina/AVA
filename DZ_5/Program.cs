// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

1. Считывание данных от пользователя 
   1. Считать int число
   int <- string
   2. Считать double число
   double <- string

   int GetNumberByUser(string text)
  {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
  }

2. Создать массив
   1. int-чисел
   int[] <- int 
   2. double-чисел
   double[] <- int 

   int[] CreateArray(int size)
  {
    return new int[size];
  }

3. Заполнить массив
   1. Случайным образом
   int[] <- (int, min, max)
   double[]<- (int)

   2. с клавиатуры
   int[] <- (void)
   double[]<- (void)

void GetCubes(int[] colNumber)
  {
    int count = colNumber.Length;
    for (int i = 0; i < count; i++) 
      colNumber[i] = Random.Shared.Next(2);
  }

4. Найти произведения
   int[] <- int[]
   double[] <- double[]

   res[i] = a[i] * a[N - 1 - i]

5. Распечатать
   string <- int[]
   ТЕКСТОВЫЙ ФАЙЛ <- int[]

string GoodPrint(int[] bin, int dec)
{
  return $"\n{String.Join("", bin)} >> {dec}";
}

     
