// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double RandomNumber(double minValue, double maxValue, Random rnd)
{
    var next = rnd.NextDouble();
    return minValue + (next * (maxValue - minValue));
}

void GoodPrint(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowLength = matrix.GetLength(1);
        for (int j = 0; j < currentRowLength; j++)
        {
            Console.Write(matrix[i, j].ToString("F1"));
            if (j != currentRowLength - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

int ReadDimension(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());

}

void FillArray(double[,] matrix, Random rnd)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomNumber(-10, 10, rnd);
        }
    }
}

int m = ReadDimension("Введите случайное число m: ");
int n = ReadDimension("Введите случайное число n: ");
double[,] matrix = new double[m, n];
Random rnd = new Random();
FillArray(matrix, rnd);
GoodPrint(matrix);

// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение 
// этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// 1. Ввод данных пользователем:

int rows = ReadInt("Введите индекс элемента: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[9, 8];
FillMatrix(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// 2. Заполнение массива рандомными числами от 1 до 9
void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// 3. Метод вывода массива
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// 4. Метод ввода данных
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

// Получение количества строк и столбцов от пользователя
int GetIntFromConsole(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

// Выведение рандомных чисел в объеме строк и столбцов
int RandomNumber(Random rnd)
{
    return rnd.Next(0, 10);
}

// Создание из всего этого массива
void FillArray(int[,] matrix, Random rnd)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); 
                columnIndex++)
        {
            matrix[rowIndex, columnIndex] = RandomNumber(rnd);
        }
    }
}

// Печать результата
void GoodPrint(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowLength = matrix.GetLength(1);
        for (int j = 0; j < currentRowLength; j++)
        {
            Console.Write(matrix[i, j]);
            if (j != currentRowLength - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

void PrintColumnAverageValue(int columnIndex, int[,] matrix, int rowsNumber, int columnsNumber)
{
    double sum = 0.0;
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        sum = sum + matrix[rowIndex, columnIndex];
    }

    double average = sum / rowsNumber;
    Console.Write(average.ToString("0.#"));

    if (columnIndex != columnsNumber - 1)
    {
        Console.Write(" | ");
    }
}

int rowsNumber = GetIntFromConsole("Задайте количество строк: ");
int columnsNumber = GetIntFromConsole("Задайте количество столбцов: ");
int[,] matrix = new int[rowsNumber, columnsNumber];
FillArray(matrix, new Random());
GoodPrint(matrix);

// Среднее арифметическое
Console.WriteLine(new string('_', columnsNumber * 7));
for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    PrintColumnAverageValue(columnIndex, matrix, rowsNumber, columnsNumber);
}