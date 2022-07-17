/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть");
}
else
{
    Console.WriteLine("неверные координаты");
}
*/

/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return ("первая четверть");
    if (xc < 0 && yc > 0) return ("вторая четверть");
    if (xc < 0 && yc < 0) return ("третья четверть");
    if (xc > 0 && yc < 0) return ("четвертая четверть");
    return ("неверные координаты");

}
string quarter = Quarter(x, y);
Console.WriteLine($"{quarter} {x} : {y}");
*/

/*
Задача 18. Напишити программу, 
которая по задонному номеручетверти, 
показывает диапазон возможных координат точек в этой четверти от x до y
Console.Clear();
Console.WriteLine("Введите номер четверти ");
int x = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc)
{
    if (xc == 1) return ("xc > 0 и yc > 0");
    if (xc == 2) return ("xc < 0 и yc > 0");
    if (xc == 3) return ("xc < 0 и yc < 0");
    if (xc == 4) return ("xc > 0 и yc < 0");
    return ("неверные координаты");
}
string quarter = Quarter(x);
Console.WriteLine($"{quarter}");
*/

/*
Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.Write("введите x координаты:");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDistance(firstX, firstY, secondX, secondY));
double GetDistance(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay))), 2, MidpointRounding.ToZero);
}
*/

/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
WriteSquareTable(n);
void WriteSquareTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($" | {i} | {i * i, 2} | ");
        i++;
    }
}
*/


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

Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());

void Palindromecheck(int check)
{
    int variable = 0;
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