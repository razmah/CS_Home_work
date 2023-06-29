/* Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.   */

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
double minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
double maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода");

double [] massive = GetArray(size, minValue, maxValue);
Console.Write(String.Join($" ", massive.Select(n => $"{n:f2}")));

double diff = Difference(massive);
Console.Write($" -> {diff:f2}");

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

double [] GetArray(int size, double minValue, double maxValue)
{
    double [] res = new double [size];

    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().NextDouble() * (maxValue + Math.Abs(minValue)) + minValue;
    }
    return res;
}

double Difference(double [] arr)
{
    double minNumber = arr [0];
    double maxNumber = arr [0];
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] < minNumber)
            minNumber = arr [i];
        if (arr [i] > maxNumber)
            maxNumber = arr [i];
        sum = maxNumber - minNumber;
    }   
    return sum;
}