// Задача 64: Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
Console.Write($"Все натуральные числа от N = {number} до 1 -> ");

NaturalNumbers(number, temp);
void NaturalNumbers(int n, int k)
{
    if (n == 0) return;
    else
    {
        if (n == k) Console.Write($"{n}, ");
        if (n < k) Console.Write($"{n}, ");
        NaturalNumbers(n - 1, k);
        return;
    }
}






