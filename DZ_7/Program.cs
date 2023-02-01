// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double RandomNumberBetween(double minValue, double maxValue, Random rnd)
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
            matrix[i, j] = RandomNumberBetween(-10, 10, rnd);
        }
    }
}

int m = ReadDimension("Введите m: ");
int n = ReadDimension("Введите n: ");
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

void GoodPrint(int[,] matrix, int rowsNumber, int columnsNumber)
{
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            Console.Write(matrix[rowIndex, columnIndex]);

            if (columnIndex != columnsNumber - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix, int rowsNumber, int columnsNumber)
{
    var rnd = new Random();
    for (int rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(0, 10);
        }
    }
}

void PrintNumberAtInputPosition(int inputPosition, int columnsNumber, int[,] matrix)
{
    int resultRow = (inputPosition - 1) / columnsNumber;
    int resultColumn = (inputPosition - 1) % columnsNumber;

    int result = matrix[resultRow, resultColumn];
    Console.WriteLine($"{inputPosition} -> {result}");
}


int rowsNumber = 5;
int columnsNumber = 5;
int[,] matrix = new int[rowsNumber, columnsNumber];

FillMatrix(matrix, rowsNumber, columnsNumber);
GoodPrint(matrix, rowsNumber, columnsNumber);

int inputPosition = int.Parse(Console.ReadLine());
int maxPosition = rowsNumber * columnsNumber;

if (inputPosition > maxPosition || inputPosition < 1)
{
    Console.WriteLine($"{inputPosition} -> Такого числа в массиве нет");
}
else
{
    PrintNumberAtInputPosition(inputPosition, columnsNumber, matrix);
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

int RandomNumberBetween(Random rnd)
{
    return rnd.Next(0, 10);
}

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
                Console.Write("; ");
            }
        }
        Console.WriteLine();
    }
}

int GetIntFromConsole(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());

}

void FillArray(int[,] matrix, Random rnd)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = RandomNumberBetween(rnd);
        }
    }
}

void PrintColumnAverage(int columnIndex, int[,] matrix, int rowsNumber, int columnsNumber)
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
        Console.Write("; ");
    }
}

int rowsNumber = GetIntFromConsole("Введите количество строк: ");
int columnsNumber = GetIntFromConsole("Введите количество столбцов: ");
int[,] matrix = new int[rowsNumber, columnsNumber];
FillArray(matrix, new Random());
GoodPrint(matrix);

Console.WriteLine(new string('-', columnsNumber * 3));
for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    PrintColumnAverage(columnIndex, matrix, rowsNumber, columnsNumber);
}