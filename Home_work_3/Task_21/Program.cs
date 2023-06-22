/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве */

Console.Clear();

double x1 = Coordinate("x" , "A");
double y1 = Coordinate("y" , "A");
double z1 = Coordinate("z" , "A");

double x2 = Coordinate("x" , "B");
double y2 = Coordinate("y" , "B");
double z2 = Coordinate("z" , "B");

int Coordinate(string CoordinateName, string PointName)
{
    Console.Write($"Введите координату {CoordinateName} точки {PointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Distance :f2}");


