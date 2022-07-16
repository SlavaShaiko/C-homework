/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.Write("Введите координату X точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distanceofpoints(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
double distanceofpoints = Math.Round(Distanceofpoints(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками  {distanceofpoints}");