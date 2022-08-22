// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Clear();
// Console.Write("Введите число N:");
// int number = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int num)
// {
//     if (num == 0) return;
//     NaturalNumber(num - 1);
//     Console.Write($"{num}  ");
// }

// NaturalNumber(number);

//---------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.Clear();
// Console.Write("Введите число M:");
// int numberM = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N:");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.Write($"M = {numberM}; N = {numberN} -> ");
// NaturalNumber(numberM, numberN);

// void NaturalNumber(int m, int n)
// {
//     if (m == n)
//     {
//         Console.Write($"{m}");
//         return;
//     }
//     else
//     {
//         if (m < n)
//         {
//             Console.Write(m + ",");
//             NaturalNumber(m + 1, n);
//             return;
//         }
//         else
//         {
//             if (m > n)
//             {
//                 Console.Write(m + ",");
//                 NaturalNumber(m - 1, n);
//                 return;
//             }
//         }
//     }
// }

//----------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// int res = SumReturnDigital(number, sum);
// Console.Write($"Сумма цифр числа {number} -> {res} ");

// int SumReturnDigital(int dig, int sum)
// {
//     if (dig == 0)
//     {
//         return sum;
//     }
//     else
//     {
//         sum += dig % 10;
//         return SumReturnDigital(dig / 10, sum);
//     }
// }

//----------------------------------------------------------------------------------

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В:");
int b = Convert.ToInt32(Console.ReadLine());

if (b >= 0)
{
    int raisingNumber = RaisingNumber(a, b);
    Console.Write($"A = {a}; B = {b} - > {raisingNumber}");
}
else
{
    Console.Write($"Неверная степень числа В:{b}");
}

int RaisingNumber(int a, int b)
{
    if (b == 0) return 1;
    return RaisingNumber(a, b - 1) * a;
}
