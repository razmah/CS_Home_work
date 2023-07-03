/* Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввел пользователь. */

Console.Clear();

Console.Write("Введите количество M-чисел: ");

int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];

Massive(M);
int result = InitNumber(array); 

Console.WriteLine();
Console.Write($"{String.Join(", ", array)} -> {result}");

void Massive(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
}

int InitNumber(int [] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] > 0)
            count++;
    }
    return count;
}