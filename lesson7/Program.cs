// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Clear();
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(-10, 10);
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
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] getMatrix = GetMatrix(3, 4);
// PrintMatrix(getMatrix);

//-------------------------------------------------------------------------------------------------------------

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
//             matrix[i, j] = rnd.Next(-10, 10);
//             // if (i % 2 == 0 && j % 2 == 0)
//             // {
//             //     matrix[i, j] *= matrix[i, j];   И убрать int[,] GetArray(int[,] matrix)!!!
//             // }
//         }
//     }
//     return matrix;
// }
// int[,] GetArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
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
//             if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
//             else Console.Write($"{array[i, j],3}]");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] getMatrix = GetMatrix(3, 4);
// Console.WriteLine("-----------------------");
// PrintMatrix(getMatrix);
// Console.WriteLine("-----------------------");
// int[,] getArray = GetArray(getMatrix);
// PrintMatrix(getArray);
// Console.WriteLine("-----------------------");

//---------------------------------------------------------------------------------------------------------

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// 20 мин
Console.Clear();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetSumOpt(int[,] arr)
{
    int sum = 0;
    int length = 0;
    if (arr.GetLength(0) >= arr.GetLength(1)) length = arr.GetLength(1);
    else length = arr.GetLength(0);
    for (int j = 0; j < length; j++)
        sum += arr[j, j];

    return sum;
}



void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, |");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}
int[,] getMatrix = GetMatrix(3, 4);
int getSumOpt = GetSumOpt(getMatrix);
Console.WriteLine("-----------------------");
PrintMatrix(getMatrix);
Console.WriteLine("-----------------------");
Console.Write($"Сумма элементов главной диагонали: = {getSumOpt}");
GetSumOpt(getMatrix);


