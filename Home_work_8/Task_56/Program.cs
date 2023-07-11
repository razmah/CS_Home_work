/* Задача 56.
    Задайте прямоугольный двумерный массив. Напишите программу,
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        5 2 6 7 
    Программа считает сумму элементов в каждой строке и выдает 
    номер строки с наименьшей суммой элементов: 1 строка. */

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов в массиве: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение элемента массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение элемента массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, minValue, maxValue);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой: {GetNumberRow(array)}");

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

int SumRow(int[,] arr, int i)
{
    int sum = arr[i, 0];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    return sum;
}

int GetNumberRow(int[,] arr)
{
    int minSum = 0;
    int sum = SumRow(arr, 0);

    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        int tempSum = SumRow(arr, i);
        if (sum > tempSum)
        {
            sum = tempSum;
            minSum = i;
        }
    }
    return minSum;
}