﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Clear();
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}, |");
            else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int[,] getMatrix = GetMatrix(3, 4);
PrintMatrix(getMatrix);

//------------------------------------------------------------------------------------------------------------
// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}, |");
//             else Console.Write($"{array[i, j], 3}]");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] getMatrix = GetMatrix(3, 4);
// PrintMatrix(getMatrix);
//--------------------------------------------------------------------------------------------------------------------
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(0, 9);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}, |");
//             else Console.Write($"{array[i, j], 3}]");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] getMatrix = GetMatrix(3, 4);
// PrintMatrix(getMatrix);










//--------------------------------------------------------------------------------------------------------------------
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// 20 мин
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
