// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string GoodPrint(string input, int positiveNumberCount)
{
    return $"{input} >> {positiveNumberCount}";
}

string ReadUserInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();

}

string[] FormatInput(string input)
{
    return input.Replace(" ", "").Split(",");
}

int GetPositiveNumbersCount(string[] array)
{
    int positiveNumberCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = int.Parse(array[i]);
        if (currentNumber > 0)
        {
            positiveNumberCount++;
        }
    }
    return positiveNumberCount;
}

string input = ReadUserInput("Введите числа через запятую: ");
string[] formattedInput = FormatInput(input);
int positiveNumberCount = GetPositiveNumbersCount(formattedInput);
Console.WriteLine(GoodPrint(input, positiveNumberCount));

// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// (double, double) GoodPrint(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     return (x, y);
// }

// double GetValue(string text)
// {
//     Console.Write(text);
//     return Convert.ToDouble(Console.ReadLine());
// }

// double k1 = GetValue("Введите K1: ");
// double b1 = GetValue("Введите B1: ");
// double k2 = GetValue("Введите K2: ");
// double b2 = GetValue("Введите B2: ");

// var r = GoodPrint(k1, b1, k2, b2);
// Console.WriteLine(r.Item1);
// Console.WriteLine(r.Item2);
// Console.WriteLine(r);