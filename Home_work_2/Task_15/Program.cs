/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.Clear();

Console.Write("Введите цифру, обозначающую день недели: ");
string input = Console.ReadLine() ?? "";
int Digit = int.Parse(input);

if (Digit == 6 || Digit == 7)
{
    Console.WriteLine($"{Digit} -> да");
}
else if (Digit < 1 || Digit > 7)
{
    Console.WriteLine($"Такой цифры, обозначающую день недели, нет!");
}
else 
    Console.WriteLine($"{Digit} -> нет");