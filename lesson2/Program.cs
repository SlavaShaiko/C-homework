/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = numA * numA;
if (result == numB)
{
    Console.WriteLine($"{numA}, {numB} -> да");
}
else
{
    if (numB * numB == numA)
    {
        Console.WriteLine($"{numA}, {numB} -> да");
    }
    else
    {
        Console.WriteLine($"{numA}, {numB} -> нет");
    }
}
*/
