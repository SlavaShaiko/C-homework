﻿/*
Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все чётные 
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.Write("Введите число N= ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 2;
if(N < 0)
{
index = N % 2;
}

while(index <= N)
{
    Console.Write($"  {index}  ");
    index = index + 2;
}