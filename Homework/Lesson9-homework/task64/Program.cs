// Задача 64: Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Все натуральные числа от N = {number} до 1 -> ");
int quotationMarks = 0;
NaturalNumbers(number, quotationMarks);
void NaturalNumbers(int n, int quotationMarks)
{
    if (n == 0) return;
    else
    {
        if (quotationMarks == 0) Console.Write($"''{n}, ");
        else if (n > 1) Console.Write($"{n}, ");
        if (n == 1) Console.Write($"{n}'' ");
        NaturalNumbers(n - 1, quotationMarks + 1);
        return;
    }
}
