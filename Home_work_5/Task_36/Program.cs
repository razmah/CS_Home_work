/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях.
    [3, 7, 23, 12,] -> 19
    [-4, -6, 89, 6] -> 0                                     */

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода!");

int [] massive = GetArray(size, minValue, maxValue);
Console.Write(String.Join(" ", massive));

int result = SumOfOddNumbers(massive);
Console.Write($" -> {result}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;
        Console.WriteLine(errorMessage);
    }
}

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumOfOddNumbers(int [] arr)
{
    //int count = 0;
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + arr [i];
    }
    return sum;
}