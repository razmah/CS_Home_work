/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */

Console.Clear();

Console.Write("Введите трёхзначное число: ");
string input = Console.ReadLine() ?? "";

int Number = int.Parse(input);
int SecondNumber = Number / 10 % 10;


Console.WriteLine($"{Number} -> {SecondNumber}");