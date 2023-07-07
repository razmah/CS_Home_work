/* Задача 52.  
    Задайте двумерный массив целых чисел.
    Найдите среднее арифметическое элементов в каждом столбце. */

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов в массиве: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение элемента в массиве: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение элемента в массиве: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
AverageArifm(array);

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

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageArifm(int[,] arr)
{   
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average = average + arr[i, j];
        }
        average = average / arr.GetLength(1);
        Console.Write($"{average:f2}" + " ");
    }
}