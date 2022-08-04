/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());
int check = palindrome;
int variable = 0;
int currentVariable = 0;
while (check > 0)
{
    variable = check % 10;
    currentVariable = currentVariable * 10 + variable;
    check = check / 10;
}
if (palindrome == currentVariable)
{
    Console.WriteLine($"{palindrome} -> Да");
}
else
{
    Console.WriteLine($"{palindrome} -> Нет");
}
*/
/*
Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());// Решение с помощью метода

void Palindromecheck(int check)
{
    int variable = 0;                // Решение с помощью метода
    int currentVariable = 0;
    while (check > 0)
    {
        variable = check % 10;
        currentVariable = currentVariable * 10 + variable;
        check = check / 10;
    }
    if (palindrome == currentVariable)
        Console.WriteLine($"{palindrome} -> Да");
    else
        Console.WriteLine($"{palindrome} -> Нет");

}
Palindromecheck(palindrome);
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*
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
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
WriteCubeTable(n);
void WriteCubeTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($" | {i} | {i * i * i,3} | ");
        i++;
    }
}









