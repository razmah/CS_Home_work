/* Задача 58.
    Напишите программу, которая будет находить
    произведение двух матриц.
    Например, даны 2 матрицы:
        2 4 | 3 4
        3 2 | 3 3
    Результирующая матрица будет:
        18 20 
        15 18                                       */

Console.Clear();

int rows1 = GetNumberFromUser("Введите количество строк в 1-ом массиве: ", "Ошибка ввода!");
int columns1 = GetNumberFromUser("Введите количество столбцов в 1-ом массиве: ", "Ошибка ввода!");
int minValue1 = GetNumberFromUser("Введите минимальное значение элемента в 1-ом массиве: ", "Ошибка ввода!");
int maxValue1 = GetNumberFromUser("Введите максимальное значение элемента в 1-ом массиве: ", "Ошибка ввода!");
int[,] array1 = GetArray(rows1, columns1, minValue1, maxValue1);

int rows2 = GetNumberFromUser("Введите количество строк во 2-ом массиве: ", "Ошибка ввода!");
int columns2 = GetNumberFromUser("Введите количество столбцов во 2-ом массиве: ", "Ошибка ввода!");
int minValue2 = GetNumberFromUser("Введите минимальное значение элемента во 2-ом массиве: ", "Ошибка ввода!");
int maxValue2 = GetNumberFromUser("Введите максимальное значение элемента во 2-ом массиве: ", "Ошибка ввода!");
int[,] array2 = GetArray(rows2, columns2, minValue2, maxValue2);

int[,] result = new int[array1.GetLength(0), array2.GetLength(1)]; // умножение строки первого массива на столбец второго массива

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
MultiplicationArray(array1, array2, result);
PrintArray(result);

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

void MultiplicationArray(int[,] arr1, int[,] arr2, int[,] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum = sum + arr1[i, k] * arr2[k, j];
            }
            res[i, j] = sum;
        }
    }
}