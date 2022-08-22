// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

int sum = SumNaturalElements(m, n, result);
Console.Write($"Сумма натуральных элементов в промежутке от M = {m} до N = {n} -> {sum} ");
Console.WriteLine();

int SumNaturalElements(int m, int n, int res)
{
    if (m > n) return res;
    else
    {
        res = res + m;
        return SumNaturalElements(m + 1, n, res);
    }
}