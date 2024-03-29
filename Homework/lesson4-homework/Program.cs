﻿/*
Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.Clear();
Console.Write("Введите число A: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int result = firstNum;
for (int i = 1; i != secondNum; i++)
{
    result = result * firstNum;
    }
Console.WriteLine(result);
*/

/*
Console.Clear();
Console.Write("Введите число A: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int NaturalDegree(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i != numB; i++)
    {
        result = result * firstNum;
    }
    return result;
}
int naturalDegree = NaturalDegree(firstNum, secondNum);
Console.WriteLine($"{firstNum}, {secondNum} -> {naturalDegree}");
*/

//________________________________________________________________________________________________________

/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int result = 0;
for (int i = num; i > 0; i = i / 10)
{
    result = i % 10;
    sum = sum + result;
}
Console.Write($"Сумма цифр в числе {num} -> {sum} ");
*/

/*
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumOfDigits(int number)
{
    int sum = 0;
    int result = 0;
    for (int i = number; i > 0; i = i / 10)
    {
        result = i % 10;
        sum = sum + result;
    }
    return sum;
}
int sumOfDigits= SumOfDigits(num);
Console.Write($"Сумма цифр в числе {num} -> {sumOfDigits} ");
*/

//______________________________________________________________________________________________

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
Console.Clear();
int[] array = new int[8];
int firstPartArray = 5;
int secondPartArray = 5;
PrintArray(array, secondPartArray, firstPartArray);
void PrintArray(int[] arr, int secondPartArr, int firstPartArr)
{
    Random ranArray = new Random();
    int count = array.Length;
    Console.Write("Исходный массив: ");
    for (int i = 0; i < count; i++)
    {
        arr[i] = ranArray.Next(0, 100);
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < firstPartArr; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 4) Console.Write(", ");
    }
    Console.Write(" -> [");
    for (int i = 0; i < firstPartArr; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 4) Console.Write(", ");
    }
    Console.WriteLine("]");
    for (int i = secondPartArr; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.Write(" -> [");
    for (int i = secondPartArr; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}
*/

Console.Clear();
int[] array = new int[8];

PrintArray(array);
void PrintArray(int[] arr)
{
    Random ranArray = new Random();
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = ranArray.Next(0, 100);
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.Write(" -> [");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

