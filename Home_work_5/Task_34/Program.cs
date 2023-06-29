/* Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве */

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

int [] massive = GetArray(size, 100, 999);
Console.Write(String.Join(" ", massive));

int result = EvenNumbers(massive);
Console.Write($" -> {result}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int EvenNumbers(int [] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] % 2 == 0)
            count++;
    }
    return count;
}