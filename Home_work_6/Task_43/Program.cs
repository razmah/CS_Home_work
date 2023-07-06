/* Напишите программу, которая найдет точку пересечения 
двух прямых, заданных уравнениями:
    y = k1 * x + b1;
    y = k2 * x + b2;
Значения b1, k1, b2 и k2 задаются пользователем. */

Console.Clear();

double b1 = GetNumberFromUser("Введите b1: ", "Ошибка ввода!");
double k1 = GetNumberFromUser("Введите k1: ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите b2: ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите k2: ", "Ошибка ввода!");

double[] result = IntersectionCheck(b1, k1, b2, k2);

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
Write(result);

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double[] IntersectionCheck(double b1, double k1, double b2, double k2)
{
    double x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k2 * ((b2 - b1) / (k1 - k2)) + b2;

    double[] arr = { x, y };
    return arr;
}

void Write(double[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 == arr.Length)
            Console.Write($"{arr[i]:f2}");
        else
            Console.Write($"{arr[i]:f2}; ");
    }
    Console.Write(")");
}