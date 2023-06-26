/* Напишите цикл, который принимает на вход два числа (А и В)
и возводит число А в натуральную степень В. 
    3, 5 -> 243
    2, 4 -> 16                                               */

Console.Clear();

int A = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");

int result = DegreeOfNumber(A, B);

Console.WriteLine($"{A}, {B} -> {result}");

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

int DegreeOfNumber(int number_1, int number_2)
{
    int res = (int)Math.Pow(number_1, number_2);
    return res;
}