﻿/* Задача 50. 
    Напишите программу, которая на вход принимает
    позиции элемента в двумерном массиве, и возвращает
    значение этого элемента или же указание, что такого элемента нет */

Console.Clear();

int rows = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов в массиве: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение элемента в массиве: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение элемента в массиве: ", "Ошибка ввода!");
int number = GetNumberFromUser("Введите значение элемента: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindNumberArray(array, number);

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

void FindNumberArray(int[,] findElement, int userNumber)
{
    bool find = false;
    for (int i = 0; i < findElement.GetLength(0); i++)
    {
        for (int j = 0; j < findElement.GetLength(1); j++)
        {
            if (findElement[i, j] == userNumber)
            {
                Console.WriteLine($"Число {userNumber} находится по координатам " + "(" + i + ", " + j + ")");
                find = true;
            }
        }
    }
    if (!find)
        Console.WriteLine($"Число {userNumber} в массиве нет.");
}