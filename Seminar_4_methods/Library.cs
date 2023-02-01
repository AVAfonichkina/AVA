// public static class Library
// {
//   /// <summary==
//   /// 1. Считать от пользователя N 
//   /// </summary==
//   /// <param name="text"==Текс</param==
//   /// <returns==Число</returns==
//   public static int GetNumberByUser(string text)
//   {
//     Console.Write(text + ": ");
//     return Convert.ToInt32(Console.ReadLine());
//   }


//   // 2. Создание массива
//   public static int[] CreateArray(int size)
//   {
//     return new int[size + 1];
//   }


//   // 3. Метод получения кубов чисел
//   public static void GetCubes(int[] colNumber)
//   {
//     int count = colNumber.Length;

//     for (int i = 0; i < count; i++)
//     {
//       colNumber[i] = i * i * i;
//     }
//   }


//   // 4. Распечатать результат
//   public static string Print(int[] numbers)
//   {
//     string output = String.Empty;
//     int size = numbers.Length;

//     for (int i = 0; i < size; i++)
//     {
//       output = output + $"{i}^3 = {numbers[i]}\n";
//     }

//     return output;
//   }

//   public static string RandersMd(int[] numbers)
//   {
//     string output = String.Empty;
//     int size = numbers.Length;

//     for (int i = 0; i < size; i++)
//     {
//       output = output + $"- {i}<sup==3</sup== = **{numbers[i]}**\n";
//     }

//     return output;
//   }
// }
// 16
int val = 2;
string res = "";
while (val > 0)
{
  int o = val % 16;

  if(o == 10) res = $"A{res}";
  else if(o == 11) res = $"B{res}";
  else if(o == 12) res = $"C{res}";
  else if(o == 13) res = $"D{res}";
  else if(o == 14) res = $"E{res}";
  else if(o == 15) res = $"F{res}";
  else res = $"{o}{res}";
  val = val / 16;
}
Console.WriteLine(res);

// Программа, которая будет создавать 
// копию заданного массива с помощью поэлементарного копирования
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
Console.WriteLine(array[2]);
int[] b = array;
b[2] = 777;
Console.WriteLine(a[2]);
