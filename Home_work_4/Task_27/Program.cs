/* Напишите программу, которая принимает на вход число и выдаёт
сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12                                                  */

Console.Clear();

int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

int result = SumOfNumbers(number);

Console.WriteLine($"{number} -> {result}");

int GetNumberFromUser(string Message, string ErrorMessage)
{
    while (true)
    {
        Console.Write(Message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;
        Console.WriteLine(ErrorMessage);
    }
}

int SumOfNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}