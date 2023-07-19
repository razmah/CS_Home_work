/* Задача 66.
    Задайте значения M и N. Напишите программу, которая
    найдет сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8 -> 30                                     */

Console.Clear();

int M = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

Console.WriteLine($"M = {M}; N = {N} -> {NumberSum(M, N)}");

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

int NumberSum(int startValue, int endValue)
{   
    if (startValue == endValue)
        return startValue;
    
    return NumberSum(startValue + 1, endValue) + startValue;
}