// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1; y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

Console.Clear();
Console.Write("Введите b1= ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1= ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2= ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2= ");
double k2 = Convert.ToDouble(Console.ReadLine());

PrintPoints(b1, b2, k1, k2);
void PrintPoints(double pointsB1, double pointsB2, double pointsK1, double pointsK2)
{
    if (pointsB1 == pointsB2 || pointsK1 == pointsK2) Console.Write("нет точки пересечения");
    else
    {
        double x = (pointsB2 - pointsB1) / (pointsK1 - pointsK2);
        double y = (pointsK1 * x) + pointsB1;
        Console.Write($"b1 = {pointsB1}, k1 = {pointsK1}, b2 = {pointsB2}, k2 = {pointsK2} -> ({Math.Round(x, 1)}; {Math.Round(y, 1)})");
    }
}











