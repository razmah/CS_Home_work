/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

Console.Clear();

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "");
string AnyNumber = Convert.ToString(Number);
if (AnyNumber.Length > 2)
{
  Console.WriteLine("Третья цифра -> " + AnyNumber[2]);
}
else 
  Console.WriteLine("-> третьей цифры нет");
