/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран. */

Console.Clear();

int size = 8;
int minValue = GetNumberFromUser("Введите минимальное значение: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите минимальное значение: ", "Ошибка ввода!");

int [] array = GetArray(size, minValue, maxValue);

Console.Write($"{String.Join(" ", array)} -> ");

Write(array);

int GetNumberFromUser(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
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

void Write (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i + 1 == size)
            Console.Write($"{array[i]}");
        else 
            Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

