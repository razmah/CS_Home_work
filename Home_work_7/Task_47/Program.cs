/* Задача 47. 
    Задайте двумерный массив размером m на n, заполненный
    случайными вещественными числами. */

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов в массиве: ", "Ошибка ввода!");
double minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
double maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода!");

double[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine($"m = {rows}, n = {columns}");
Console.WriteLine();
PrintArray(array);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;
        Console.WriteLine(errorMessage);
    }
}

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] arr = new double[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * (maxValue + Math.Abs(minValue)) + minValue;
        }
    }
    return arr;
}

void PrintArray(double [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray [i, j]:f2} ");
        }
        Console.WriteLine();
    }   
}


