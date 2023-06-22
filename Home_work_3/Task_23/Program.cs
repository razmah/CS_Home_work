/* Напишите программу, которая на вход принимает число (N)
и выдает таблицу кубов чисел от 1 до N */

Console.Clear();

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "");

int index = 1;
int StringCubes = 0;

while (index <= Number)
{   
    StringCubes = (int)Math.Pow(index, 3);
    Console.Write($"{StringCubes} ");
    index++;
}