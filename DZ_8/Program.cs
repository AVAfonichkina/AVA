// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


int GetIntFromConsole(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int RandomNumberBetween(Random rnd)
{
    return rnd.Next(0, 10);
}


void GoodPrint(int[,] matrix, int lineNumber, int columnsNumber)
{
    for (int lineIndex = 0; lineIndex < lineNumber; lineIndex++)
    {
        for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
        {
            Console.Write(matrix[lineIndex, columnIndex]);

            if (columnIndex != columnsNumber - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}


void FillArray(int[,] matrix, Random rnd)
{
    for (int lineIndex = 0; lineIndex < matrix.GetLength(0); lineIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[lineIndex, columnIndex] = RandomNumberBetween(rnd);
        }
    }
}


int GetMinSum(int[,] matrix, int lineIndex, int columnsNumber)
{
    int sum = 0;
    for (int columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
    {
        sum = sum + matrix[lineIndex, columnIndex];
    }

    return sum;
}

void PrintMinSumLineNumbers(int[,] matrix, int lineNumber, int columnsNumber)
{
    int minSumLineIndex = 0;
    int minSum = GetMinSum(matrix, minSumLineIndex, columnsNumber);

    for (int lineIndex = 1; lineIndex < lineNumber; lineIndex++)
    {
        int iteratedRowSum = GetMinSum(matrix, lineIndex, columnsNumber);

        if (iteratedRowSum < minSum)
        {
            minSumLineIndex = lineIndex;
            minSum = iteratedRowSum;
        }
    }

    Console.WriteLine($"Минимальное значение суммы строки элементов: {minSumLineIndex + 1}");
}

int lineNumber = GetIntFromConsole("Введите количество строк: ");
int columnsNumber = GetIntFromConsole("Введите количество столбцов: ");
int[,] matrix = new int[lineNumber, columnsNumber];
FillArray(matrix, new Random());
GoodPrint(matrix, lineNumber, columnsNumber);
Console.WriteLine(new string('-', columnsNumber * 3));
PrintMinSumLineNumbers(matrix, lineNumber, columnsNumber);
