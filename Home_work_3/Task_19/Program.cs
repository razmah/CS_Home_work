/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом */

Console.Clear();

Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine() ?? "";
int Num = int.Parse(Number);

void ChekingNumberFor5Digits(string Number)
{
    while ((Num % 10 == Num / 10000) && (Num / 1000 % 10 == Num / 10 % 10))
    {
         Console.WriteLine($"{Number} -> да");
         return;
    }
    Console.WriteLine($"{Number} -> нет");              
}
       

if (Num > 9999 && Num < 100000)
{
    ChekingNumberFor5Digits(Number);
}
else 
    Console.WriteLine($"Это не пятизначное число!");


