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
// int val = 2;
// string res = "";
// while (val > 0)
// {
//   int o = val % 16;

//   if(o == 10) res = $"A{res}";
//   else if(o == 11) res = $"B{res}";
//   else if(o == 12) res = $"C{res}";
//   else if(o == 13) res = $"D{res}";
//   else if(o == 14) res = $"E{res}";
//   else if(o == 15) res = $"F{res}";
//   else res = $"{o}{res}";
//   val = val / 16;
// }
// Console.WriteLine(res);

// // Программа, которая будет создавать 
// // копию заданного массива с помощью поэлементарного копирования
// int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
// Console.WriteLine(array[2]);
// int[] b = array;
// b[2] = 777;
// Console.WriteLine(a[2]);


// сортировака двумерного массива. Пока не работает код, надо докрутить.
// void Print(int[,] m)
// {
//   for (int i = 0; i < m.GetLength(0); i++)
//   {
//     for (int j = 0; j < m.GetLength(1); j++)
//     {
//       Console.Write($"{m[i, j],3}");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }


// void Sort(int[,] matrix2D)
// {
//   for (int k = 0; k < matrix2D.GetLength(0); k++)
//   {
//     int size = matrix2D.GetLength(1);
//     for (int i = 0; i < size - 1; i++)
//     {
//       int pos = i;
//       for (int j = i + 1; j < size; j++)
//       {
//         if (matrix2D[k, j] < matrix2D[k, pos]) pos = j;
//       }
//       int temp = matrix2D[k, i];
//       matrix2D[k, i] = matrix2D[k, pos];
//       matrix2D[k, pos] = temp;
//     }
//   }
// }


// int[,] matrix = new int[4, 5] {{4, 5, 3, 2, 1},
//                                 {5, 6, 3, 2, 1},
//                                 {5, 4, 3, 2, 1},
//                                 {5, 6, 4, 1, 1}};


// Print(matrix);
// Sort(matrix);
// Print(matrix);


// m * n
// 4 2 5 6 5
// 3 4 6 7 8 
// 6 4 5 6 7
// 3 4 5 6 7



// собрать сроку с числами от a до b от меньшего к большему
// итеративный подход
// string NumberFor(int a, int b)
// {
//   string result = String.Empty;
//   for (int i = a; i <= b; i++)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }
// // рекурсивный
// string NumberRec(int a, int b)
// {
//   if (a <= b) return $"{a} " + NumberRec(a + 1, b);
//   else return String.Empty;
// }
// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));

// // собрать сроку с числами от a до b от большего к меньшему
// string NumberFor(int a, int b)
// {
//   string result = String.Empty;
//   for (int i = a; i >= b; i--)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }
// // и рекурсивный
// string NumberRec(int a, int b)
// {
//   if (a <= b) return NumberRec(a + 1, b) + $"{a} ";
//   else return String.Empty;
// }
// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));


// // сумма чисел от 1 до n
// // итеративный
// int SumFor(int n)
// {
//   int result = 0;
//   for (int i = 1; i <= n; i++) result += i;
//   return result;
// }
// // рекурсивный
// int SumRes(int n)
// {
//   if (n == 0) return 0;
//   else return n + SumRec(n -1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// // факториал числа
// int FactorialFor(int n)
// {
//   int result = 1;
//   for (int i = 1; i <= n; i++) result *= i;
//   return result;
// }
// int FactorialRec(int n)
// {
//   if (n == 1) return 1; // здесь еще надо бы на ноль домножить, ибо факториал 0 = 1
//   else return n * FactorialRec(n - 1); 
// }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10)); 

// // вычислить а в энной степени
// int PowerFor(int a, int n)
// {
//   int result = 1;
//   for (int i = 1; i <= n; i++) result *= a;
//   return result;
// }

// int PowerRec(int a, int n)
// {
//   return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//   if (n == 0) return 1; 
//   else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//   if (n == 0) return 1;
//   else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//   else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(10));  // 1024
// Console.WriteLine(PowerRec(10));  // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

// // В некотором машинном алфавите имеются четыре
// // буквы «а», «и», «с» и «в». Покажите все слова,
// // состоящие из T букв, которые можно построить из букв
// // этого алфавита

// // Перебор слов
// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//  Console.WriteLine($"{n++,-5}{s[i]}");
// }

// // но возникает сложность, если нам нужны пятибуквенные и т.д слова:
// // 
// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
//   {
//     for (int j = 0; j < count; j++)
//      {
//         for (int k = 0; k < count; k++)
//           {
//             for (int l = 0; l < count; l++)
//           {
//           Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//           }
//           }
//       }
//   }
// // общее решение:

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//  if (length == word.Length)
//  {
//  Console.WriteLine($"{n++} {new String(word)}"); return;
//  }
//  for (int i = 0; i < alphabet.Length; i++)
//  {
//  word[length] = alphabet[i];
//  FindWords(alphabet, word, length + 1);
//  }
// }
// FindWords(“аисв”, new char[5]); // 5 -- счетчик слов, по сколько букв должно быть в массиве строки


// как обойти директорию и посмотреть, что находить в папках?
// итеративно:
// string path = "/Users/Admin/Desktop/projectGB1";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//   Console.WriteLine(fi[i].Name);
// }

// рекурсивно:
// void CatalogInfo(string path, string indent = "")
// {
//  DirectoryInfo catalogs = new DirectoryInfo(path);
//  foreach (var currentCatalog in catalogs.GetDirectories())
//  {
//  Console.WriteLine($"{indent}{currentCatalog.Name}");
//  CatalogInfo(currentCatalog.FullName, indent + " ");
//  }
//  foreach (var item in catalogs.GetFiles())
//  {
//  Console.WriteLine($"{indent}{item.Name}");
//  }
// }
// string path = @"/Users/Admin/Desktop/projectGB1";
// CatalogInfo(path);


// игра в пирамидки (для 3 шпилей и 4 блинов в данном случае. Цифры менять можно)
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
  if (count > 1) Towers(with, some, on, count - 1);
  Console.WriteLine($"{with} >> {on}");
  if (count > 1) Towers(some, on, with, count - 1);
}

Towers();


// обходи "деревьев" (бинарне дерево)
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}