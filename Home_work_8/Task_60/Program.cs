/* Задача 60.
    Сформируйте трехмерный массив из неповторяющихся
    двухзначных чисел. Напишите программу, которая будет
    построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 х 2 х 2.                                    */

Console.Clear();

int x = GetNumberFromUser("Введите ребро массива: ", "Ошибка ввода!");
int y = GetNumberFromUser("Введите вершину массива: ", "Ошибка ввода!");
int z = GetNumberFromUser("Введите грань массива: ", "Ошибка ввода!");
int[,,] array = GetArray(new int[] { x, y, z }, 10, 99);

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

int[,,] GetArray(int[] size, int min, int max)
{
    int[,,] arr = new int[size[0], size[1], size[2]];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);

                if (FindElement(arr, element))
                    break;
                arr[i, j, k] = element;
                k++;
            }
        }
    }
    return arr;
}

bool FindElement(int[,,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j ,k] == element)
                    return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}