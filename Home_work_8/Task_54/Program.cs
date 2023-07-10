/* Задача 54. 
    Задайте двумерный массив. Напишите программу, которая
    упорядочит по убыванию элементы каждой строки двумерного
    массива. 
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
    В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов в массиве: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, minValue, maxValue);

PrintArray(array);
Console.WriteLine();
SortingArray(array);
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

void SortingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}
