/* Задача 68. 
    Напишите программу вычисление функции Аккермана с помощью
    рекурсии. Даны два неотрицательных числа m и n.
        m = 2, n = 3 -> A(m,n) = 9
        m = 3, n = 2 -> A(m,n) = 29                            */

Console.Clear();

int m = GetNumberFromUser("Введите число m: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число n: ", "Ошибка ввода!");

AkkermanFunction(m, n);

Console.WriteLine($"A(m,n) = {AkkermanFunction(m, n)}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {   
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber)) 
            {
                if (UserNumber >= 0)
                    return UserNumber;
            }
        Console.WriteLine(errorMessage);
    }
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    else 
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

