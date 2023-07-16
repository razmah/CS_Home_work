/* Задача 62.
    Напишите программу, которая заполнит спирально
    массив 4 на 4.
    Например, на выходе получается вот такой массив:
        01 02 03 04
        12 13 14 05
        11 16 15 06
        10 09 08 07                                   */

Console.Clear();

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
int[,] resultArray = SnakeArray(array);

PrintSnakeArray(resultArray);

int[,] SnakeArray(int[,] arr)
{
    int count = 1; // счетчик заполнения массива
    int i = 0;
    int j = 0;

    while (count <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = count;
        count++;

        if (i <= j + 1 && i + j < arr.GetLength(1) - 1) 
            j++; // верхняя сторона массива и не достигли правой стороны -> двигаемся вправо
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++; // на правой стороне массива и не достигли нижней стороны -> двигаемся вниз
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--; // на нижней стороне и не достигли левой стороны -> двигамся влево 
        else
            i--; // иначе двигаемся вверх
    }
    return arr;
}

void PrintSnakeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] / 10 == 0)
                Console.Write($" 0{arr[i, j]} ");
            else
                Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
