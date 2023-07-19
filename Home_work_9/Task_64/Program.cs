/* Задача 64. 
    Задайте значения N. Напишите программу, которая выведет
    все натуральные числа в промежутку от N до 1. Выполните с помощью
    рекурсии. 
        N = 5 -> 5, 4, 3, 2, 1                                          */

Console.Clear();

Console.Write("Введите число N: ");
int value = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"N = {value} -> {GetNumber(value, 1)}");

string GetNumber(int endValue, int startValue)
{
    if (startValue == endValue)
        return endValue.ToString();
    
    return endValue + ", " + GetNumber(endValue - 1, startValue);
}
